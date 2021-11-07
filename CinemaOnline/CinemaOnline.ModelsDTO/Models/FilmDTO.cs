using System.Collections.Generic;

namespace CinemaOnline.ModelsDTO.Models
{
    public class FilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public List<string> Genres { get; set; }
    }
}
