using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaOnline.DAL.DataModels
{
    public partial class TopUpCard
    {
        public int Id { get; set; }
        public Guid Card { get; set; }
        public float Amount { get; set; }
        public bool Used { get; set; }
    }
}
