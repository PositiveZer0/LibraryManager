namespace LibraryManager.Services.Login
{
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Login.ValidationCreateAccount;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
    }
}
