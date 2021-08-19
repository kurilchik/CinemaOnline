using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaOnline.DAL.DataModels
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Balance { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
