using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Models
{
    public class TopUpCardModel
    {
        public int Id { get; set; }
        public Guid Card { get; set; }
        public float Amount { get; set; }
        public bool Used { get; set; }
    }
}
