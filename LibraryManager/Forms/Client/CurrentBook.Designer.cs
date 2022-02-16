namespace LibraryManager.Forms.Client
{
    partial class CurrentBook
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.genre_label = new System.Windows.Forms.Label();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.description_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManager.Properties.Resources.harry_potter_and_the_philosopher_s_stone;
            this.pictureBox1.Location = new System.Drawing.Point(109, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.title_label.Location = new System.Drawing.Point(605, 29);
            this.title_label.MaximumSize = new System.Drawing.Size(800, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(672, 148);
            this.title_label.TabIndex = 8;
            this.title_label.Text = "Harry Potter and the chaber of the secrets ";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.author_label.Location = new System.Drawing.Point(758, 205);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(595, 74);
            this.author_label.TabIndex = 9;
            this.author_label.Text = "by Anthony Jacobs";
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genre_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.genre_label.Location = new System.Drawing.Point(145, 744);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(290, 74);
            this.genre_label.TabIndex = 10;
            this.genre_label.Text = "Comedy";
            // 
            // borrow_btn
            // 
            this.borrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.borrow_btn.FlatAppearance.BorderSize = 0;
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrow_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrow_btn.Location = new System.Drawing.Point(821, 744);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(319, 119);
            this.borrow_btn.TabIndex = 11;
            this.borrow_btn.Text = "Borrow book";
            this.borrow_btn.UseVisualStyleBackColor = false;
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(605, 365);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.ReadOnly = true;
            this.description_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textBox.Size = new System.Drawing.Size(743, 345);
            this.description_textBox.TabIndex = 12;
            // 
            // CurrentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 940);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.borrow_btn);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CurrentBook";
            this.Text = "CurrentBook";
            this.Load += new System.EventHandler(this.CurrentBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.TextBox description_textBox;
    }
}