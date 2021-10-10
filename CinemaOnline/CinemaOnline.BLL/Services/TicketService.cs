using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CinemaOnline.BLL.Services
{
    public class TicketService : ITicketService
    {
        private TicketDbContext _ticketDbContext;
        private ITicketRepository _ticketRepository;
        private IMapper _mapper;

        public TicketService(TicketDbContext ticketDbContext, ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public void Add(int userId, int sessionId)
        {
            var ticket = new TicketModel() { UserId = userId, SessionId = sessionId };

            _ticketRepository.Add(ticket);
            _ticketDbContext.SaveChanges();
        }

        public List<UserTicketViewModel> GetListByUserId(int userId)
        {
            var tickets = _mapper.Map<List<UserTicketViewModel>>(_ticketRepository.GetUserTicketsById(userId));
            return tickets;
        }

        public int CountUserTickets(int userId)
        {
            return _ticketRepository.GetListByUserId(userId).Count();
        }
    }
}
