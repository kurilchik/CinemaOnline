using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;

namespace CinemaOnline.BLL.Services
{
    public class TopUpService : ITopUpService
    {
        private TicketDbContext _ticketDbContext;
        private ITopUpRepository _topUpRepository;

        public TopUpService(TicketDbContext ticketDbContext, ITopUpRepository topUpRepository)
        {
            _ticketDbContext = ticketDbContext;
            _topUpRepository = topUpRepository;
        }

        public float TopUpCard(string guid)
        {
            if (Guid.TryParse(guid, out Guid result))
            {
                var card = _topUpRepository.GetByGuid(result);
                if (card != null && !card.Used)
                {
                    CardUsed(card);
                    return card.Amount;
                }
                else
                    return 0;
            }
            
            else
                return 0;
        }

        private void CardUsed(TopUpCardModel topUpCardModel)
        {
            var card = topUpCardModel;
            card.Used = true;
            _topUpRepository.Update(card);
            _ticketDbContext.SaveChanges();
        }
    }
}
