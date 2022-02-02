namespace LibraryManager.Services.Login
{
    using System.Threading.Tasks;

    public interface ILoginService
    {
        string Login(string email, string password);
    }
}
