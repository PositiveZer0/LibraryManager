namespace LibraryManager.Forms.Admin
{
    partial class AddBook
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
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addImage_btn = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.authorName_label = new System.Windows.Forms.Label();
            this.authorName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genre_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(554, 519);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textBox.Size = new System.Drawing.Size(743, 284);
            this.description_textBox.TabIndex = 18;
            // 
            // addBook_btn
            // 
            this.addBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.addBook_btn.FlatAppearance.BorderSize = 0;
            this.addBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBook_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBook_btn.Location = new System.Drawing.Point(757, 809);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(319, 119);
            this.addBook_btn.TabIndex = 17;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.UseVisualStyleBackColor = false;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManager.Properties.Resources.defaultBookCover;
            this.pictureBox1.Location = new System.Drawing.Point(58, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // addImage_btn
            // 
            this.addImage_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.addImage_btn.FlatAppearance.BorderSize = 0;
            this.addImage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImage_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addImage_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addImage_btn.Location = new System.Drawing.Point(58, 738);
            this.addImage_btn.Name = "addImage_btn";
            this.addImage_btn.Size = new System.Drawing.Size(412, 82);
            this.addImage_btn.TabIndex = 19;
            this.addImage_btn.Text = "Add Image";
            this.addImage_btn.UseVisualStyleBackColor = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.title_label.Location = new System.Drawing.Point(554, 77);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(91, 50);
            this.title_label.TabIndex = 20;
            this.title_label.Text = "Title";
            // 
            // title_textBox
            // 
            this.title_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_textBox.Location = new System.Drawing.Point(554, 130);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(743, 56);
            this.title_textBox.TabIndex = 21;
            // 
            // authorName_label
            // 
            this.authorName_label.AutoSize = true;
            this.authorName_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.authorName_label.Location = new System.Drawing.Point(554, 205);
            this.authorName_label.Name = "authorName_label";
            this.authorName_label.Size = new System.Drawing.Size(237, 50);
            this.authorName_label.TabIndex = 22;
            this.authorName_label.Text = "Author name";
            // 
            // authorName_textBox
            // 
            this.authorName_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorName_textBox.Location = new System.Drawing.Point(554, 258);
            this.authorName_textBox.Name = "authorName_textBox";
            this.authorName_textBox.Size = new System.Drawing.Size(743, 56);
            this.authorName_textBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(554, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "Genre";
            // 
            // genre_textBox
            // 
            this.genre_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genre_textBox.Location = new System.Drawing.Point(554, 395);
            this.genre_textBox.Name = "genre_textBox";
            this.genre_textBox.Size = new System.Drawing.Size(743, 56);
            this.genre_textBox.TabIndex = 25;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.description_label.Location = new System.Drawing.Point(554, 466);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(209, 50);
            this.description_label.TabIndex = 26;
            this.description_label.Text = "Description";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 940);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.genre_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorName_textBox);
            this.Controls.Add(this.authorName_label);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.addImage_btn);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addImage_btn;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label authorName_label;
        private System.Windows.Forms.TextBox authorName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox genre_textBox;
        private System.Windows.Forms.Label description_label;
    }
}