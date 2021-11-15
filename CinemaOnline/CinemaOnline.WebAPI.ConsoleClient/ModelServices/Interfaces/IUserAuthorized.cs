using CinemaOnline.ModelsDTO.Models;

namespace CinemaOnline.WebAPI.ConsoleClient.ModelServices.Interfaces
{
    public interface IUserAuthorized
    {
        UserDTO User { get; set; }
    }
}
