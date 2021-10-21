using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebApplication.PL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Controllers
{
    [Authorize]
    public class FilmsController : Controller
    {
        private IFilmService _filmService;
        private IUserService _userService;
        private ITicketService _ticketService;
        private IMapper _mapper;

        public FilmsController(IFilmService filmService, IUserService userService, ITicketService ticketService, IMapper mapper)
        {
            _filmService = filmService;
            _userService = userService;
            _ticketService = ticketService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var films = _mapper.Map<List<FilmDTO>>(_filmService.GetAllFilms());

            var filmsView = new FilmsViewModel() { Films = new List<FilmDTO>() };

            foreach (var item in films)
            {
                filmsView.Films.Add(item);
            }

            return View(filmsView);
        }
    
        public IActionResult Film([FromQuery] int id)
        {
            var film = _filmService.GetFilmById(id);
            film = _filmService.GetSessions(film);
            var filmDTO = _mapper.Map<FilmDTO>(film);
            return View(filmDTO);
        }

        public IActionResult Payment([FromForm] SessionDTO session)
        {
            return View(session);
        }

        public IActionResult Buy([FromForm] TicketDTO ticket)
        {
            var user = _userService.GetByEmail(User.Claims.FirstOrDefault(t => t.Type == ClaimTypes.Email).Value);
            if (user.Balance >= ticket.Price)
            {
                user.Balance -= ticket.Price;
                _userService.Update(user);
                _ticketService.Add(user.Id, ticket.SessionId);
            }             
            return RedirectToAction("Index", "Films");
        }
    }
}
