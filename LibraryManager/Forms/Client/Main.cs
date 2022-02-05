namespace LibraryManager.Forms.Client
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void books_btn_Click(object sender, EventArgs e)
        {
            changeDescriptionText("All Books");
            openChildForm(new Books());
        }


        private void all_btn_Click(object sender, EventArgs e)
        {
            books_btn_Click(sender, e);
        }

        private void available_btn_Click(object sender, EventArgs e)
        {
            changeDescriptionText("Available books");
            openChildForm(new Books((sender as Button).Text));
        }

        private void borrowed_books_btn_Click(object sender, EventArgs e)
        {
            changeDescriptionText("Borrowed books");
            openChildForm(new Books((sender as Button).Text));
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            changeDescriptionText("Profile");
            openChildForm(new Profile());
        }

        private void changeDescriptionText(string text)
        {
            description_label.Text = text;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            form_panel.Controls.Add(childForm);
            form_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
