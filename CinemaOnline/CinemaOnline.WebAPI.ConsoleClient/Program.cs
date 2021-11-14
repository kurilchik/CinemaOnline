using CinemaOnline.WebAPI.ConsoleClient.Clients;
using System;

namespace CinemaOnline.WebAPI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountClient client = new AccountClient();
            client.SignIn();
        }
    }
}
