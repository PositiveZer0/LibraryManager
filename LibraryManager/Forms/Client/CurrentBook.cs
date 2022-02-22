namespace LibraryManager.Forms.Client
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
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class CurrentBook : Form
    {
        BookViewModel book;
        IBookService bookService;
        IDeletableEntityRepository<BorrowedBook> borrowedBooks;

        public CurrentBook(BookViewModel book)
        {
            InitializeComponent();
            this.book = book;
            this.borrowedBooks = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.bookService = new BookService(new LibraryManagerContext(), this.borrowedBooks);
        }

        private void CurrentBook_Load(object sender, EventArgs e)
        {
            title_label.Text = this.book.Title;
            author_label.Text = "by " + this.book.AuthorName;
            description_textBox.Text = this.book.Description;
            genre_label.Text = this.book.Genre;
            if (title_label.Text.Length <= 25)
            {
                author_label.Location = new Point(758, 100);
            }
        }

        private async void borrow_btn_Click(object sender, EventArgs e)
        {
            var bookId = this.bookService.GetBookIdByTitle(this.title_label.Text);
            try
            {
                await this.bookService.BorrowBook(bookId);
                MessageBox.Show("Book borrowed successfully. You can get your book from the library :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
