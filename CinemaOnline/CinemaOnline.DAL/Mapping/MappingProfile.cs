using AutoMapper;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;

namespace CinemaOnline.DAL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>();

            CreateMap<Session, SessionModel>();

            CreateMap<Ticket, TicketModel>();

            CreateMap<TopUpCard, TopUpCardModel>();
        }
    }
}
