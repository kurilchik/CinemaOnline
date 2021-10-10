using CinemaOnline.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services.Interfaces
{
    public interface IFilmService
    {
        FilmViewModel GetFilmById(int id);
        List<FilmViewModel> GetAllFilms();
        FilmViewModel GetSessions(FilmViewModel film);
    }
}
