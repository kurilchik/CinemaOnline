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

            CreateMap<UserViewModel, UserDTO>();

            CreateMap<AddUserDTO, UserViewModel>();

            CreateMap<UpdateUserDTO, UserViewModel>();
        }
    }
}
