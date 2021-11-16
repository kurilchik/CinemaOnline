using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.ModelsDTO.Models;

namespace CinemaOnline.WebAPI.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FilmViewModel, FilmDTO>();

            CreateMap<FilmViewModel, FilmSessionDTO>();

            CreateMap<SessionViewModel, SessionDTO>();

            CreateMap<UserViewModel, UserDTO>();

            CreateMap<UpdateUserDTO, UserViewModel>();
        }
    }
}
