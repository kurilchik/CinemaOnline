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

        public SessionRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
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
