namespace LibraryManager.Services.Client
{
    using AutoMapper.QueryableExtensions;
    using LibraryManager.Automapper;
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.SendGrid;
    using LibraryManager.ViewModels;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookService : IBookService
    {
        private LibraryManagerContext db;
        private readonly IDeletableEntityRepository<BorrowedBook> borrowedBooks;

        public BookService(LibraryManagerContext db,
            IDeletableEntityRepository<BorrowedBook> borrowedBooks)
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
            var books = this.db.Books.To<BookViewModel>().ToList();

            return books;
        }

        public List<BorrowedBookViewModel> GetAllBorrowedBooks()
        {
            var borrowedBooks = this.db.Users.Where(x => x.IsLoggedIn == true)
                .Select(x => x.BorrowedBooks.Select(x => new BorrowedBookViewModel
                {
                    AuthorName = x.Book.AuthorName,
                    Description = x.Book.Description,
                    Genre = x.Book.Genre,
                    Quantity = x.Book.Quantity,
                    Title = x.Book.Title,
                    From = x.From.Date,
                    To = x.To.Date,
                })).FirstOrDefault();

            return borrowedBooks.ToList();
        }
        public List<BookViewModel> GetAllAvailableBooks()
        {
            var availableBooks = this.db.Books.Where(x => x.Quantity > 0).To<BookViewModel>();

            return availableBooks.ToList();
        }

        public List<BookViewModel> SearchBooks(string word)
        {
            //todo: is it better to reuse default method?
            var searchedBooks = this.db.Books.Where(x => x.Title.Contains(word)).To<BookViewModel>();

            return searchedBooks.ToList();
        }

        public async Task SendEmailBorrowedBooks()
        {
            var emailsToSend = this.db.BorrowedBooks
                .Where(x => x.SendWarning == false && x.To.Date <= DateTime.Now.AddDays(7))
                .Include(x => x.Book)
                .Include(x => x.User);

            var sendGrid = new SendGridEmailSender(ConfigurationConstants.SENDGRID_APIKEY);
            foreach (var email in emailsToSend)
            {
               email.SendWarning = true;
                //sender, sender name, receiver
                await sendGrid.SendEmailAsync("azsumemi@gmail.com",
                    "Library Manager",
                    $"{email.User.Email}",
                    "Return book reminder",
                    $"We just want to remind you that you have to return the book {email.Book.Title} by {email.Book.AuthorName} " +
                    $"till {email.To.ToString("dd/MM/yyyy")}.");
            }
            await this.db.SaveChangesAsync();
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
