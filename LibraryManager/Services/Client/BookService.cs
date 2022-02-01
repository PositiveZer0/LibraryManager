namespace LibraryManager.Services.Client
{
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BookService : IBookService
    {
        public BookService()
        {

        }

        public void AddBook(BookViewModel book)
        {
            throw new NotImplementedException();
        }

        public void BorrowBook(string userId, int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
