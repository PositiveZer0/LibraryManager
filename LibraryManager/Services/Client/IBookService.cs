namespace LibraryManager.Services.Client
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using LibraryManager.ViewModels;

    public interface IBookService
    {
        Task AddBookAsync(BookViewModel book);

        Task BorrowBook(int bookId);

        List<BookViewModel> GetAllBooks();

        List<BookViewModel> GetAllAvailableBooks();

        List<BorrowedBookViewModel> GetAllBorrowedBooks();

        List<BookViewModel> SearchBooks(string word);

        public Task SendEmailBorrowedBooks();

        int GetBookIdByTitle(string title);
    }
}
