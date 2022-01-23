﻿namespace LibraryManager
{
    using LibraryManager.Forms;
    using LibraryManager.Forms.Client;
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
        public Form1()
        {
            InitializeComponent();
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
    }
}
