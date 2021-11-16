using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.ConsoleClient.Authentication.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Constants;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class AccountClient : IAccountClient
    {
        private IUserAuthorized _user;
        private IToken _token;

        public AccountClient(IUserAuthorized user, IToken token)
        {
            _user = user;
            _token = token;
        }

        public void SignIn()
        {
            Console.Clear();
            Console.WriteLine("*Login*");
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            var password = ReadPassword();

            var model = new SignInModelDTO { Email = email, Password = password };

            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);

                try
                {
                    var result = client.UploadString($"{ClientConstants.AppPath}Account/SignIn", JsonConvert.SerializeObject(model));
                    _token.AuthorizationHeader = ClientConstants.AuthorizationHeader + JsonConvert.DeserializeObject<string>(result);

                    GetUser(model.Email);

                    Console.Clear();
                    Console.WriteLine($"{_user.User.Name}, Welcom to CinemaOnline");
                    Console.ReadKey();
                }
                catch (WebException ex)
                {
                    var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();

                    Console.WriteLine(resp);
                    Console.ReadKey();
                    
                    SignIn();
                }
            }            
        }

        public void SignUp()
        {
            Console.Clear();
            Console.WriteLine("*Sign up*");
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            var password = ReadPassword();
            Console.WriteLine("Enter confirm password:");
            var confirmPassword = ReadPassword();

            var model = new SignUpModelDTO { Name = name, Email = email, Password = password, ConfirmPassword = confirmPassword };

            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);

                try
                {
                    var result = client.UploadString($"{ClientConstants.AppPath}Account/SignUp", JsonConvert.SerializeObject(model));

                    Console.WriteLine("Registration completed successfully!");
                    Console.ReadKey();

                    SignIn();
                }
                catch (WebException ex)
                {
                    var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();

                    Console.WriteLine(resp);
                    Console.ReadKey();

                    SignUp();
                }
            }
        }

        private void GetUser(string email)
        {
            var model = new GetUserDTO { Email = email };

            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);
                client.Headers.Add(_token.AuthorizationHeader);

                try
                {
                    var result = client.UploadString($"{ClientConstants.AppPath}Account/GetUser", JsonConvert.SerializeObject(model));
                    var user = JsonConvert.DeserializeObject<UserDTO>(result);

                    _user.User = user;
                }
                catch (WebException ex)
                {
                    var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();

                    Console.WriteLine(resp);
                    Console.ReadKey();
                }
            }
        }

        public void TopUpBalance(float amount)
        {
            _user.User.Balance += amount;
            var model = new UpdateUserDTO { Email = _user.User.Email, Balance = _user.User.Balance };

            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);
                client.Headers.Add(_token.AuthorizationHeader);

                try
                {
                    var result = client.UploadString($"{ClientConstants.AppPath}Account/UpdateBalance", WebRequestMethods.Http.Put, JsonConvert.SerializeObject(model));

                    Console.WriteLine($"The balance is topped up by {amount} BYN.");
                    Console.ReadKey();
                }
                catch (WebException ex)
                {
                    var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();

                    Console.WriteLine(resp);
                    Console.ReadKey();
                }
            }
        }

        private string ReadPassword()
        {
            string password = String.Empty;
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}
