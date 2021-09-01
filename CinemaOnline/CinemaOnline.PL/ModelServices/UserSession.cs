using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.PL.ModelServices
{
    public class UserSession : IUserSession
    {
        public UserViewModel User { get; set; }

        public UserSession()
        {
            User = new UserViewModel();
        }
    }
}
