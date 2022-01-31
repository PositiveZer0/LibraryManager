namespace LibraryManager.Forms
{
    using System;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Login;
    using LibraryManager.Services.Common;

    public partial class CreateAccount : Form
    {
        private IChangeFormService changeFormService;
        private ICreateAccountService createAccountService;
        private IDeletableEntityRepository<User> user; 

        public CreateAccount()
        {
            InitializeComponent();
            this.changeFormService = new ChangeFormService();
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.createAccountService = new CreateAccountService(this.user);
        }

        public string Email
        {
            get { return email_box.Text; }
        }

        private void password_pic_Click(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private void confirm_psw_pic_Click(object sender, EventArgs e)
        {
            confirm_psw_box.UseSystemPasswordChar = !confirm_psw_box.UseSystemPasswordChar;
        }

        private async void create_acc_btn_Click(object sender, EventArgs e)
        {
            errors_textbox.Text = string.Empty;

            var name = name_box.Text;
            var surname = surname_box.Text;
            var email = email_box.Text;
            var password = password_box.Text;
            var confirmPassword = confirm_psw_box.Text;
            var role = "Student";
            var isEmailVerified = false;

            var errors = this.createAccountService.ValidateAccount(name, surname, email, password, confirmPassword);
            if (errors != string.Empty)
            {
                errors_textbox.Visible = true;
                errors_textbox.ForeColor = System.Drawing.Color.Red;
                errors_textbox.BackColor = System.Drawing.Color.White;
                errors_textbox.Text = errors;
                return;
            }
            //todo: create acc only after verification and make back button auto fill last filled acc
            await this.createAccountService.CreateAccount(name, surname, email, password, role, isEmailVerified);
            this.changeFormService.Change(this, new VerifyEmail(email_box.Text));
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            this.changeFormService.Change(this, new Form1());
        }
    }
}
