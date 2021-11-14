using CinemaOnline.ModelsDTO.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class AccountClient
    {
        private string _token = string.Empty;

        public void SignIn()
        {
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            var password = Console.ReadLine();
            var model = new SignInModelDTO { Email = email, Password = password };

            using (var client = new WebClient())
            {
                client.Headers.Add(Constants.ContentTypeHeader);
                client.Headers.Add(Constants.AcceptHeader);
                try
                {
                    var result = client.UploadString($"{Constants.AppPath}Account/SignIn", JsonConvert.SerializeObject(model));
                    _token = $"Authorization:Bearer {JsonConvert.DeserializeObject<string>(result)}";
                }
                catch (WebException ex)
                {
                    var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                    Console.WriteLine(resp);
                    SignIn();
                }              
                
            }
        }
    }
}
