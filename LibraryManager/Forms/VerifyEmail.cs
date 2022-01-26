namespace LibraryManager.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services;
    using LibraryManager.Services.ValidationCreateAccount;

    public partial class VerifyEmail : Form
    {
        private string email;
        private Timer timer = new Timer();
        private ISixDigitCodeValidator codeValidator;
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail = new EfDeletableEntityRepository<ConfirmEmail>(new LibraryManagerContext());
        private IDeletableEntityRepository<User> user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());

        public VerifyEmail(string userEmail)
        {
            InitializeComponent();
            this.codeValidator = new SixDigitCodeValidator(this.confirmEmail, this.user);
            email_box.Text = userEmail;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Generate first six digit code
            this.email = email_box.Text;
            await this.codeValidator.GenerateAsync(this.email);
        }

        private async void verify_btn_Click(object sender, EventArgs e)
        {
            var codeInput = code_box.Text.TrimEnd();

            if (!this.codeValidator.IsValid(this.email, codeInput))
            {
                SetTimer(5000);
                ShowTextBox("Wrong verification code");
                return;
            }

            await this.codeValidator.ValidateAsync(this.email);

            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private async void resendCode_btn_Click(object sender, EventArgs e)
        {
            SetTimer(5000);

            ShowTextBox("New code is sent");
            await this.codeValidator.ResendCode(this.email);
        }

        private void SetTimer(int miliseconds)
        {
            timer.Stop();
            timer.Interval = (miliseconds);
            timer.Tick += new EventHandler(ClearTextBox);
            timer.Start();
        }

        private void ShowTextBox(string message)
        {
            wrongCode_textbox.Visible = true;
            wrongCode_textbox.ForeColor = System.Drawing.Color.Red;
            wrongCode_textbox.BackColor = System.Drawing.Color.White;
            wrongCode_textbox.Text = message;
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            wrongCode_textbox.Text = String.Empty;
            wrongCode_textbox.Visible = false;
        }
    }
}
