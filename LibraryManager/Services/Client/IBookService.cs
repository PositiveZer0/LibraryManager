namespace LibraryManager.Services.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LibraryManager.ViewModels;

    public interface IBookService
    {
        void AddBook(BookViewModel book);

        Task BorrowBook(int bookId);

        List<BookViewModel> GetAllBooks();

        List<BookViewModel> GetAllAvailableBooks();


        List<BorrowedBookViewModel> GetAllBorrowedBooks();

        List<BookViewModel> SearchBooks(string word);

        public Task SendEmailBorrowedBooks();

    }
}
