using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Models;
using CinemaOnline.DAL.Repositories;
using CinemaOnline.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services
{
    public class FilmService : IFilmService
    {
        private TicketDbContext _ticketDbContext;
        private IFilmRepository _filmRepository;

        public FilmService()
        {
            _ticketDbContext = new TicketDbContext();
            _filmRepository = new FilmRepository(_ticketDbContext);
        }

        public List<FilmViewModel> GetAllFilms()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<FilmModel, FilmViewModel>());
            var mapper = new Mapper(config);
            var films = mapper.Map<List<FilmViewModel>>(_filmRepository.GetAllFilms());

            return films;
        }
    }
}
