namespace LibraryManager.Forms.Client
{
    partial class ChangePassword
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
            this.changePassword_label = new System.Windows.Forms.Label();
            this.errors_textbox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.confirmNewPsw_box = new System.Windows.Forms.TextBox();
            this.confirm_psw_pic = new System.Windows.Forms.PictureBox();
            this.confirmNewPsw_label = new System.Windows.Forms.Label();
            this.password_wrapper = new System.Windows.Forms.Panel();
            this.newPassword_box = new System.Windows.Forms.TextBox();
            this.password_pic = new System.Windows.Forms.PictureBox();
            this.newPassword_label = new System.Windows.Forms.Label();
            this.changePassword_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oldPassword_box = new System.Windows.Forms.TextBox();
            this.oldPassword_pic = new System.Windows.Forms.PictureBox();
            this.oldPassword_label = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_psw_pic)).BeginInit();
            this.password_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_pic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassword_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // changePassword_label
            // 
            this.changePassword_label.AutoSize = true;
            this.changePassword_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.changePassword_label.Location = new System.Drawing.Point(222, 18);
            this.changePassword_label.Name = "changePassword_label";
            this.changePassword_label.Size = new System.Drawing.Size(563, 74);
            this.changePassword_label.TabIndex = 37;
            this.changePassword_label.Text = "Change Password";
            // 
            // errors_textbox
            // 
            this.errors_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errors_textbox.Font = new System.Drawing.Font("Century Gothic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errors_textbox.ForeColor = System.Drawing.Color.Red;
            this.errors_textbox.Location = new System.Drawing.Point(3, 689);
            this.errors_textbox.Multiline = true;
            this.errors_textbox.Name = "errors_textbox";
            this.errors_textbox.ReadOnly = true;
            this.errors_textbox.Size = new System.Drawing.Size(1076, 126);
            this.errors_textbox.TabIndex = 36;
            this.errors_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errors_textbox.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.confirmNewPsw_box);
            this.panel4.Controls.Add(this.confirm_psw_pic);
            this.panel4.Location = new System.Drawing.Point(6, 543);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1073, 86);
            this.panel4.TabIndex = 32;
            // 
            // confirmNewPsw_box
            // 
            this.confirmNewPsw_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmNewPsw_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmNewPsw_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmNewPsw_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.confirmNewPsw_box.Location = new System.Drawing.Point(119, 25);
            this.confirmNewPsw_box.Name = "confirmNewPsw_box";
            this.confirmNewPsw_box.Size = new System.Drawing.Size(946, 58);
            this.confirmNewPsw_box.TabIndex = 3;
            this.confirmNewPsw_box.UseSystemPasswordChar = true;
            // 
            // confirm_psw_pic
            // 
            this.confirm_psw_pic.Image = global::LibraryManager.Properties.Resources._2838601;
            this.confirm_psw_pic.Location = new System.Drawing.Point(-18, 3);
            this.confirm_psw_pic.Name = "confirm_psw_pic";
            this.confirm_psw_pic.Size = new System.Drawing.Size(130, 80);
            this.confirm_psw_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confirm_psw_pic.TabIndex = 6;
            this.confirm_psw_pic.TabStop = false;
            this.confirm_psw_pic.Click += new System.EventHandler(this.confirm_psw_pic_Click);
            // 
            // confirmNewPsw_label
            // 
            this.confirmNewPsw_label.AutoSize = true;
            this.confirmNewPsw_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmNewPsw_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.confirmNewPsw_label.Location = new System.Drawing.Point(3, 491);
            this.confirmNewPsw_label.Name = "confirmNewPsw_label";
            this.confirmNewPsw_label.Size = new System.Drawing.Size(371, 49);
            this.confirmNewPsw_label.TabIndex = 31;
            this.confirmNewPsw_label.Text = "Confirm Password";
            // 
            // password_wrapper
            // 
            this.password_wrapper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_wrapper.Controls.Add(this.newPassword_box);
            this.password_wrapper.Controls.Add(this.password_pic);
            this.password_wrapper.Location = new System.Drawing.Point(3, 368);
            this.password_wrapper.Name = "password_wrapper";
            this.password_wrapper.Size = new System.Drawing.Size(1070, 86);
            this.password_wrapper.TabIndex = 30;
            // 
            // newPassword_box
            // 
            this.newPassword_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newPassword_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassword_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.newPassword_box.Location = new System.Drawing.Point(119, 25);
            this.newPassword_box.Name = "newPassword_box";
            this.newPassword_box.Size = new System.Drawing.Size(948, 58);
            this.newPassword_box.TabIndex = 2;
            this.newPassword_box.UseSystemPasswordChar = true;
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
            // newPassword_label
            // 
            this.newPassword_label.AutoSize = true;
            this.newPassword_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.newPassword_label.Location = new System.Drawing.Point(3, 316);
            this.newPassword_label.Name = "newPassword_label";
            this.newPassword_label.Size = new System.Drawing.Size(305, 49);
            this.newPassword_label.TabIndex = 29;
            this.newPassword_label.Text = "New Password";
            // 
            // changePassword_btn
            // 
            this.changePassword_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.changePassword_btn.FlatAppearance.BorderSize = 0;
            this.changePassword_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassword_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePassword_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePassword_btn.Location = new System.Drawing.Point(399, 838);
            this.changePassword_btn.Name = "changePassword_btn";
            this.changePassword_btn.Size = new System.Drawing.Size(319, 119);
            this.changePassword_btn.TabIndex = 5;
            this.changePassword_btn.Text = "Change password";
            this.changePassword_btn.UseVisualStyleBackColor = false;
            this.changePassword_btn.Click += new System.EventHandler(this.changePassword_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.oldPassword_box);
            this.panel1.Controls.Add(this.oldPassword_pic);
            this.panel1.Location = new System.Drawing.Point(6, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 86);
            this.panel1.TabIndex = 43;
            // 
            // oldPassword_box
            // 
            this.oldPassword_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldPassword_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPassword_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassword_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.oldPassword_box.Location = new System.Drawing.Point(119, 25);
            this.oldPassword_box.Name = "oldPassword_box";
            this.oldPassword_box.Size = new System.Drawing.Size(946, 58);
            this.oldPassword_box.TabIndex = 1;
            this.oldPassword_box.UseSystemPasswordChar = true;
            // 
            // oldPassword_pic
            // 
            this.oldPassword_pic.Image = global::LibraryManager.Properties.Resources._2838601;
            this.oldPassword_pic.Location = new System.Drawing.Point(-18, 3);
            this.oldPassword_pic.Name = "oldPassword_pic";
            this.oldPassword_pic.Size = new System.Drawing.Size(130, 80);
            this.oldPassword_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oldPassword_pic.TabIndex = 6;
            this.oldPassword_pic.TabStop = false;
            this.oldPassword_pic.Click += new System.EventHandler(this.oldPassword_pic_Click);
            // 
            // oldPassword_label
            // 
            this.oldPassword_label.AutoSize = true;
            this.oldPassword_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.oldPassword_label.Location = new System.Drawing.Point(3, 135);
            this.oldPassword_label.Name = "oldPassword_label";
            this.oldPassword_label.Size = new System.Drawing.Size(286, 49);
            this.oldPassword_label.TabIndex = 42;
            this.oldPassword_label.Text = "Old Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 979);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.oldPassword_label);
            this.Controls.Add(this.changePassword_btn);
            this.Controls.Add(this.changePassword_label);
            this.Controls.Add(this.errors_textbox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.confirmNewPsw_label);
            this.Controls.Add(this.password_wrapper);
            this.Controls.Add(this.newPassword_label);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_psw_pic)).EndInit();
            this.password_wrapper.ResumeLayout(false);
            this.password_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassword_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label changePassword_label;
        private System.Windows.Forms.TextBox errors_textbox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox confirmNewPsw_box;
        private System.Windows.Forms.PictureBox confirm_psw_pic;
        private System.Windows.Forms.Label confirmNewPsw_label;
        private System.Windows.Forms.Panel password_wrapper;
        private System.Windows.Forms.TextBox newPassword_box;
        private System.Windows.Forms.PictureBox password_pic;
        private System.Windows.Forms.Label newPassword_label;
        private System.Windows.Forms.Button changePassword_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox oldPassword_box;
        private System.Windows.Forms.PictureBox oldPassword_pic;
        private System.Windows.Forms.Label oldPassword_label;
    }
}