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
        public VerifyEmail()
        {
            InitializeComponent();
            this.codeValidator = new SixDigitCodeValidator(confirmEmail, user);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            email_box.Text = "azsumemi@gmail.com";

            var email = email_box.Text;
            this.codeValidator.Generate(email);
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            var email = email_box.Text;
            var codeInput = code_box.Text;

            if (!this.codeValidator.IsValid(email, codeInput))
            {
                wrongCode_textbox.Visible = true;
                wrongCode_textbox.ForeColor = System.Drawing.Color.Red;
                wrongCode_textbox.BackColor = System.Drawing.Color.White;
                wrongCode_textbox.Text = "Wrong verification code";
                return;
            }

            this.codeValidator.Validate(email);

            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void forgotten_psw_btn_Click(object sender, EventArgs e)
        {
            //todo: add dialog window new code send
            this.codeValidator.Generate(email_box.Text);
        }
    }
}
