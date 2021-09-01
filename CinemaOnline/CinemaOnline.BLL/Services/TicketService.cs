using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Linq;

namespace CinemaOnline.BLL.Services
{
    public class TicketService : ITicketService
    {
        private TicketDbContext _ticketDbContext;
        private ITicketRepository _ticketRepository;

        public TicketService(TicketDbContext ticketDbContext, ITicketRepository ticketRepository)
        {
            _ticketDbContext = ticketDbContext;
            _ticketRepository = ticketRepository;
        }

        public void Add(int userId, int sessionId)
        {
            var ticket = new TicketModel() { UserId = userId, SessionId = sessionId };

            _ticketRepository.Add(ticket);
            _ticketDbContext.SaveChanges();
        }

        public int CountUserTickets(int userId)
        {
            return _ticketRepository.GetListByUserId(userId).Count();
        }
    }
}
