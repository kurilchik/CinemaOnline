using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.DependencyInjection;
using SimpleInjector;

namespace CinemaOnline.WebAPI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            Bootstrap.Start(container);

            var client = container.GetInstance<IClient>();
            client.Run();
        }
    }
}
