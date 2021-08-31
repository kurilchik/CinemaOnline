using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.Forms;
using CinemaOnline.PL.ModelServices;
using CinemaOnline.PL.ModelServices.Interfaces;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOnline.PL
{
    public static class DependencyInjectionHelper
    {
        public static Container Bootstrap()
        {
            var container = new Container();

            container.Register<IUserSession, UserSession>(Lifestyle.Singleton);

            container.Register<IUserService, UserService>();
            container.Register<ITicketService, TicketService>();
            container.Register<IFilmService, FilmService>();
            container.Register<ITopUpService, TopUpService>();

            container.RegisterForm<SignInForm>();
            container.RegisterForm<SignUpForm>();
            container.RegisterForm<PreviewForm>();
            //container.RegisterForm<PaymentForm>();
            container.RegisterForm<AccountForm>();
            container.RegisterForm<TopUpBalanceForm>();

            container.Verify();

            return container;
        }

        private static void RegisterForm<TForm>(this Container container) where TForm : Form
        {
            var registration = Lifestyle.Transient.CreateRegistration<TForm>(container);
            registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, "Done manually.");
            container.AddRegistration<TForm>(registration);
        }
    }
}
