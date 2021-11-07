using System;

namespace CinemaOnline.WebAPI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
            film.GetAllFilms();
            film.GetFilmById();
        }
    }
}
