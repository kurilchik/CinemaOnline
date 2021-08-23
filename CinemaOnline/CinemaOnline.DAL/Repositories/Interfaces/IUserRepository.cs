using CinemaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Add(UserModel userModel);

        UserModel GetByEmail(string email);
    }
}
