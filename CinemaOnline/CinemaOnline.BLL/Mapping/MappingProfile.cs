using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.Models;

namespace CinemaOnline.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserModel, UserViewModel>();
            CreateMap<UserViewModel, UserModel>();

            CreateMap<FilmModel, FilmViewModel>();

            CreateMap<SessionModel, SessionViewModel>();

            CreateMap<UserTicketModel, UserTicketViewModel>();
        }
    }
}
