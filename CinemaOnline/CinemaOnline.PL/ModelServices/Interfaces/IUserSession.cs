using CinemaOnline.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.PL.ModelServices.Interfaces
{
    public interface IUserSession
    {
        UserViewModel User { get; set; }
    }
}
