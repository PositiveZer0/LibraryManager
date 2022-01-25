namespace LibraryManager.Forms
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.ValidationCreateAccount;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class VerifyEmail : Form
    {
        private SixDigitCodeValidator codeValidator;
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail = new EfDeletableEntityRepository<ConfirmEmail>(new LibraryManagerContext());
        private IDeletableEntityRepository<User> user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
        public VerifyEmail(string emailForm)
        {
            InitializeComponent();
            this.codeValidator = new SixDigitCodeValidator(confirmEmail, user);
            email_box.Text = emailForm;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var email = email_box.Text;
            await this.codeValidator.GenerateAsync(email);
        }

        private async void verify_btn_Click(object sender, EventArgs e)
        {
            var email = email_box.Text;
            var codeInput = code_box.Text.TrimEnd();

            if (!this.codeValidator.IsValid(email, codeInput))
            {
                wrongCode_textbox.Visible = true;
                wrongCode_textbox.ForeColor = System.Drawing.Color.Red;
                wrongCode_textbox.BackColor = System.Drawing.Color.White;
                wrongCode_textbox.Text = "Wrong verification code";
                return;
            }

            await this.codeValidator.ValidateAsync(email);

            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private async void resendCode_btn_Click(object sender, EventArgs e)
        {
            //todo: add dialog window new code send
            await this.codeValidator.ResendCode(email_box.Text);
        }
    }
}
