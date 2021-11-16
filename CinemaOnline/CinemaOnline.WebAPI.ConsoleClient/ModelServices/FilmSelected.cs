using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces;

namespace CinemaOnline.WebAPI.ConsoleClient.ModelServices
{
    public class FilmSelected : IFilmSelected
    {
        public FilmSessionDTO Film { get; set; }

        public FilmSelected()
        {
            Film = new FilmSessionDTO();
        }
    }
}
