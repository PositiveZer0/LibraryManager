namespace LibraryManager.Forms
{
    using System;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Common;
    using LibraryManager.Services.Login;
    using LibraryManager.Services.Login.ValidationCreateAccount;

    public partial class ForgottenPassword : Form
    {
        private Timer timer;
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;
        private IShowErrorService showErrorService;
        private ISixDigitCodeValidator codeValidator;
        private IChangePasswordService changePassword;
        private IChangeFormService changeFormService;
        private IDeletableEntityRepository<User> user;
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail;

        public ForgottenPassword()
        {
            InitializeComponent();
            this.timer = new Timer();
            this.passwordValidator = new PasswordValidator();
            this.showErrorService = new ShowErrorService(errors_textbox, timer);
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.confirmEmail = new EfDeletableEntityRepository<ConfirmEmail>(new LibraryManagerContext());
            this.changePassword = new ChangePasswordService(this.user);
            this.emailValidator = new EmailValidator(this.user);
            this.codeValidator = new SixDigitCodeValidator(this.confirmEmail, this.user);
            this.changeFormService = new ChangeFormService();
        }

        private async void sendCode_btn_Click(object sender, EventArgs e)
        {
            var email = email_box.Text;
            var isEmailValid = this.emailValidator.EmailShouldExistInDb(email);
            if (isEmailValid != string.Empty)
            {
                this.showErrorService.Show(5000, isEmailValid);
                return;
            }

            this.showErrorService.Show(5000, "Code is sent to email");
            await this.codeValidator.GenerateAsync(email);
            email_box.ReadOnly = true;
        }


        private async void resendCode_btn_Click(object sender, EventArgs e)
        {
            var email = email_box.Text;
            var isEmailValid = this.emailValidator.EmailShouldExistInDb(email);
            if (isEmailValid != null)
            {
                this.showErrorService.Show(5000, isEmailValid);
                return;
            }

            this.showErrorService.Show(5000, "New code is sent");
            await this.codeValidator.ResendCode(email);
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            var email = email_box.Text;
            if (!this.codeValidator.IsValid(email, code_box.Text))
            {
                this.showErrorService.Show(5000, "Code is incorrect");
                return;
            }
            var password = newPassword_box.Text;
            var confirmPassword = confirmNewPsw_box.Text;
            //remove

            var result = passwordValidator.Validate(password, confirmPassword);
            if (result != String.Empty)
            {
                this.showErrorService.Show(5000, result);
                return;
            }

            this.changePassword.Change(email, password);
            //todo: add beautiful msg box
            MessageBox.Show("Password changed successfully", "Password change");
            this.changeFormService.Change(this, new Form1());
        }
        private void password_pic_Click(object sender, EventArgs e)
        {
            newPassword_box.UseSystemPasswordChar = !newPassword_box.UseSystemPasswordChar;
        }

        private void confirm_psw_pic_Click(object sender, EventArgs e)
        {
            newPassword_box.UseSystemPasswordChar = !newPassword_box.UseSystemPasswordChar;
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            this.changeFormService.Change(this, new Form1());
        }
    }
}
