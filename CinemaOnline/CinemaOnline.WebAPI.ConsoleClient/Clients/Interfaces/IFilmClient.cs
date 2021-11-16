namespace CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces
{
    public interface IFilmClient
    {
        void GetAllFilms();
        void GetFilmById(int filmId);
    }
}
