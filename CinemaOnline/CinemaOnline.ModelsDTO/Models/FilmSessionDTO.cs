using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaOnline.ModelsDTO.Models
{
    public class FilmSessionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public List<SessionDTO> Sessions { get; set; }
        public List<string> Genres { get; set; }
    }
}
