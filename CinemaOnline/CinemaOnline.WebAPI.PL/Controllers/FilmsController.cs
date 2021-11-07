using AutoMapper;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.ModelsDTO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CinemaOnline.WebAPI.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IFilmService _filmService;

        public FilmsController(IFilmService filmService, IMapper mapper)
        {
            _filmService = filmService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFilms()
        {
            var films = _filmService.GetAllFilms();
            var models = _mapper.Map<List<FilmDTO>>(films);
            return Ok(models);
        }

        [HttpGet("{id}")]
        public IActionResult GetFilms(int id)
        {
            var film = _filmService.GetFilmById(id);
            var model = _mapper.Map<FilmDTO>(film);
            return Ok(model);
        }
    }
}
