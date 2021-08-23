using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.ViewModels
{
    public class FilmViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public List<CinemaViewModel> Cinemas { get; set; }
        public List<string> Genres { get; set; }
    }
}
