namespace LibraryManager.Forms.Admin
{
    using System;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Admin;

    public partial class UpdateBook : Form
    {
        private int id;
        private IDeletableEntityRepository<Book> book;
        private IAdminService adminService;
        public UpdateBook(int id)
        {
            InitializeComponent();
            this.book = new EfDeletableEntityRepository<Book>(new LibraryManagerContext());
            this.adminService = new AdminService(this.book);
            this.id = id;
            var loader = this.adminService.GetBookById(this.id);
            title_textBox.Text = loader.Title;
            authorName_textBox.Text = loader.AuthorName;
            genre_textBox.Text = loader.Genre;
            quantity_textBox.Text = loader.Quantity.ToString();
            description_textBox.Text = loader.Description;
        }

        private async void updateBook_btn_Click(object sender, EventArgs e)
        {
            var currentBook = new Book
            {
                Id = this.id,
                Title = title_textBox.Text,
                AuthorName = authorName_textBox.Text,
                Genre = genre_textBox.Text,
                Description = description_textBox.Text,
                Quantity = Convert.ToInt32(quantity_textBox.Text),
            };
            try
            {
                await this.adminService.UpdateBookAsync(currentBook, this.id);
            }
            catch (Exception)
            {
                MessageBox.Show("Book update failed", "Error");
            }

            MessageBox.Show("Book updated successfully", "Book update");
            this.Close();
        }
    }
}
