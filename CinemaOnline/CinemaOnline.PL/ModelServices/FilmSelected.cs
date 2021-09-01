using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.ModelServices.Interfaces;
using System.Collections.Generic;

namespace CinemaOnline.PL.ModelServices
{
    public class FilmSelected : IFilmSelected
    {
        public FilmViewModel Film { get; set; }

        public FilmSelected()
        {
            Film = new FilmViewModel();
        }
    }
}
