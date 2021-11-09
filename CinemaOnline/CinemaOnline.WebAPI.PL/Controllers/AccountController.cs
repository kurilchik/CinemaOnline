using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.PL.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CinemaOnline.WebAPI.PL.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public AccountController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult GetUser([FromBody] GetUserDTO userDTO)
        {
            var user = _userService.GetByEmail(userDTO.Email);
            if (user != null && user.Password == userDTO.Password)
            {
                var model = _mapper.Map<UserDTO>(user);
                return Ok(model);
            }
            else
            {
                return BadRequest();
            }
            
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] AddUserDTO userDTO)
        {
            var user = _userService.GetByEmail(userDTO.Email);
            if (user == null)
            {
                _userService.Add(_mapper.Map<UserViewModel>(userDTO));
                return Ok();
            }
            else
            {
                return BadRequest("User exists");
            }
        }

        [HttpPut]
        public IActionResult UpdateBalance([FromBody] UpdateUserDTO userDTO)
        {
            var user = _userService.GetByEmail(userDTO.Email);
            if (user != null && user.Password == userDTO.Password)
            {
                _userService.Update(_mapper.Map<UserViewModel>(userDTO));
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] DeleteUserDTO userDTO)
        {
            var user = _userService.GetByEmail(userDTO.Email);
            if (user != null && user.Password == userDTO.Password)
            {
                _userService.Delete(userDTO.Email);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SignIn([FromBody] GetUserDTO userDTO)
        {
            var identity = GetIdentity(userDTO.Email, userDTO.Password);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid username or password." });
            }

            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(token);
        }

        private ClaimsIdentity GetIdentity(string email, string password)
        {
            var user = _userService.GetByEmail(email);

            if (user != null && user.Password == password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            return null;
        }
    }
}
