using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Models
{
    public class FilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public List<SessionFilmDTO> Sessions { get; set; }
        public List<string> Genres { get; set; }
    }
}
