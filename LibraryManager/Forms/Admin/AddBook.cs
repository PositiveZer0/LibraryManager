namespace LibraryManager.Forms.Admin
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Client;
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class AddBook : Form
    {
        IBookService bookService;
        LibraryManagerContext db;
        IDeletableEntityRepository<BorrowedBook> borrowedBooks;

        public AddBook()
        {
            InitializeComponent();
            this.db = new LibraryManagerContext();
            this.borrowedBooks = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.bookService = new BookService(this.db, this.borrowedBooks);
        }

        private async void addBook_btn_Click(object sender, EventArgs e)
        {
            var title = title_textBox.Text;
            var authorName = authorName_textBox.Text;
            var genre = genre_textBox.Text;
            var description = description_textBox.Text;
            var book = new BookViewModel()
            {
                Title = title,
                Description = description,
                AuthorName = authorName,
                Genre = genre,
            };
            await this.bookService.AddBookAsync(book);
        }
    }
}
