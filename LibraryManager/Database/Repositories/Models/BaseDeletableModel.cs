namespace LibraryManager.Database.Repositories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
