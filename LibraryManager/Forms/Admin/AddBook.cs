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
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public partial class AddBook : Form
    {
        IBookService bookService;
        LibraryManagerContext db;
        IDeletableEntityRepository<BorrowedBook> borrowedBooks;
        Image imageForBook;
        byte[] imageFromByte;

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
            var image = this.imageFromByte;
            var book = new BookViewModel()
            {
                Title = title,
                Description = description,
                AuthorName = authorName,
                Genre = genre,
                Image = image,
            };
            await this.bookService.AddBookAsync(book);
        }

        private void showOpenFileDialog()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            byte[] arr;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        this.imageForBook = Image.FromStream(fileStream);
                        arr = ReadFully(fileStream);
                    }

                    book_pictureBox.Image = this.imageForBook;
                    this.imageFromByte = arr;
                }
            }
        }
        private void addImage_btn_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(showOpenFileDialog));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

       

        public static byte[] ReadFully(Stream input)
        {
            input.Position = 0;
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
