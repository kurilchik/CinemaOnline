using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.ViewModels
{
    public class FilmViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public List<SessionViewModel> Sessions { get; set; }
        public List<string> Genres { get; set; }
    }
}
