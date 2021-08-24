using CinemaOnline.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.BLL.Services.Interfaces
{
    public interface ITopUpService
    {
        float TopUpCard(string guid);
    }
}
