﻿using CinemaOnline.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services.Interfaces
{
    public interface IFilmService
    {
        List<FilmViewModel> GetAllFilms();
        FilmViewModel GetSessions(FilmViewModel film);


    }
}
