namespace LibraryManager.Database.Models
{
    using System.Collections.Generic;

    using LibraryManager.Database.Repositories.Models;

    public class Book : BaseDeletableModel<int>
    {
        public Book()
        {
            this.BorrowedBooks = new HashSet<BorrowedBook>();
        }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public int Quantity { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public ICollection<BorrowedBook> BorrowedBooks { get; set; }

        public int? BookImageId { get; set; }

        public BookImage BookImage { get; set; }
    }
}
