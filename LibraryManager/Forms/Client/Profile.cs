namespace LibraryManager.Forms.Client
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Common;

    public partial class Profile : Form
    {
        private Image bookImage;
        private byte[] bookImageInBytes;
        private LibraryManagerContext db;
        private IDeletableEntityRepository<BorrowedBook> borrowedBook;
        private IChangeFormService changeFormService;

        public Profile()
        {
            InitializeComponent();
            this.db = new LibraryManagerContext(); 
            this.borrowedBook = new EfDeletableEntityRepository<BorrowedBook>(new LibraryManagerContext());
            this.changeFormService = new ChangeFormService();
            
            //todo: refactor 
            var currentUser = this.db.Users.Include(x => x.UserImage).FirstOrDefault(x => x.IsLoggedIn == true);
            name_box.Text = currentUser.Name;
            surname_box.Text = currentUser.Surname;
            email_box.Text = currentUser.Email;

            if (currentUser.UserImage != null)
            {
                Bitmap bmp;
                using (var ms = new MemoryStream(currentUser.UserImage.Image))
                {
                    bmp = new Bitmap(ms);
                }
                profile_pic.Image = bmp;
            }
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
