using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaOnline.BLL.ViewModels
{
    public class UserTicketViewModel
    {
        public string FilmName { get; set; }

        public string CinemaName { get; set; }

        public float Price { get; set; }

        public DateTime Time { get; set; }
    }
}
