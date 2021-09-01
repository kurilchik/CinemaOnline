using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Repositories;
using CinemaOnline.DAL.Repositories.Interfaces;
using CinemaOnline.PL.ModelServices;
using CinemaOnline.PL.ModelServices.Interfaces;
using CinemaOnline.PL.NavigationServices;
using CinemaOnline.PL.NavigationServices.Interfaces;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System.Windows.Forms;

namespace CinemaOnline.PL
{
    public static class DependencyInjectionHelper
    {
        public static Container Bootstrap()
        {
            var container = new Container();

            
            container.Register<IFormOpener, FormOpener>(Lifestyle.Singleton);

            container.Register<IUserSession, UserSession>(Lifestyle.Singleton);
            container.Register<IFilmSelected, FilmSelected>(Lifestyle.Singleton);

            container.Register<IUserService, UserService>();
            container.Register<ITicketService, TicketService>();
            container.Register<IFilmService, FilmService>();
            container.Register<ITopUpService, TopUpService>();

            container.Register<TicketDbContext>(Lifestyle.Singleton);

            container.Register<IUserRepository, UserRepository>();
            container.Register<ITopUpRepository, TopUpRepository>();
            container.Register<ITicketRepository, TicketRepository>();
            container.Register<IFilmRepository, FilmRepository>();
            container.Register<ISessionRepository, SessionRepository>();

            AutoRegisterWindowsForms(container);

            container.Verify();

            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }

        private static void RegisterForm<TForm>(this Container container) where TForm : Form
        {
            var registration = Lifestyle.Transient.CreateRegistration<TForm>(container);
            registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, "Done manually.");
            container.AddRegistration<TForm>(registration);
        }
    }
}
