using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Models
{
    public class UserTicketDTO
    {
        public string FilmName { get; set; }

        public string CinemaName { get; set; }

        public float Price { get; set; }

        public DateTime Time { get; set; }
    }
}
