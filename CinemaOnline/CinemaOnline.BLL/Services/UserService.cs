﻿using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;

namespace CinemaOnline.BLL.Services
{
    public class UserService : IUserService
    {
        private TicketDbContext _ticketDbContext;
        private IUserRepository _userRepository;

        public UserService(TicketDbContext ticketDbContext, IUserRepository userRepository)
        {
            _ticketDbContext = ticketDbContext;
            _userRepository = userRepository;
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

        public void Update(UserViewModel userViewModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, UserModel>());
            var mapper = new Mapper(config);
            var userModel = mapper.Map<UserViewModel, UserModel>(userViewModel);

            _userRepository.Update(userModel);
            _ticketDbContext.SaveChanges();
        }
    }
}
