using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CinemaOnline.WebAPI.PL.Authentication
{
    public class AuthOptions
    {
        public const string ISSUER = "CinemaOnline";
        public const string AUDIENCE = "CinemaOnlineClient";
        const string KEY = "cinema_online!12345";
        public const int LIFETIME = 30;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
