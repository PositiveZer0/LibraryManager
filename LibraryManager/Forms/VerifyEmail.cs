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
    using LibraryManager.Services.Common;
    using LibraryManager.Services.Login;
    using LibraryManager.Services.Login.ValidationCreateAccount;

    public partial class VerifyEmail : Form
    {
        private string email;
        private Timer timer;
        private IChangeFormService changeFormService;
        private IShowErrorService showErrorService;
        private ISixDigitCodeValidator codeValidator;
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail;
        private IDeletableEntityRepository<User> user;

        public VerifyEmail(string userEmail)
        {
            InitializeComponent();
            email_box.Text = userEmail;
            this.timer = new Timer();
            this.changeFormService = new ChangeFormService();
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.confirmEmail = new EfDeletableEntityRepository<ConfirmEmail>(new LibraryManagerContext());
            this.codeValidator = new SixDigitCodeValidator(this.confirmEmail, this.user);
            this.showErrorService = new ShowErrorService(wrongCode_textbox, this.timer);
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
                this.showErrorService.Show(5000, "Wrong verification code");
                return;
            }

            await this.codeValidator.ValidateAsync(this.email);
            this.changeFormService.Change(this, new Form1());
        }

        private async void resendCode_btn_Click(object sender, EventArgs e)
        {
            this.showErrorService.Show(5000, "New code is sent");
            await this.codeValidator.ResendCode(this.email);
        }
    }
}
