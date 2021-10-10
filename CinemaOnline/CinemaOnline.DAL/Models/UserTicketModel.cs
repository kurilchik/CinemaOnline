using System;

namespace CinemaOnline.DAL.Models
{
    public class UserTicketModel
    {
        public int UserId { get; set; }

        public string FilmName { get; set; }

        public string CinemaName { get; set; }

        public float Price { get; set; }

        public DateTime Time { get; set; }
    }
}
