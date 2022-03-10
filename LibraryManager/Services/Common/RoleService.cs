namespace LibraryManager.Services.Common
{
    using LibraryManager.Automapper;
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RoleService : IRoleService
    {
        private IDeletableEntityRepository<User> user;

        public RoleService(IDeletableEntityRepository<User> user)
        {
            this.user = user;
        }
        public UserViewModel GetCurrentUser()
        {
            return this.user.All().Where(x => x.IsLoggedIn == true).To<UserViewModel>().FirstOrDefault();
        }
    }
}
