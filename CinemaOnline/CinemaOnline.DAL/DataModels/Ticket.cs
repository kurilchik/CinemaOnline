using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaOnline.DAL.DataModels
{
    public partial class Ticket
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int SessionId { get; set; }

        public virtual Session Session { get; set; }
        public virtual User User { get; set; }
    }
}
