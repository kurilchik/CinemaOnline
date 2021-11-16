using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.ConsoleClient.Authentication.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Constants;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace CinemaOnline.WebAPI.ConsoleClient.Clients
{
    public class FilmClient : IFilmClient
    {
        private IFilmSelected _film;
        private IToken _token;

        public FilmClient(IFilmSelected film, IToken token)
        {
            _film = film;
            _token = token;
        }

        public void GetAllFilms()
        {
            Console.Clear();

            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);
                client.Headers.Add(_token.AuthorizationHeader);
                var result = client.DownloadString($"{ClientConstants.AppPath}Films");
                var films = JsonConvert.DeserializeObject<List<FilmDTO>>(result);
                foreach (var item in films)
                {
                    Console.WriteLine($"{item.Id}. - {item.Name}{Environment.NewLine}");
                }                
            }
        }

        public void GetFilmById(int filmId)
        {
            Console.Clear();
            using (var client = new WebClient())
            {
                client.Headers.Add(ClientConstants.ContentTypeHeader);
                client.Headers.Add(ClientConstants.AcceptHeader);
                client.Headers.Add(_token.AuthorizationHeader);
                var result = client.DownloadString($"{ClientConstants.AppPath}Films/{filmId}");
                var film = JsonConvert.DeserializeObject<FilmSessionDTO>(result);

                _film.Film = film;

                Console.WriteLine($"Name: {film.Name}{Environment.NewLine}Genres: {string.Join(", ", film.Genres)}{Environment.NewLine}Description: {film.Description}{Environment.NewLine}");
            }
        }
    }
}
