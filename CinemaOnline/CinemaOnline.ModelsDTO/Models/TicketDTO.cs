using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaOnline.ModelsDTO.Models
{
    public class TicketDTO
    {
        public string Email { get; set; }
        public int SessionId { get; set; }
        public float Price { get; set; }
    }
}
