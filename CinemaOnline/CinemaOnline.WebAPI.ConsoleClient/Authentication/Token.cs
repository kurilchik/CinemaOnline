using CinemaOnline.WebAPI.ConsoleClient.Authentication.Interfaces;
using CinemaOnline.WebAPI.ConsoleClient.Constants;

namespace CinemaOnline.WebAPI.ConsoleClient.Authentication
{
    public class Token : IToken
    {
        public string AuthorizationHeader { get; set; }
        public Token()
        {
            AuthorizationHeader = ClientConstants.AuthorizationHeader;
        }
    }
}
