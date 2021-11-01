using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebAPI.PL.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
