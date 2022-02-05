namespace LibraryManager.Forms.Client
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Client;
    using LibraryManager.ViewModels;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class Books : Form
    {
        string method;
        IBookService bookService;
        LibraryManagerContext db;
        IDeletableEntityRepository<BorrowedBook> borrowedBooks;

        public Books(string method = "All")
        {
            InitializeComponent();
            this.db = new LibraryManagerContext();
            this.borrowedBooks = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.bookService = new BookService(this.db, this.borrowedBooks);
            this.method = method;
        }

        private void Books_Load(object sender, EventArgs e)
        {
            //var list = new BindingList<Book>();
            //var book1 = new Book
            //{
            //    AuthorName = "filip",
            //    Genre = "Drama",
            //    Quantity = 30,
            //    Description = "Really good book",
            //    Title = "Romeo and Juliet"
            //};
            var list = new BindingList<BookViewModel>(this.bookService.GetAllBooks());

            if (this.method == "Borrowed books")
            {
                var borrowedBooks = new BindingList<BorrowedBookViewModel>(this.bookService.GetAllBorrowedBooks());
                books_dataGridView.DataSource = borrowedBooks;
                return;
            }

            if (this.method == "Available")
            {
                list = new BindingList<BookViewModel>(this.bookService.GetAllAvailableBooks());
            }

            books_dataGridView.DataSource = list;
            //books_dataGridView.Columns["IsDeleted"].Visible = false;
            //books_dataGridView.Columns["DeletedOn"].Visible = false;
            //books_dataGridView.Columns["Id"].Visible = false;
            //books_dataGridView.Columns["CreatedOn"].Visible = false;
            //books_dataGridView.Columns["ModifiedOn"].Visible = false;
            //books_dataGridView.Columns["BorrowedBooks"].Visible = false;

        }

    }
}
