namespace LibraryManager.Forms.Client
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Forms.Admin;
    using LibraryManager.Services.Client;
    using LibraryManager.Services.Common;
    using LibraryManager.ViewModels;

    public partial class Books : Form
    {
        private string method;
        private IBookService bookService;
        private IRoleService roleService;
        private LibraryManagerContext db;
        private IDeletableEntityRepository<BorrowedBook> borrowedBooks;
        private IDeletableEntityRepository<User> user;

        public Books(string method = "All")
        {
            InitializeComponent();
            this.db = new LibraryManagerContext();
            this.borrowedBooks = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.roleService = new RoleService(this.user);
            this.bookService = new BookService(this.db, this.borrowedBooks);
            this.method = method;
            StyleDatagridview();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            //Display add book button if role is admin
            var currentUser = this.roleService.GetCurrentUser();
            if (currentUser.Role == "Student")
            {
                addBook_btn.Visible = false;
            }

            var list = new BindingList<BookViewModel>(this.bookService.GetAllBooks());

            if (this.method == "Borrowed books")
            {
                var borrowedBooks = new BindingList<BorrowedBookViewModel>(this.bookService.GetAllBorrowedBooks());
                books_dataGridView.DataSource = borrowedBooks;
                books_dataGridView.Columns["Image"].Visible = false;
                books_dataGridView.Columns["Quantity"].Visible = false;
                return;
            }

            if (this.method == "Available")
            {
                list = new BindingList<BookViewModel>(this.bookService.GetAllAvailableBooks());
            }

            books_dataGridView.DataSource = list;
            books_dataGridView.Columns["Image"].Visible = false;
            books_dataGridView.Columns["Quantity"].Visible = false;
            this.books_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.books_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.books_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.books_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.books_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            var word = this.search_textBox.Text;

            var list = new BindingList<BookViewModel>(this.bookService.SearchBooks(word));

            books_dataGridView.DataSource = list;
        }

        private void books_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = books_dataGridView.Rows[e.RowIndex];
            var title = row.Cells["Title"].Value.ToString();
            var authorName = row.Cells["AuthorName"].Value.ToString();
            var quantity = (int)row.Cells["Quantity"].Value;
            var genre = row.Cells["Genre"].Value.ToString();
            var description = row.Cells["Description"].Value.ToString();

            var book = new BookViewModel
            {
                Title = title,
                AuthorName = authorName,
                Quantity = quantity,
                Genre = genre,
                Description = description,
            };

            var currentBook = new CurrentBook(book);
            currentBook.Show(this);
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            var currentBook = new AddBook();
            currentBook.Show(this);
        }

        private void StyleDatagridview()
        {
            books_dataGridView.BorderStyle = BorderStyle.None;
            books_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            books_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            books_dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 125, 185);
            books_dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            books_dataGridView.BackgroundColor = Color.FromArgb(240, 240, 240);
            books_dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            books_dataGridView.EnableHeadersVisualStyles = false;
            books_dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            books_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 12);
            books_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 125, 185);
            books_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);
        }

    }
}
