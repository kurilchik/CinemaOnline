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
            var userChoice = UserChoice("Enter <1> to login", "Enter <2> to register");

            if (userChoice == 1)
            {
                _accountClient.SignIn();
            }
            else
            {
                _accountClient.SignUp();
            }
        }

        private int UserChoice(string firstMessage, string secondMessage)
        {
            Console.Clear();
            Console.WriteLine(firstMessage);
            Console.WriteLine(secondMessage);

            int userChoice;
            if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice == 1 || userChoice == 2)
            {
                return userChoice;
            }
            else
            {
                Console.WriteLine("Choose <1> or <2>");
                Console.ReadKey();
                return UserChoice(firstMessage, secondMessage);
            }
        }
    }
}
