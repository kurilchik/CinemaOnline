using CinemaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaOnline.DAL.Repositories.Interfaces
{
    public interface ITopUpRepository
    {
        TopUpCardModel GetByGuid(Guid guid);
        void Update(TopUpCardModel topUpCard);
    }
}
