using AutoMapper;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CinemaOnline.DAL.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private TicketDbContext _ticketDbContext;
        private IMapper _mapper;

        public SessionRepository(TicketDbContext ticketDbContext, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _mapper = mapper;
        }

        public SessionModel GetById(int id)
        {
            var session = _ticketDbContext.Sessions.FirstOrDefault(s => s.Id == id);
            var sessionModel = _mapper.Map<SessionModel>(session);

            return sessionModel;
        }

        public List<SessionModel> GetListSessionsByFilmId(int filmId)
        {
            var sessions = (from session in _ticketDbContext.Sessions
                          join cinema in _ticketDbContext.Cinemas on session.CinemaId equals cinema.Id
                          select new SessionModel
                          {
                              Id = session.Id,
                              CinemaName = cinema.Name,
                              FilmId = session.FilmId,
                              Price = session.Price,
                              Time = session.SessionTime.GetValueOrDefault()
                          }).Where(s => s.FilmId == filmId).ToList();

            return sessions;
        }
    }
}
