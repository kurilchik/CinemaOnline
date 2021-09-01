using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace CinemaOnline.BLL.Services
{
    public class FilmService : IFilmService
    {
        private TicketDbContext _ticketDbContext;
        private IFilmRepository _filmRepository;
        private ISessionRepository _sessionRepository;

        public FilmService(TicketDbContext ticketDbContext, IFilmRepository filmRepository, ISessionRepository sessionRepository)
        {
            _ticketDbContext = ticketDbContext;
            _filmRepository = filmRepository;
            _sessionRepository = sessionRepository;
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
