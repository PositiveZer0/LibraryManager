namespace LibraryManager.Database.Repositories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
