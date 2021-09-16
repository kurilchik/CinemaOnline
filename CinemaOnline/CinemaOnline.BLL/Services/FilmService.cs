using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace CinemaOnline.BLL.Services
{
    public class FilmService : IFilmService
    {
        private TicketDbContext _ticketDbContext;
        private IFilmRepository _filmRepository;
        private ISessionRepository _sessionRepository;
        private IMapper _mapper;

        public FilmService(TicketDbContext ticketDbContext, IFilmRepository filmRepository, ISessionRepository sessionRepository, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _filmRepository = filmRepository;
            _sessionRepository = sessionRepository;
            _mapper = mapper;
        }

        public List<FilmViewModel> GetAllFilms()
        {
            var films = _mapper.Map<List<FilmViewModel>>(_filmRepository.GetAllFilms());
            return films;
        }
        public FilmViewModel GetSessions(FilmViewModel film)
        {
            film.Sessions = GetSessionByFilmId(film.Id);
            return film;
        }

        private List<SessionViewModel> GetSessionByFilmId(int filmId)
        {
            var sessions = _mapper.Map<List<SessionViewModel>>(_sessionRepository.GetListSessionsByFilmId(filmId));
            return sessions;
        }
    }
}
