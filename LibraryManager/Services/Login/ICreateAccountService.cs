namespace LibraryManager.Services.Login
{
    using System.Threading.Tasks;

    public interface ICreateAccountService
    {
        Task CreateAccount(string name, 
            string surname, 
            string email, 
            string password, 
            string role);

        string ValidateAccount(string name,
            string surname,
            string email,
            string password,
            string confirmPassword);
    }
}
