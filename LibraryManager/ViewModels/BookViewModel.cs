namespace LibraryManager.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BookViewModel
    {
        public string Title { get; set; }

        public string AuthorName { get; set; }

        public int Quantity { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }
    }
}
