namespace LibraryManager.Forms
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Common;
    using LibraryManager.Services.Login;
    using LibraryManager.Services.Login.ValidationCreateAccount;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class ForgottenPassword : Form
    {
        Timer timer;
        EmailValidator emailValidator;
        IShowErrorService showErrorService;
        ISixDigitCodeValidator codeValidator;
        IChangePasswordService changePassword;
        IChangeFormService changeFormService;
        private IDeletableEntityRepository<User> user;
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail;

        public ForgottenPassword()
        {
            InitializeComponent();
            this.timer = new Timer();
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
            if (password != confirmPassword)
            {
                this.showErrorService.Show(5000, "Password and confirm password are different");
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
    }
}
