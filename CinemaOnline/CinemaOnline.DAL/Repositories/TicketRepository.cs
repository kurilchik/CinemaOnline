using AutoMapper;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CinemaOnline.DAL.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private TicketDbContext _ticketDbContext;
        private IMapper _mapper;

        public TicketRepository(TicketDbContext ticketDbContext, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _mapper = mapper;
        }

        public void Add(TicketModel ticketModel)
        {
            var ticket = new Ticket()
            {
                UserId = ticketModel.UserId,
                SessionId = ticketModel.SessionId
            };

            _ticketDbContext.Tickets.Add(ticket);
        }

        public List<TicketModel> GetListByUserId(int userId)
        {
            var param = new Microsoft.Data.SqlClient.SqlParameter
            {
                ParameterName = "@UserId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = userId
            };

            var tickets = _ticketDbContext.Tickets.FromSqlRaw("CountUserTickets @UserId", param).ToList();
            var ticketModels = _mapper.Map<List<TicketModel>>(tickets);            

            return ticketModels;
        }
    }
}
