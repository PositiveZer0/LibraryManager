namespace LibraryManager.Forms.Client
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Forms.Admin;
    using LibraryManager.Services.Client;
    using LibraryManager.Services.Common;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public partial class Profile : Form
    {
        Image bookImage;
        byte[] bookImageInBytes;
        IBookService bookService;
        LibraryManagerContext db;
        private IDeletableEntityRepository<BorrowedBook> borrowedBook;
        IChangeFormService changeFormService;

        public Profile()
        {
            InitializeComponent();
            this.db = new LibraryManagerContext(); 
            this.borrowedBook = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.bookService = new BookService(db, borrowedBook);
            this.changeFormService = new ChangeFormService();
            
            //todo: refactor 
            var currentUser = this.db.Users.Include(x => x.UserImage).FirstOrDefault(x => x.IsLoggedIn == true);
            name_box.Text = currentUser.Name;
            surname_box.Text = currentUser.Surname;
            email_box.Text = currentUser.Email;

            Bitmap bmp;
            using (var ms = new MemoryStream(currentUser.UserImage.Image))
            {
                bmp = new Bitmap(ms);
            }
            profile_pic.Image = bmp;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var currentBook = new AddBook();
            currentBook.Show(this);
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.changeFormService.Change(this.ParentForm, new Form1());
        }

        private void changePsw_btn_Click(object sender, EventArgs e)
        {
            var changePasswordUser = new ChangePassword(email_box.Text);
            changePasswordUser.Show(this);
        }

        private void editPhoto_btn_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(showOpenFileDialog));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
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
                        this.bookImage = Image.FromStream(fileStream);
                        arr = ReadFully(fileStream);
                    }

                    profile_pic.Image = this.bookImage;
                    this.bookImageInBytes = arr;
                    var userImage = new UserImage()
                    {
                        Image = bookImageInBytes
                    }; 

                    this.db.UserImage.Add(userImage);
                    var user = this.db.Users.FirstOrDefault(x => x.Email == email_box.Text);
                    user.UserImage = userImage;
                    this.db.SaveChanges();
                }
            }
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
