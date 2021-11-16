namespace CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces
{
    public interface IAccountClient
    {
        void SignIn();
        void SignUp();
        void GetUser(string email);
        void TopUpBalance(float amount);
    }
}
