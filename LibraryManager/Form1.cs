namespace LibraryManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using LibraryManager.Forms;
    using LibraryManager.Forms.Client;
    using LibraryManager.Services.Common;
    using LibraryManager.Services.Login;
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;

    public partial class Form1 : Form
    {
        Timer timer;
        ILoginService loginService;
        IChangeFormService changeFormService;
        IShowErrorService showErrorService;
        IDeletableEntityRepository<User> user;

        public Form1()
        {
            InitializeComponent();
            this.timer = new Timer();
            this.changeFormService = new ChangeFormService();
            this.user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());
            this.loginService = new LoginService(this.user);
            this.showErrorService = new ShowErrorService(error_textbox, this.timer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void username_box_Click(object sender, EventArgs e)
        {
            username_box.BackColor = SystemColors.ButtonHighlight;
            username_wrapper.BackColor = SystemColors.ButtonHighlight;
            password_box.BackColor = SystemColors.Control;
            password_wrapper.BackColor = SystemColors.Control;
        }


        private void password_box_Click(object sender, EventArgs e)
        {
            username_box.BackColor = SystemColors.Control;
            username_wrapper.BackColor = SystemColors.Control;
            password_box.BackColor = SystemColors.ButtonHighlight;
            password_wrapper.BackColor = SystemColors.ButtonHighlight;
        }

        private void password_pic_Click(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private void create_account_btn_Click(object sender, EventArgs e)
        {
            this.changeFormService.Change(this, new CreateAccount());
        }

        private void forgotten_psw_btn_Click(object sender, EventArgs e)
        {
            this.changeFormService.Change(this, new ForgottenPassword());
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //this.changeFormService.Change(this, new Main());
            var username = username_box.Text;
            var password = password_box.Text;

            var loginMessage = this.loginService.Login(username, password);
            if (loginMessage != string.Empty)
            {
                this.showErrorService.Show(5000, loginMessage);
                return;
            }

            this.changeFormService.Change(this, new Main());
        }

    }
}
