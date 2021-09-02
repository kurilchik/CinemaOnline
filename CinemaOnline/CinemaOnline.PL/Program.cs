using CinemaOnline.PL.Forms;
using System;
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

            var container = DependencyInjectionHelper.Bootstrap();

            Application.Run(container.GetInstance<SignInForm>());
        }
    }
}
