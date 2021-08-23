using AutoMapper;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private TicketDbContext _ticketDbContext;

        public UserRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
        }

        public void Add(UserModel userModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserModel, User>());
            var mapper = new Mapper(config);
            var user = mapper.Map<UserModel, User>(userModel);

            _ticketDbContext.Users.Add(user);
        }

        public UserModel GetByEmail(string email)
        {
            var user = _ticketDbContext.Users.FirstOrDefault(u => u.Email == email);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>());
            var mapper = new Mapper(config);
            var userModel = mapper.Map<User, UserModel>(user);
            return userModel;
        }
    }
}
