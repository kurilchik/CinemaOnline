using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaOnline.ModelsDTO.Models
{
    public class SignUpModelDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
