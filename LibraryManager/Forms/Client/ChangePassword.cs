namespace LibraryManager.Forms.Client
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Common;
    using LibraryManager.Services.Login;
    using LibraryManager.Services.Login.ValidationCreateAccount;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ChangePassword : Form
    {
        string email;
        Timer timer;
        IShowErrorService showErrorService;
        IChangePasswordService changePasswordService;
        IDeletableEntityRepository<User> user;

        public ChangePassword(string email)
        {
            InitializeComponent();
            this.email = email;
            this.timer = new Timer();
            this.showErrorService = new ShowErrorService(errors_textbox, timer);
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.changePasswordService = new ChangePasswordService(this.user);
        }

        private void oldPassword_pic_Click(object sender, EventArgs e)
        {
            oldPassword_box.UseSystemPasswordChar = !oldPassword_box.UseSystemPasswordChar;
        }

        private void password_pic_Click(object sender, EventArgs e)
        {
            newPassword_box.UseSystemPasswordChar = !newPassword_box.UseSystemPasswordChar;
        }

        private void confirm_psw_pic_Click(object sender, EventArgs e)
        {
            confirmNewPsw_box.UseSystemPasswordChar = !confirmNewPsw_box.UseSystemPasswordChar;
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            var oldPassword = oldPassword_box.Text;
            var password = newPassword_box.Text;
            var confirmPassword = confirmNewPsw_box.Text;
            var currentUser = this.user.All().FirstOrDefault(x => x.Email == this.email);
            if (!SecurePasswordHasher.Verify(oldPassword, currentUser.Password))
            {
                this.showErrorService.Show(5000, "Incorrect old password");
                return;
            }

            var passwordValidator = new PasswordValidator(password, confirmPassword);
            var result = passwordValidator.Validate();
            if (result != String.Empty)
            {
                this.showErrorService.Show(5000, result);
                return;
            }

            this.changePasswordService.Change(this.email, password);
            //todo: add beautiful msg box
            MessageBox.Show("Password changed successfully", "Password change");
            this.Close();
        }
    }
}
