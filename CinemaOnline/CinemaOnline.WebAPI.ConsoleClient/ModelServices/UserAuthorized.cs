using CinemaOnline.ModelsDTO.Models;
using CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces;

namespace CinemaOnline.WebAPI.ConsoleClient.ModelServices
{
    public class UserAuthorized : IUserAuthorized
    {
        public UserDTO User { get; set; }

        public UserAuthorized()
        {
            User = new UserDTO();
        }
    }
}
