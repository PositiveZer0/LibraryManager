namespace LibraryManager
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_wrapper = new System.Windows.Forms.Panel();
            this.create_account_btn = new System.Windows.Forms.Button();
            this.forgotten_psw_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_wrapper = new System.Windows.Forms.Panel();
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_pic = new System.Windows.Forms.PictureBox();
            this.username_wrapper = new System.Windows.Forms.Panel();
            this.username_box = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.login_wrapper.SuspendLayout();
            this.password_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_pic)).BeginInit();
            this.username_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 1200);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(343, 830);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Managment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(131, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManager.Properties.Resources.photo_1568667256549_094345857637;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_wrapper
            // 
            this.login_wrapper.BackColor = System.Drawing.SystemColors.Control;
            this.login_wrapper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_wrapper.Controls.Add(this.create_account_btn);
            this.login_wrapper.Controls.Add(this.forgotten_psw_btn);
            this.login_wrapper.Controls.Add(this.login_btn);
            this.login_wrapper.Controls.Add(this.password_wrapper);
            this.login_wrapper.Controls.Add(this.username_wrapper);
            this.login_wrapper.Controls.Add(this.login_label);
            this.login_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_wrapper.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_wrapper.Location = new System.Drawing.Point(541, 0);
            this.login_wrapper.Name = "login_wrapper";
            this.login_wrapper.Size = new System.Drawing.Size(1060, 1200);
            this.login_wrapper.TabIndex = 1;
            // 
            // create_account_btn
            // 
            this.create_account_btn.BackColor = System.Drawing.SystemColors.Control;
            this.create_account_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.create_account_btn.FlatAppearance.BorderSize = 0;
            this.create_account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_account_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_account_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.create_account_btn.Location = new System.Drawing.Point(702, 1069);
            this.create_account_btn.Name = "create_account_btn";
            this.create_account_btn.Size = new System.Drawing.Size(306, 100);
            this.create_account_btn.TabIndex = 7;
            this.create_account_btn.Text = "Create account";
            this.create_account_btn.UseVisualStyleBackColor = false;
            this.create_account_btn.Click += new System.EventHandler(this.create_account_btn_Click);
            // 
            // forgotten_psw_btn
            // 
            this.forgotten_psw_btn.BackColor = System.Drawing.SystemColors.Control;
            this.forgotten_psw_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.forgotten_psw_btn.FlatAppearance.BorderSize = 0;
            this.forgotten_psw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotten_psw_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotten_psw_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.forgotten_psw_btn.Location = new System.Drawing.Point(544, 736);
            this.forgotten_psw_btn.Name = "forgotten_psw_btn";
            this.forgotten_psw_btn.Size = new System.Drawing.Size(306, 100);
            this.forgotten_psw_btn.TabIndex = 6;
            this.forgotten_psw_btn.Text = "Forgotten password";
            this.forgotten_psw_btn.UseVisualStyleBackColor = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(183, 736);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(306, 100);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // password_wrapper
            // 
            this.password_wrapper.BackColor = System.Drawing.SystemColors.Control;
            this.password_wrapper.Controls.Add(this.password_box);
            this.password_wrapper.Controls.Add(this.password_pic);
            this.password_wrapper.Location = new System.Drawing.Point(4, 570);
            this.password_wrapper.Name = "password_wrapper";
            this.password_wrapper.Size = new System.Drawing.Size(1053, 86);
            this.password_wrapper.TabIndex = 4;
            // 
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.SystemColors.Control;
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.password_box.Location = new System.Drawing.Point(118, 25);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(905, 58);
            this.password_box.TabIndex = 7;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.Click += new System.EventHandler(this.password_box_Click);
            // 
            // password_pic
            // 
            this.password_pic.Image = global::LibraryManager.Properties.Resources._2838601;
            this.password_pic.Location = new System.Drawing.Point(-18, 3);
            this.password_pic.Name = "password_pic";
            this.password_pic.Size = new System.Drawing.Size(130, 80);
            this.password_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password_pic.TabIndex = 6;
            this.password_pic.TabStop = false;
            this.password_pic.Click += new System.EventHandler(this.password_pic_Click);
            // 
            // username_wrapper
            // 
            this.username_wrapper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_wrapper.Controls.Add(this.username_box);
            this.username_wrapper.Controls.Add(this.pictureBox2);
            this.username_wrapper.Location = new System.Drawing.Point(4, 439);
            this.username_wrapper.Name = "username_wrapper";
            this.username_wrapper.Size = new System.Drawing.Size(1053, 86);
            this.username_wrapper.TabIndex = 3;
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.username_box.Location = new System.Drawing.Point(118, 25);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(905, 58);
            this.username_box.TabIndex = 6;
            this.username_box.Click += new System.EventHandler(this.username_box_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManager.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.login_label.Location = new System.Drawing.Point(48, 262);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(675, 74);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login to your account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1200);
            this.Controls.Add(this.login_wrapper);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.login_wrapper.ResumeLayout(false);
            this.login_wrapper.PerformLayout();
            this.password_wrapper.ResumeLayout(false);
            this.password_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_pic)).EndInit();
            this.username_wrapper.ResumeLayout(false);
            this.username_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel login_wrapper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Panel password_wrapper;
        private System.Windows.Forms.Panel username_wrapper;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox password_pic;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Button forgotten_psw_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button create_account_btn;
    }
}

