using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services
{
    public class UserService : IUserService
    {
        private TicketDbContext _ticketDbContext;
        private IUserRepository _userRepository;

        public UserService()
        {
            _ticketDbContext = new TicketDbContext();
            _userRepository = new UserRepository(_ticketDbContext);
        }

        public void Add(UserViewModel userViewModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, UserModel>());
            var mapper = new Mapper(config);
            var userModel = mapper.Map<UserViewModel, UserModel>(userViewModel);

            _userRepository.Add(userModel);
            _ticketDbContext.SaveChanges();
        }

        public UserViewModel GetByEmail(string email)
        {
            var user = _userRepository.GetByEmail(email);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserModel, UserViewModel>());
            var mapper = new Mapper(config);
            var userViewModel = mapper.Map<UserModel, UserViewModel>(user);
            return userViewModel;
        }
    }
}
