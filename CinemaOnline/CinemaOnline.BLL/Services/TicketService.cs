using CinemaOnline.BLL.Services.Interfaces;
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
    public class TicketService : ITicketService
    {
        private TicketDbContext _ticketDbContext;
        private ITicketRepository _ticketRepository;

        public TicketService()
        {
            _ticketDbContext = new TicketDbContext();
            _ticketRepository = new TicketRepository(_ticketDbContext);
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
