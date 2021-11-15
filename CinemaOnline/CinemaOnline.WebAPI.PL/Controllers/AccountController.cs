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

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SignIn([FromBody] SignInModelDTO model)
        {
            var identity = GetIdentity(model.Email, model.Password);

            if (identity == null)
            {
                return BadRequest("Incorrect login and (or) password");
            }

            var token = GetToken(identity);

            return Ok(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SignUp([FromBody] SignUpModelDTO model)
        {
            var user = _userService.GetByEmail(model.Email);
            if (user == null && model.Password == model.ConfirmPassword)
            {
                _userService.Add(new UserViewModel { Name = model.Name, Email = model.Email, Password = model.Password });
                return Ok(model);
            }
            else
            {
                return BadRequest("Incorrect login and (or) password");
            }
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

        private string GetToken(ClaimsIdentity identity)
        {
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
