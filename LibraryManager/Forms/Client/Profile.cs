namespace LibraryManager.Forms.Client
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Forms.Admin;
    using LibraryManager.Services.Client;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Profile : Form
    {
        IBookService bookService;
        LibraryManagerContext db;
        private IDeletableEntityRepository<BorrowedBook> borrowedBook;

        public Profile()
        {
            InitializeComponent();
            this.db = new LibraryManagerContext(); 
            this.borrowedBook = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.bookService = new BookService(db, borrowedBook);
            //todo: refactor 
            var currentUser = this.db.Users.FirstOrDefault(x => x.IsLoggedIn == true);
            name_box.Text = currentUser.Name;
            surname_box.Text = currentUser.Surname;
            email_box.Text = currentUser.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bookService.BorrowBook(4);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var currentBook = new AddBook();
            currentBook.Show(this);
        }

    }
}
