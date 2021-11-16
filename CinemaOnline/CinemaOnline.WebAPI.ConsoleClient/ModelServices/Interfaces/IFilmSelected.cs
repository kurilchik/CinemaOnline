using CinemaOnline.ModelsDTO.Models;

namespace CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces
{
    public interface IFilmSelected
    {
        FilmSessionDTO Film { get; set; }
    }
}
