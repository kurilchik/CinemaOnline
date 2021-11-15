using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.ConsoleClient.Authentication.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class FilmClient : IFilmClient
    {
        private IToken _token;

        public FilmClient(IToken token)
        {
            _token = token;
        }

        public void GetAllFilms()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);
                client.Headers.Add(_token.AuthorizationHeader);
                var result = client.DownloadString($"{ClientConstants.AppPath}Films");
                var films = JsonConvert.DeserializeObject<List<FilmDTO>>(result);
                foreach (var item in films)
                {
                    Console.WriteLine($"FilmId: {item.Id}{Environment.NewLine}Name: {item.Name}{Environment.NewLine}");
                }
                Console.ReadKey();
            }
        }

        public void GetFilmById()
        {
            Console.WriteLine("Please enter filmID:");
            var filmId = Console.ReadLine();
            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);
                client.Headers.Add(_token.AuthorizationHeader);
                var result = client.DownloadString($"{ClientConstants.AppPath}Films/{filmId}");
                var film = JsonConvert.DeserializeObject<FilmDTO>(result);
                Console.WriteLine($"FilmId: {film.Id}{Environment.NewLine}Name: {film.Name}{Environment.NewLine}Genres: {string.Join(", ", film.Genres)}{Environment.NewLine}");
                Console.ReadKey();
            }
        }
    }
}
