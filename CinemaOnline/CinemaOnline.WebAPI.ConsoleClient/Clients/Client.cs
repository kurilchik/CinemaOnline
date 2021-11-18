using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces;
using System;
using System.Linq;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class Client : IClient
    {
        private IUserAuthorized _user;
        private IFilmSelected _film;
        private IAccountClient _accountClient;
        private IFilmClient _filmClient;

        public Client(IUserAuthorized user, IFilmSelected film, IAccountClient accountClient, IFilmClient filmClient)
        {
            _user = user;
            _film = film;
            _accountClient = accountClient;
            _filmClient = filmClient;
        }

        public void Run()
        {
            Login();
            MainMenu();
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

        private void MainMenu()
        {
            var userChoice = UserChoice("Enter <1> - Main menu", "Enter <2> - Account");

            if (userChoice == 1)
            {
                Films();
            }
            else
            {
                Account();
            }
        }

        private void Films()
        {
            _filmClient.GetAllFilms();

            Console.WriteLine("Please enter the film number:");
            int userChoice;
            if (int.TryParse(Console.ReadLine(), out userChoice))
            {
                _filmClient.GetFilmById(userChoice);

                var choice = UserChoice("Enter <1> to view sessions", "Enter <2> - Main menu");

                if (choice == 1)
                {
                    Sessions();
                }
                else
                {
                    MainMenu();
                }
            }
            else
            {
                Console.WriteLine("Wrong number!");
                Films();
            }

        }

        private void Sessions()
        {
            var sessions = _film.Film.Sessions.Select((value, index) => new { value, index });            

            foreach (var item in sessions)
            {
                Console.WriteLine($"{item.index}. - {item.value.CinemaName}: {item.value.Time}. {item.value.Price}BYN.");
            }

            Console.WriteLine("Please enter the session number:");
            int userChoice;
            if (int.TryParse(Console.ReadLine(), out userChoice))
            {
                var session = sessions.Where(v => v.index == userChoice).Select(s => new { s.value.Id, s.value.Price }).FirstOrDefault();
                _accountClient.BuyTicket(session.Id, session.Price);

                var choice = UserChoice("Enter <1> - Main menu", "Enter <2> - Exit");

                if (choice == 1)
                {
                    MainMenu();
                }
            }
            else
            {
                Console.Clear();
                Sessions();
            }
        }

        private void Account()
        {            
            _accountClient.GetUser(_user.User.Email);

            Console.Clear();
            Console.WriteLine($"Name: {_user.User.Name}");
            Console.WriteLine($"Email: {_user.User.Email}");
            Console.WriteLine($"Password: {_user.User.Password}");
            Console.WriteLine($"Balance: {_user.User.Balance} BYN");

            Console.ReadKey();

            var userChoice = UserChoice("Enter <1> to top up balance", "Enter <2> - Main menu");

            if (userChoice == 1)
            {
                TopUpBalance();
            }
            else
            {
                MainMenu();
            }
        }

        private void TopUpBalance()
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

            Account();
        }

        private int UserChoice(string firstMessage, string secondMessage)
        {
            //Console.Clear();
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
