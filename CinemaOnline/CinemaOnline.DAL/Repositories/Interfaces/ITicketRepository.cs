using CinemaOnline.DAL.Models;
using System.Collections.Generic;

namespace CinemaOnline.DAL.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        void Add(TicketModel ticketModel);
        List<UserTicketModel> GetUserTicketsById(int userId);
        List<TicketModel> GetListByUserId(int userId);
    }
}
