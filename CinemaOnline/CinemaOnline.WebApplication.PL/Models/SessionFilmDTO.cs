using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Models
{
    public class SessionFilmDTO
    {
        public int Id { get; set; }
        public string CinemaName { get; set; }
        public int FilmId { get; set; }
        public float Price { get; set; }
        public DateTime Time { get; set; }
    }
}
