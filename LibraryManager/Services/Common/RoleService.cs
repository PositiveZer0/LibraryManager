namespace LibraryManager.Services.Common
{
    using System.Linq;
    using LibraryManager.Automapper;

    using LibraryManager.ViewModels;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;

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
