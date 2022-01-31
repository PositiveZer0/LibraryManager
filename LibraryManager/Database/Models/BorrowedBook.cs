namespace LibraryManager.Database.Models
{
    using LibraryManager.Database.Repositories.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BorrowedBook : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public bool SendWarning { get; set; }
    }
}
