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
            title_textBox.Text = this.book.Title;
            textBox2.Text = this.book.AuthorName;
            textBox3.Text = this.book.Quantity.ToString();
            textBox4.Text = this.book.Description;
            textBox5.Text = this.book.Genre;
        }

        private async void borrow_btn_Click(object sender, EventArgs e)
        {
            var bookId = this.bookService.GetBookIdByTitle(this.title_textBox.Text);
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
