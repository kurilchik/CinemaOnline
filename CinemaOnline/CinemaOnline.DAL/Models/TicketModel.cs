using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Models
{
    public class TicketModel
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int SessionId { get; set; }
    }
}
