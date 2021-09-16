using AutoMapper;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Linq;

namespace CinemaOnline.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private TicketDbContext _ticketDbContext;
        private IMapper _mapper;

        public UserRepository(TicketDbContext ticketDbContext, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _mapper = mapper;
        }

        public void Add(UserModel userModel)
        {
            var user = new User()
            {
                Name = userModel.Name,
                Email = userModel.Email,
                Password = userModel.Password,
                Balance = userModel.Balance
            };

            _ticketDbContext.Users.Add(user);
        }

        public UserModel GetByEmail(string email)
        {
            var user = _ticketDbContext.Users.FirstOrDefault(u => u.Email == email);
            var userModel = _mapper.Map<UserModel>(user);

            return userModel;
        }

        public void Update(UserModel userModel)
        {
            var user = _ticketDbContext.Users.FirstOrDefault(u => u.Email == userModel.Email);
            user.Balance = userModel.Balance;
        }
    }
}
