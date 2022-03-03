namespace LibraryManager.Forms.Client
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.books_dataGridView = new System.Windows.Forms.DataGridView();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.addBook_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.books_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // books_dataGridView
            // 
            this.books_dataGridView.AllowUserToAddRows = false;
            this.books_dataGridView.AllowUserToDeleteRows = false;
            this.books_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books_dataGridView.Location = new System.Drawing.Point(-10, 131);
            this.books_dataGridView.Name = "books_dataGridView";
            this.books_dataGridView.ReadOnly = true;
            this.books_dataGridView.RowHeadersWidth = 102;
            this.books_dataGridView.RowTemplate.Height = 49;
            this.books_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books_dataGridView.Size = new System.Drawing.Size(1558, 890);
            this.books_dataGridView.TabIndex = 0;
            this.books_dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.books_dataGridView_CellMouseDoubleClick);
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(85, 42);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(407, 47);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // addBook_btn
            // 
            this.addBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.addBook_btn.FlatAppearance.BorderSize = 0;
            this.addBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBook_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBook_btn.Location = new System.Drawing.Point(1276, 1062);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(221, 88);
            this.addBook_btn.TabIndex = 22;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.UseVisualStyleBackColor = false;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1162);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.books_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.books_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView books_dataGridView;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button addBook_btn;
    }
}