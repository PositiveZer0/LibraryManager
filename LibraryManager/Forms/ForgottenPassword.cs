namespace LibraryManager.Forms
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Common;
    using LibraryManager.Services.Login;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class ForgottenPassword : Form
    {
        string email;
        Timer timer;
        IShowErrorService showErrorService;
        ISixDigitCodeValidator codeValidator;
        private IDeletableEntityRepository<User> user;
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail;

        public ForgottenPassword()
        {
            InitializeComponent();
            this.email = email_box.Text;
            this.timer = new Timer();
            this.showErrorService = new ShowErrorService(errors_textbox, timer);
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.confirmEmail = new EfDeletableEntityRepository<ConfirmEmail>(new LibraryManagerContext());
            this.codeValidator = new SixDigitCodeValidator(this.confirmEmail, this.user);
        }

        private async void sendCode_btn_Click(object sender, EventArgs e)
        {
            this.showErrorService.Show(5000, "Code is sent to email");
            await this.codeValidator.GenerateAsync(this.email);
        }

        private void password_pic_Click(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private void confirm_psw_pic_Click(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private async void resendCode_btn_Click(object sender, EventArgs e)
        {
            this.showErrorService.Show(5000, "New code is sent");
            await this.codeValidator.ResendCode(this.email);
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            if (!this.codeValidator.IsValid(this.email, code_box.Text))
            {
                this.showErrorService.Show(5000, "Code is incorrect");
                return;
            }

        }
    }
}
