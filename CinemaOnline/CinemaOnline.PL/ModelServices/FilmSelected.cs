using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.ModelServices.Interfaces;

namespace CinemaOnline.PL.ModelServices
{
    class FilmSelected : IFilmSelected
    {
        public FilmViewModel Film { get; set; }

        public FilmSelected()
        {
            Film = new FilmViewModel();
        }
    }
}
