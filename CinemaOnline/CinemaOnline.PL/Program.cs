using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.Forms;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOnline.PL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = Bootstrap();

            Application.Run(container.GetInstance<SignInForm>());
        }

        private static Container Bootstrap()
        {
            var container = new Container();

            container.Register<IUserService, UserService>();
            container.RegisterForm<SignInForm>();
            //container.RegisterForm<SignUpForm>();

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
