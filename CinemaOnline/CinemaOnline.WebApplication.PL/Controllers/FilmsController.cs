﻿using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebApplication.PL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmService _filmService;

        public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }

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
    }
}
