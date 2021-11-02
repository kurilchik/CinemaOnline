using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using System.Collections.Generic;

namespace CinemaOnline.PL.Providers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserViewModel, UserModel>();
            CreateMap<UserModel, UserViewModel>().ForMember(dest => dest.Tickets, opt => opt.Ignore());
            CreateMap<User, UserModel>();
            CreateMap<FilmModel, FilmViewModel>().ForMember(dest => dest.Sessions, opt => opt.Ignore());
            CreateMap<Session, SessionModel>().ForMember(dest => dest.Time, opt => opt.MapFrom(src => src.SessionTime));
            CreateMap<SessionModel, SessionViewModel>();
            CreateMap<Ticket, TicketModel>();
            CreateMap<TopUpCard, TopUpCardModel>();
            CreateMap<UserTicketModel, UserTicketViewModel>();
        }
    }
}
