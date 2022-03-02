namespace LibraryManager.Services.Login
{
    using System.Linq;
    using System.Threading.Tasks;

    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Login.ValidationCreateAccount;
    public class ChangePasswordService : IChangePasswordService
    {
        private readonly IDeletableEntityRepository<User> user;

        public ChangePasswordService(IDeletableEntityRepository<User> user)
        {
            this.user = user;
        }

        public async Task Change(string email, string passsword)
        {
            var account = this.user.All().Where(x => x.Email == email).FirstOrDefault();
            account.Password = SecurePasswordHasher.Hash(passsword);
            await this.user.SaveChangesAsync();
        }

        public string GetCurrentUserPassword(string email)
        {
            var password = this.user.All().FirstOrDefault(x => x.Email == email).Password;
            return password;
        }
    }
}
