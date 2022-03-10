namespace LibraryManager.Forms.Client
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Forms.Admin;
    using LibraryManager.Services.Client;
    using LibraryManager.Services.Common;
    using LibraryManager.ViewModels;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class CurrentBook : Form
    {
        BookViewModel book;
        IBookService bookService;
        IChangeFormService changeFormService;
        private LibraryManagerContext db;
        IDeletableEntityRepository<BorrowedBook> borrowedBooks;
        IDeletableEntityRepository<User> user;
        IRoleService roleService;

        public CurrentBook(BookViewModel book)
        {
            InitializeComponent();
            this.book = book;
            this.borrowedBooks = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.bookService = new BookService(new LibraryManagerContext(), this.borrowedBooks);
            this.roleService = new RoleService(this.user);
            this.changeFormService = new ChangeFormService();
            //refactor
            this.db = new LibraryManagerContext();
        }

        private void CurrentBook_Load(object sender, EventArgs e)
        {
            //Display update button for admin
            var currentUser = this.roleService.GetCurrentUser();
            if (currentUser.Role == "Student")
            {
                updateBook_btn.Visible = false;
            }


            title_label.Text = this.book.Title;
            author_label.Text = "by " + this.book.AuthorName;
            description_textBox.Text = this.book.Description;
            genre_label.Text = this.book.Genre;


            var currentBook = this.db.Books.Include(x => x.BookImage).FirstOrDefault(x => x.Title == title_label.Text);
            if (currentBook.BookImageId != null)
            {
                Bitmap bmp;
                using (var ms = new MemoryStream(currentBook.BookImage.Image))
                {
                    bmp = new Bitmap(ms);
                }
                pictureBox1.Image = bmp;
            }
            

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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void updateBook_btn_Click(object sender, EventArgs e)
        {
            var bookId = this.bookService.GetBookIdByTitle(title_label.Text);
            this.changeFormService.Change(this, new UpdateBook(bookId));
        }
    }
}
