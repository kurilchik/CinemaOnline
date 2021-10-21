using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebApplication.PL.Models;

namespace CinemaOnline.WebApplication.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SessionViewModel, SessionFilmDTO>();

            CreateMap<FilmViewModel, FilmDTO>();

            CreateMap<UserViewModel, UserDTO>();

            CreateMap<UserTicketViewModel, UserTicketDTO>();
        }
    }
}
