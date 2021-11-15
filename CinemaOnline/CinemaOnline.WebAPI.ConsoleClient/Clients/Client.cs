using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using System;

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
            Entry();
        }

        private void Entry()
        {
            Console.Clear();
            Console.WriteLine("Enter <1> to login");
            Console.WriteLine("Enter <2> to register");

            int userChoice;
            if (int.TryParse(Console.ReadLine(), out userChoice))
            {
                switch (userChoice)
                {
                    case 1: 
                        _accountClient.SignIn();
                        break;
                    case 2:
                        _accountClient.SignUp();
                        break;
                    default:
                        Console.WriteLine("Something wrong!");
                        Console.ReadKey();
                        Entry();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Something wrong!");
                Console.ReadKey();
                Entry();
            }           
            
        }
    }
}
