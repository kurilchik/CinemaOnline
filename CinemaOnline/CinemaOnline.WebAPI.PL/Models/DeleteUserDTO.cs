using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebAPI.PL.Models
{
    public class DeleteUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
