using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaOnline.DAL.DataModels
{
    public partial class Session
    {
        public Session()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public int CinemaId { get; set; }
        public int FilmId { get; set; }
        public float Price { get; set; }
        public DateTime? SessionTime { get; set; }

        public virtual Cinema Cinema { get; set; }
        public virtual Film Film { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
