using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services
{
    public class FilmService : IFilmService
    {
        private TicketDbContext _ticketDbContext;
        private IFilmRepository _filmRepository;
        private ISessionRepository _sessionRepository;

        public FilmService()
        {
            _ticketDbContext = new TicketDbContext();
            _filmRepository = new FilmRepository(_ticketDbContext);
            _sessionRepository = new SessionRepository(_ticketDbContext);
        }

        public List<FilmViewModel> GetAllFilms()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<FilmModel, FilmViewModel>());
            var mapper = new Mapper(config);
            var films = mapper.Map<List<FilmViewModel>>(_filmRepository.GetAllFilms());

            return films;
        }
        public FilmViewModel GetSessions(FilmViewModel film)
        {
            film.Sessions = GetSessionByFilmId(film.Id);
            return film;
        }

        private List<SessionViewModel> GetSessionByFilmId(int filmId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SessionModel, SessionViewModel>());
            var mapper = new Mapper(config);
            var sessions = mapper.Map<List<SessionViewModel>>(_sessionRepository.GetListSessionsByFilmId(filmId));

            return sessions;
        }
    }
}
