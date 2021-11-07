using CinemaOnline.ModelsDTO.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CinemaOnline.WebAPI.ConsoleClient
{
    public class Film
    {
        public void GetAllFilms()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add(Constants.ContentTypeHeader); 
                client.Headers.Add(Constants.AcceptHeader);
                var result = client.DownloadString($"{Constants.AppPath}Films");
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
                client.Headers.Add(Constants.ContentTypeHeader); 
                client.Headers.Add(Constants.AcceptHeader);
                var result = client.DownloadString($"{Constants.AppPath}Films/{filmId}");
                var film = JsonConvert.DeserializeObject<FilmDTO>(result);
                Console.WriteLine($"FilmId: {film.Id}{Environment.NewLine}Name: {film.Name}{Environment.NewLine}Genres: {string.Join(", ", film.Genres)}{Environment.NewLine}");
                Console.ReadKey();
            }
        }
    }
}
