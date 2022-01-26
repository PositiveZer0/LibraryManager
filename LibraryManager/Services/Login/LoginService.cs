namespace LibraryManager.Services.Login
{
    using System.Linq;

    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Login.ValidationCreateAccount;

    public class LoginService : ILoginService
    {
        private readonly IDeletableEntityRepository<User> user;

        public LoginService(IDeletableEntityRepository<User> user)
        {
            this.user = user;
        }

        public string Login(string email, string password)
        {
            var account = this.user.All().Where(x => x.Email == email)
                .Select(x => new
                {
                    x.Email,
                    x.Password,
                }).FirstOrDefault();

            if (account == null || !SecurePasswordHasher.Verify(password, account.Password))
            {
                return "Email or password is incorrect";
            }

            return string.Empty;
        }

    }
}
