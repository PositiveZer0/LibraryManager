﻿namespace LibraryManager.Services.Client
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookService : IBookService
    {
        private LibraryManagerContext db;
        private readonly IDeletableEntityRepository<BorrowedBook> borrowedBooks;

        public BookService(LibraryManagerContext db, IDeletableEntityRepository<BorrowedBook> borrowedBooks)
        {
            this.db = db;
            this.borrowedBooks = borrowedBooks;
        }

        public void AddBook(BookViewModel book)
        {
            throw new NotImplementedException();
        }

        public async Task BorrowBook(int bookId)
        {
            if (!IsBookIdReal(bookId))
            {
                //todo: throw error 
                return;
            }

            if (!CheckIfBookIsAvailable(bookId))
            {
                //todo: need to throw excp cant borrow book
                //make method string 
                return;
            }
            ReduceQuantity(bookId);
            var user = this.db.Users.FirstOrDefault(x => x.IsLoggedIn == true);
            var borrowedBook = new BorrowedBook
            {
                UserId = user.Id,
                BookId = bookId,
                From = DateTime.UtcNow,
                To = DateTime.UtcNow.AddDays(30)
            };

            await this.borrowedBooks.AddAsync(borrowedBook);
            await this.borrowedBooks.SaveChangesAsync();
        }

        public List<BookViewModel> GetAllBooks()
        {
            var books = this.db.Books.Select(x => new BookViewModel
            {
                AuthorName = x.AuthorName,
                Description = x.Description,
                Genre = x.Genre,
                Quantity = x.Quantity,
                Title = x.Title,
            }).ToList();

            return books;
        }

        public List<BookViewModel> GetAllBorrowedBooks()
        {
            var borrowedBooks = this.db.Users.Where(x => x.IsLoggedIn == true).Select(x => x.BorrowedBooks.Select(x => new BookViewModel
            {
                AuthorName = x.Book.AuthorName,
                Description = x.Book.Description,
                Genre = x.Book.Genre,
                Quantity = x.Book.Quantity,
                Title = x.Book.Title,
            })).FirstOrDefault();

            return borrowedBooks.ToList();
        }
        public List<BookViewModel> GetAllAvailableBooks()
        {
            var availableBooks = this.db.Books.Where(x => x.Quantity > 0).Select(x => new BookViewModel
            {
                AuthorName = x.AuthorName,
                Description = x.Description,
                Genre = x.Genre,
                Quantity = x.Quantity,
                Title = x.Title,
            });

            return availableBooks.ToList();
        }

        private bool IsBookIdReal(int bookId)
        {
            var book = this.db.Books.FirstOrDefault(x => x.Id == bookId);
            return book != null;
        }

        private bool CheckIfBookIsAvailable(int bookId)
        {
            var book = this.db.Books.FirstOrDefault(x => x.Id == bookId);
            return book.Quantity > 0;
        }

        private void ReduceQuantity(int bookId)
        {
            var book = this.db.Books.FirstOrDefault(x => x.Id == bookId);
            book.Quantity--;
            this.db.SaveChanges();
        }

    }
}
