using AutoMapper;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;
using System.Linq;

namespace CinemaOnline.DAL.Repositories
{
    public class TopUpRepository : ITopUpRepository
    {
        private TicketDbContext _ticketDbContext;
        private IMapper _mapper;

        public TopUpRepository(TicketDbContext ticketDbContext, IMapper mapper)
        {
            _ticketDbContext = ticketDbContext;
            _mapper = mapper;
        }

        public TopUpCardModel GetByGuid(Guid guid)
        {
            var card = _ticketDbContext.TopUpCards.FirstOrDefault(c => c.Card == guid);
            var topUpCardModel = _mapper.Map<TopUpCardModel>(card);

            return topUpCardModel;
        }

        public void Update(TopUpCardModel topUpCardModel)
        {
            var card = _ticketDbContext.TopUpCards.FirstOrDefault(c => c.Card == topUpCardModel.Card);
            card.Used = topUpCardModel.Used;
        }
    }
}
