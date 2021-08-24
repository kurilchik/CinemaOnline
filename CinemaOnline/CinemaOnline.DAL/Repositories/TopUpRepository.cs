using AutoMapper;
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
    public class TopUpRepository : ITopUpRepository
    {
        private TicketDbContext _ticketDbContext;

        public TopUpRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
        }

        public TopUpCardModel GetByGuid(Guid guid)
        {
            var card = _ticketDbContext.TopUpCards.FirstOrDefault(c => c.Card == guid);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TopUpCard, TopUpCardModel>());
            var mapper = new Mapper(config);
            var topUpCardModel = mapper.Map<TopUpCard, TopUpCardModel>(card);

            return topUpCardModel;
        }

        public void Update(TopUpCardModel topUpCardModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TopUpCardModel, TopUpCard>());
            var mapper = new Mapper(config);
            var topUpCard = mapper.Map<TopUpCardModel, TopUpCard>(topUpCardModel);

            _ticketDbContext.TopUpCards.Update(topUpCard);
        }
    }
}
