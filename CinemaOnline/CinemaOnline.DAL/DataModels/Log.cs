using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaOnline.DAL.DataModels
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Changes { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
