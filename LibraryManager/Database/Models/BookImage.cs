namespace LibraryManager.Database.Models
{
    using LibraryManager.Database.Repositories.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BookImage : BaseDeletableModel<int>
    {
        public byte[] Image { get; set; }
    }
}
