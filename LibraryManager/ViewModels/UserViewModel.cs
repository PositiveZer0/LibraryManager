namespace LibraryManager.ViewModels
{
    using LibraryManager.Automapper;

    using LibraryManager.Database.Models;

    public class UserViewModel : IMapFrom<User>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
    }
}
