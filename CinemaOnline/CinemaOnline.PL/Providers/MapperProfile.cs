using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;

namespace CinemaOnline.PL.Providers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserViewModel, UserModel>();
            CreateMap<UserModel, UserViewModel>();
            CreateMap<User, UserModel>();
            CreateMap<FilmModel, FilmViewModel>().ForMember(dest => dest.Sessions, opt => opt.Ignore());
            CreateMap<SessionModel, SessionViewModel>();
            CreateMap<Ticket, TicketModel>();
            CreateMap<TopUpCard, TopUpCardModel>();
        }
    }
}
