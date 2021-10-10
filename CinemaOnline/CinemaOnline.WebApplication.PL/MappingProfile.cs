using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, UserModel>();
            CreateMap<UserModel, UserViewModel>();
            CreateMap<User, UserModel>();
            CreateMap<FilmModel, FilmViewModel>().ForMember(dest => dest.Sessions, opt => opt.Ignore());
            CreateMap<SessionModel, SessionViewModel>();
            CreateMap<Ticket, TicketModel>();
            CreateMap<UserTicketModel, UserTicketViewModel>();
            CreateMap<TopUpCard, TopUpCardModel>();
        }
    }
}
