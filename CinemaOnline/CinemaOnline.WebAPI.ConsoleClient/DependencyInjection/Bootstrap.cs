using CinemaOnline.WebAPI.ConsoleClient.Authentication;
using CinemaOnline.WebAPI.ConsoleClient.Authentication.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Clients;
using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces;
using SimpleInjector;

namespace CinemaOnline.WebAPI.ConsoleClient.DependencyInjection
{
    public class Bootstrap
    {
        public static void Start(Container container)
        {            
            container.Register<IUserAuthorized, UserAuthorized>(Lifestyle.Singleton);
            container.Register<IFilmSelected, FilmSelected>(Lifestyle.Singleton);
            container.Register<IToken, Token>(Lifestyle.Singleton);

            container.Register<IClient, Client>();
            container.Register<IAccountClient, AccountClient>();
            container.Register<IFilmClient, FilmClient>();            

            container.Verify();
        }
    }
}
