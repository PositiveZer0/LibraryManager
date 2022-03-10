namespace LibraryManager.Forms.Admin
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Client;
    using LibraryManager.ViewModels;

    public partial class AddBook : Form
    {
        private byte[] bookImageInBytes;
        private Image bookImage;
        private LibraryManagerContext db;
        private IBookService bookService;
        private IDeletableEntityRepository<BorrowedBook> borrowedBooks;

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
            var image = this.bookImageInBytes;
            var book = new BookViewModel()
            {
                Title = title,
                Description = description,
                AuthorName = authorName,
                Genre = genre,
                Image = image,
            };

            try
            {
                await this.bookService.AddBookAsync(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            MessageBox.Show("Book added successfully", "Book add");
            this.Close();
        }

        private void addImage_btn_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(showOpenFileDialog));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        //Image processing
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
                        this.bookImage = Image.FromStream(fileStream);
                        arr = ReadFully(fileStream);
                    }

                    book_pictureBox.Image = this.bookImage;
                    this.bookImageInBytes = arr;
                }
            }
        }

        private static byte[] ReadFully(Stream input)
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
