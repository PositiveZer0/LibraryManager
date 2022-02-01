namespace LibraryManager.Forms.Client
{

    partial class Main
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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.profile_btn = new System.Windows.Forms.Button();
            this.borrowed_books_btn = new System.Windows.Forms.Button();
            this.available_btn = new System.Windows.Forms.Button();
            this.all_btn = new System.Windows.Forms.Button();
            this.books_btn = new System.Windows.Forms.Button();
            this.menu_label = new System.Windows.Forms.Label();
            this.books_panel = new System.Windows.Forms.Panel();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.description_label = new System.Windows.Forms.Label();
            this.form_panel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.logo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.menu_panel.Controls.Add(this.profile_btn);
            this.menu_panel.Controls.Add(this.borrowed_books_btn);
            this.menu_panel.Controls.Add(this.available_btn);
            this.menu_panel.Controls.Add(this.all_btn);
            this.menu_panel.Controls.Add(this.books_btn);
            this.menu_panel.Controls.Add(this.menu_label);
            this.menu_panel.Controls.Add(this.books_panel);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(408, 1262);
            this.menu_panel.TabIndex = 2;
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.profile_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_btn.FlatAppearance.BorderSize = 0;
            this.profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profile_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profile_btn.Location = new System.Drawing.Point(0, 460);
            this.profile_btn.Margin = new System.Windows.Forms.Padding(0);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profile_btn.Size = new System.Drawing.Size(408, 100);
            this.profile_btn.TabIndex = 10;
            this.profile_btn.TabStop = false;
            this.profile_btn.Text = "Profile";
            this.profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // borrowed_books_btn
            // 
            this.borrowed_books_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.borrowed_books_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowed_books_btn.FlatAppearance.BorderSize = 0;
            this.borrowed_books_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowed_books_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowed_books_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrowed_books_btn.Location = new System.Drawing.Point(0, 360);
            this.borrowed_books_btn.Margin = new System.Windows.Forms.Padding(0);
            this.borrowed_books_btn.Name = "borrowed_books_btn";
            this.borrowed_books_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.borrowed_books_btn.Size = new System.Drawing.Size(408, 100);
            this.borrowed_books_btn.TabIndex = 8;
            this.borrowed_books_btn.TabStop = false;
            this.borrowed_books_btn.Text = "Borrowed books";
            this.borrowed_books_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowed_books_btn.UseVisualStyleBackColor = false;
            this.borrowed_books_btn.Click += new System.EventHandler(this.borrowed_books_btn_Click);
            // 
            // available_btn
            // 
            this.available_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.available_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.available_btn.FlatAppearance.BorderSize = 0;
            this.available_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.available_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.available_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.available_btn.Location = new System.Drawing.Point(0, 280);
            this.available_btn.Margin = new System.Windows.Forms.Padding(0);
            this.available_btn.Name = "available_btn";
            this.available_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.available_btn.Size = new System.Drawing.Size(408, 80);
            this.available_btn.TabIndex = 9;
            this.available_btn.TabStop = false;
            this.available_btn.Text = "Available";
            this.available_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.available_btn.UseVisualStyleBackColor = false;
            this.available_btn.Click += new System.EventHandler(this.available_btn_Click);
            // 
            // all_btn
            // 
            this.all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.all_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.all_btn.FlatAppearance.BorderSize = 0;
            this.all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.all_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.all_btn.Location = new System.Drawing.Point(0, 200);
            this.all_btn.Margin = new System.Windows.Forms.Padding(0);
            this.all_btn.Name = "all_btn";
            this.all_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.all_btn.Size = new System.Drawing.Size(408, 80);
            this.all_btn.TabIndex = 7;
            this.all_btn.TabStop = false;
            this.all_btn.Text = "All";
            this.all_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.all_btn.UseVisualStyleBackColor = false;
            this.all_btn.Click += new System.EventHandler(this.all_btn_Click);
            // 
            // books_btn
            // 
            this.books_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.books_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.books_btn.FlatAppearance.BorderSize = 0;
            this.books_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.books_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.books_btn.Location = new System.Drawing.Point(0, 100);
            this.books_btn.Margin = new System.Windows.Forms.Padding(0);
            this.books_btn.Name = "books_btn";
            this.books_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.books_btn.Size = new System.Drawing.Size(408, 100);
            this.books_btn.TabIndex = 6;
            this.books_btn.TabStop = false;
            this.books_btn.Text = "Books";
            this.books_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.books_btn.UseVisualStyleBackColor = false;
            this.books_btn.Click += new System.EventHandler(this.books_btn_Click);
            // 
            // menu_label
            // 
            this.menu_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_label.Location = new System.Drawing.Point(0, 0);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(408, 100);
            this.menu_label.TabIndex = 0;
            this.menu_label.Text = "Menu";
            this.menu_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // books_panel
            // 
            this.books_panel.AutoSize = true;
            this.books_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.books_panel.Location = new System.Drawing.Point(0, 0);
            this.books_panel.Name = "books_panel";
            this.books_panel.Size = new System.Drawing.Size(408, 0);
            this.books_panel.TabIndex = 3;
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.logo_panel.Controls.Add(this.description_label);
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(408, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(1560, 100);
            this.logo_panel.TabIndex = 3;
            // 
            // description_label
            // 
            this.description_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description_label.AutoSize = true;
            this.description_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.description_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_label.Location = new System.Drawing.Point(681, 14);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(232, 67);
            this.description_label.TabIndex = 0;
            this.description_label.Text = "All Books";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_panel
            // 
            this.form_panel.AutoSize = true;
            this.form_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_panel.Location = new System.Drawing.Point(408, 100);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(1560, 1162);
            this.form_panel.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1262);
            this.Controls.Add(this.form_panel);
            this.Controls.Add(this.logo_panel);
            this.Controls.Add(this.menu_panel);
            this.Name = "Main";
            this.Text = "Main";
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Panel books_panel;
        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button borrowed_books_btn;
        private System.Windows.Forms.Button available_btn;
        private System.Windows.Forms.Button all_btn;
        private System.Windows.Forms.Button books_btn;
        private System.Windows.Forms.Label description_label;
    }
}