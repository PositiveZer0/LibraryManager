namespace LibraryManager.Database.Repositories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
