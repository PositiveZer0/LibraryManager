namespace LibraryManager.Services.Client
{
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBookService
    {
        void AddBook(BookViewModel book);

        Task BorrowBook(int bookId);

        List<BookViewModel> GetAllBooks();

        List<BookViewModel> GetAllAvailableBooks();


        List<BorrowedBookViewModel> GetAllBorrowedBooks();

    }
}
