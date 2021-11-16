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
            Login();
            TopUpBalance();
        }

        private void Login()
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

        private void TopUpBalance()
        {
            var userChoice = UserChoice("Enter <1> to top up balance", "Enter <2> to continue");

            if (userChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("*Top up balance*");
                Console.WriteLine("Enter amount:");

                float amount;
                if (float.TryParse(Console.ReadLine(), out amount))
                {
                    if (amount > 0 && amount <= 100)
                    {
                        _accountClient.TopUpBalance(amount);
                    }
                    else
                    {
                        Console.WriteLine("Are you crazy? No more than 100 BYN!");
                        Console.ReadKey();
                        TopUpBalance();
                    }                    
                }
                else
                {
                    Console.WriteLine("Wrong amount!");
                    Console.ReadKey();
                    TopUpBalance();
                }
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
