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
            var films = (from film in _ticketDbContext.Films
                        join filmGenre in _ticketDbContext.FilmGenres on film.Id equals filmGenre.FilmId
                        join genre in _ticketDbContext.Genres on filmGenre.GenreId equals genre.Id
                        select new FilmModel
                        {
                            Name = film.Name,
                            Description = film.Description,
                            ImgUrl = film.ImgUrl,

                        }).ToList();

            return films;
        }
    }
}
