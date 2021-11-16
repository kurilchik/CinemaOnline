using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaOnline.ModelsDTO.Models
{
    public class SessionDTO
    {
        public int Id { get; set; }
        public string CinemaName { get; set; }
        public int FilmId { get; set; }
        public float Price { get; set; }
        public DateTime Time { get; set; }
    }
}
