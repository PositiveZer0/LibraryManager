namespace LibraryManager.Services.Login
{
    using System.Threading.Tasks;

    public interface IChangePasswordService
    {
        Task Change(string email, string passsword);

        string GetCurrentUserPassword(string email);
    }
}
