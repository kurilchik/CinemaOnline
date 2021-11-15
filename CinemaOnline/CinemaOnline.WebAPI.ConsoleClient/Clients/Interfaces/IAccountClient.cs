namespace CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces
{
    public interface IAccountClient
    {
        void SignIn();
        void SignUp();
        void TopUpBalance(float amount);
    }
}
