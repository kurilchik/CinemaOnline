﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services.Interfaces
{
    public interface ITicketService
    {
        void Add(int userId, int sessionId);
        int CountUserTickets(int userId);
    }
}
