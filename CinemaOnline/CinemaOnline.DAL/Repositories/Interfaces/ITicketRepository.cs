using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        void Add(TicketModel ticketModel);
        List<TicketModel> GetListByUserId(int userId);
    }
}
