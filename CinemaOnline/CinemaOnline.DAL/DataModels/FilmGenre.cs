using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaOnline.DAL.DataModels
{
    public partial class FilmGenre
    {
        public int FilmId { get; set; }
        public int GenreId { get; set; }

        public virtual Film Film { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
