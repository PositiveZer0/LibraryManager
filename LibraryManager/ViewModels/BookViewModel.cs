namespace LibraryManager.ViewModels
{
    using LibraryManager.Automapper;
    using LibraryManager.Database.Models;

    public class BookViewModel : IMapFrom<Book>
    {
        public string Title { get; set; }

        public string AuthorName { get; set; }

        public int Quantity { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }
    }
}
