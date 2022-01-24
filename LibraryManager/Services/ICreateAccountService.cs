namespace LibraryManager.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICreateAccountService
    {
        Task CreateAccount(string name, 
            string surname, 
            string email, 
            string password, 
            string role,
            bool verifyEmail);

        string ValidateAccount(string name,
            string surname,
            string email,
            string password,
            string confirmPassword);
    }
}
