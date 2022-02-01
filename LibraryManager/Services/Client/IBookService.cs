namespace LibraryManager.Services.Client
{
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IBookService
    {
        void AddBook(BookViewModel book);

        void BorrowBook(string userId, int bookId);

    }
}
