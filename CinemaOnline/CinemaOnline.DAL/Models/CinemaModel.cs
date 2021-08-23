using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Models
{
    public class CinemaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SessionModel> Sessions { get; set; }
    }
}
