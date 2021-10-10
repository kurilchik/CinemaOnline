using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebApplication.PL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Controllers
{
    [Authorize]
    public class FilmsController : Controller
    {
        private IFilmService _filmService;

        public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var films =_filmService.GetAllFilms();

            var filmsView = new FilmsViewModel() { Films = new List<FilmViewModel>() };

            foreach (var item in films)
            {
                filmsView.Films.Add(item);
            }

            return View(filmsView);
        }

        [AllowAnonymous]        
        public IActionResult Film([FromQuery] int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var film = _filmService.GetFilmById(id);
                film = _filmService.GetSessions(film);
                return View(film);
            }
            return RedirectToAction("Login", "Account");
        }
    }
}
