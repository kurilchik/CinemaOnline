using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class Client : IClient
    {
        private IAccountClient _accountClient;
        private IFilmClient _filmClient;

        public Client(IAccountClient accountClient, IFilmClient filmClient)
        {
            _accountClient = accountClient;
            _filmClient = filmClient;
        }

        public void Run()
        {
            _accountClient.SignIn();
            _filmClient.GetAllFilms();
            _filmClient.GetFilmById();
        }
    }
}
