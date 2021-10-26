using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebAPI.PL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebAPI.PL.Controllers
{
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

        [HttpPost]
        public IActionResult GetByEmail([FromBody] string email)
        {
            var user = _userService.GetByEmail(email);
            var model = _mapper.Map<UserDTO>(user);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult PutUser([FromBody] AddUserDTO userDTO)
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
    }
}
