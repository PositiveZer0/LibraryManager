namespace LibraryManager.Forms.Admin
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Admin;
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class UpdateBook : Form
    {
        int id;
        IDeletableEntityRepository<Book> book;
        IAdminService adminService;
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

            await this.adminService.UpdateBookAsync(currentBook, this.id);
        }
    }
}
