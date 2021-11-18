namespace CinemaOnline.WebAPI.ConsoleClient.Clients.Interfaces
{
    public interface IAccountClient
    {
        void SignIn();
        void SignUp();
        void GetUser(string email);
        void BuyTicket(int sessionId, float price);
        void TopUpBalance(float amount);
    }
}
