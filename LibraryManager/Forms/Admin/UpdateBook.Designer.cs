namespace LibraryManager.Forms.Admin
{
    partial class UpdateBook
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
            this.description_label = new System.Windows.Forms.Label();
            this.genre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorName_textBox = new System.Windows.Forms.TextBox();
            this.authorName_label = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.updateBook_btn = new System.Windows.Forms.Button();
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.description_label.Location = new System.Drawing.Point(35, 436);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(209, 50);
            this.description_label.TabIndex = 37;
            this.description_label.Text = "Description";
            // 
            // genre_textBox
            // 
            this.genre_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genre_textBox.Location = new System.Drawing.Point(35, 365);
            this.genre_textBox.Name = "genre_textBox";
            this.genre_textBox.Size = new System.Drawing.Size(553, 56);
            this.genre_textBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(35, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 50);
            this.label1.TabIndex = 35;
            this.label1.Text = "Genre";
            // 
            // authorName_textBox
            // 
            this.authorName_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorName_textBox.Location = new System.Drawing.Point(35, 228);
            this.authorName_textBox.Name = "authorName_textBox";
            this.authorName_textBox.Size = new System.Drawing.Size(743, 56);
            this.authorName_textBox.TabIndex = 34;
            // 
            // authorName_label
            // 
            this.authorName_label.AutoSize = true;
            this.authorName_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.authorName_label.Location = new System.Drawing.Point(35, 175);
            this.authorName_label.Name = "authorName_label";
            this.authorName_label.Size = new System.Drawing.Size(237, 50);
            this.authorName_label.TabIndex = 33;
            this.authorName_label.Text = "Author name";
            // 
            // title_textBox
            // 
            this.title_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_textBox.Location = new System.Drawing.Point(35, 100);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(743, 56);
            this.title_textBox.TabIndex = 32;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.title_label.Location = new System.Drawing.Point(35, 47);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(91, 50);
            this.title_label.TabIndex = 31;
            this.title_label.Text = "Title";
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(35, 489);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textBox.Size = new System.Drawing.Size(743, 284);
            this.description_textBox.TabIndex = 29;
            // 
            // updateBook_btn
            // 
            this.updateBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.updateBook_btn.FlatAppearance.BorderSize = 0;
            this.updateBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBook_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBook_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBook_btn.Location = new System.Drawing.Point(238, 779);
            this.updateBook_btn.Name = "updateBook_btn";
            this.updateBook_btn.Size = new System.Drawing.Size(319, 119);
            this.updateBook_btn.TabIndex = 28;
            this.updateBook_btn.Text = "Update Book";
            this.updateBook_btn.UseVisualStyleBackColor = false;
            this.updateBook_btn.Click += new System.EventHandler(this.updateBook_btn_Click);
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_textBox.Location = new System.Drawing.Point(614, 365);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(164, 56);
            this.quantity_textBox.TabIndex = 39;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.quantity_label.Location = new System.Drawing.Point(614, 312);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(164, 50);
            this.quantity_label.TabIndex = 38;
            this.quantity_label.Text = "Quantity";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 920);
            this.Controls.Add(this.quantity_textBox);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.genre_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorName_textBox);
            this.Controls.Add(this.authorName_label);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.updateBook_btn);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox genre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorName_textBox;
        private System.Windows.Forms.Label authorName_label;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.Button updateBook_btn;
        private System.Windows.Forms.TextBox quantity_textBox;
        private System.Windows.Forms.Label quantity_label;
    }
}