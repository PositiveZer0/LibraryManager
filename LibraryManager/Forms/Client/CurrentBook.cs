namespace LibraryManager.Forms.Client
{
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class CurrentBook : Form
    {
        BookViewModel book;
        public CurrentBook(BookViewModel book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void CurrentBook_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.book.Title;
            textBox2.Text = this.book.AuthorName;
            textBox3.Text = this.book.Quantity.ToString();
            textBox4.Text = this.book.Description;
            textBox5.Text = this.book.Genre;
        }
    }
}
