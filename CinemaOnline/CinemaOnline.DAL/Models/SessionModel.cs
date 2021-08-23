using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Models
{
    public class SessionModel
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public FilmModel Film { get; set; }
        public float Price { get; set; }
        public DateTime Time { get; set; }
    }
}
