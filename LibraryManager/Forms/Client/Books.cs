namespace LibraryManager.Forms.Client
{
    using LibraryManager.Database.Models;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            var list = new BindingList<Book>();
            var book1 = new Book
            {
                AuthorName = "filip",
                Genre = "Drama",
                Quantity = 30,
                Description = "Really good book",
                Title = "Romeo and Juliet"
            };
            list.Add(book1);
            list.Add(book1);
            books_dataGridView.DataSource = list;
            books_dataGridView.Columns["IsDeleted"].Visible = false;
            books_dataGridView.Columns["DeletedOn"].Visible = false;
            books_dataGridView.Columns["Id"].Visible = false;
            books_dataGridView.Columns["CreatedOn"].Visible = false;
            books_dataGridView.Columns["ModifiedOn"].Visible = false;
            books_dataGridView.Columns["BorrowedBooks"].Visible = false;

        }
    }
}
