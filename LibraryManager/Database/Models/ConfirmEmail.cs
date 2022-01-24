namespace LibraryManager.Database.Models
{
    using LibraryManager.Database.Repositories.Models;

    public class ConfirmEmail : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string ConfirmationCode { get; set; }
    }
}
