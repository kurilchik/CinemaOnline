using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.ConsoleClient.Authentication.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Constants;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class AccountClient : IAccountClient
    {
        private IToken _token;

        public AccountClient(IToken token)
        {
            _token = token;
        }

        public void SignIn()
        {
            Console.Clear();
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            var password = Console.ReadLine();

            var model = new SignInModelDTO { Email = email, Password = password };

            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);

                try
                {
                    var result = client.UploadString($"{ClientConstants.AppPath}Account/SignIn", JsonConvert.SerializeObject(model));
                    _token.AuthorizationHeader = ClientConstants.AuthorizationHeader + JsonConvert.DeserializeObject<string>(result);
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
    }
}
