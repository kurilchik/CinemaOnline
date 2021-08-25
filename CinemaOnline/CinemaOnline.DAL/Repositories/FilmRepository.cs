using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private TicketDbContext _ticketDbContext;

        public FilmRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
        }

        public List<FilmModel> GetAllFilms()
        {
            var groups = (from filmGenre in _ticketDbContext.FilmGenres
                         join genre in _ticketDbContext.Genres on filmGenre.GenreId equals genre.Id
                         join film in _ticketDbContext.Films on filmGenre.FilmId equals film.Id
                         select new
                         {
                             Id = film.Id,
                             Film = film.Name,
                             Description = film.Description,
                             ImgUrl = film.ImgUrl,
                             Genre = genre.Name
                         }).ToList();

            var films = groups.GroupBy(f => f.Film).Select(x => new FilmModel()
            {
                Name = x.Key,
                Id = x.First().Id,
                Description = x.First().Description,
                ImgUrl = x.First().ImgUrl,
                Genres = x.Select(g => g.Genre).ToList()
            }).ToList();

            return films;
        }
    }
}
