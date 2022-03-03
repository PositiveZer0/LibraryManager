namespace LibraryManager.Database.Models
{
    using LibraryManager.Database.Repositories.Models;

    public class UserImage : BaseDeletableModel<int>
    {
        public byte[] Image { get; set; }
    }
}
