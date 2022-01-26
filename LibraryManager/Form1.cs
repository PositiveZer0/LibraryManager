namespace LibraryManager
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Forms;
    using LibraryManager.Forms.Client;
    using LibraryManager.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        ILoginService loginService;
        Timer timer = new Timer();
        IDeletableEntityRepository<User> user = new EfDeletableEntityRepository<User>(new LibraryManagerContext());

        public Form1()
        {
            InitializeComponent();
            loginService = new LoginService(this.user);
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
            this.Hide();
            var createAccountForm = new CreateAccount();
            createAccountForm.Closed += (s, args) => this.Close();
            createAccountForm.Show();
        }

        private void forgotten_psw_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new Main();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var username = username_box.Text;
            var password = password_box.Text;

            var loginMessage = this.loginService.Login(username, password);
            if (loginMessage != string.Empty)
            {
                SetTimer(5000);
                ShowTextBox(loginMessage);
                return;
            }

            this.Hide();
            var mainForm = new Main();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
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
            error_textbox.Visible = true;
            error_textbox.ForeColor = System.Drawing.Color.Red;
            error_textbox.BackColor = System.Drawing.Color.White;
            error_textbox.Text = message;
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            error_textbox.Text = String.Empty;
            error_textbox.Visible = false;
        }
    }
}
