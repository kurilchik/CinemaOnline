using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace CinemaOnline.BLL.Services
{
    public class UserService : IUserService
    {
        private TicketDbContext _ticketDbContext;
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(TicketDbContext ticketDbContext, IUserRepository userRepository, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Add(UserViewModel userViewModel)
        {
            var userModel = _mapper.Map<UserModel>(userViewModel);

            _userRepository.Add(userModel);
            _ticketDbContext.SaveChanges();
        }

        public UserViewModel GetByEmail(string email)
        {
            var user = _userRepository.GetByEmail(email);

            var userViewModel = _mapper.Map<UserViewModel>(user);

            return userViewModel;
        }

        public List<string> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();

            return users;
        }

        public void Update(UserViewModel userViewModel)
        {
            var userModel = _mapper.Map<UserModel>(userViewModel);

            _userRepository.Update(userModel);
            _ticketDbContext.SaveChanges();
        }

        public void Delete(string email)
        {
            _userRepository.Delete(email);
            _ticketDbContext.SaveChanges();
        }
    }
}
