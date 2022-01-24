namespace LibraryManager.Database.Models
{
    using System;

    using LibraryManager.Database.Repositories.Models;

    public class User : BaseDeletableModel<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public bool IsEmailVerified { get; set; }
    }
}
