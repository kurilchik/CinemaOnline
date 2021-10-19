using AutoMapper;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaOnline.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, UserModel>();
            CreateMap<UserModel, UserViewModel>();
            CreateMap<FilmModel, FilmViewModel>().ForMember(dest => dest.Sessions, opt => opt.Ignore());
            CreateMap<SessionModel, SessionViewModel>();
            CreateMap<UserTicketModel, UserTicketViewModel>();

            CreateMap<User, UserModel>();
            CreateMap<Session, SessionModel>();
            CreateMap<Ticket, TicketModel>();
            CreateMap<TopUpCard, TopUpCardModel>();
        }
    }
}
