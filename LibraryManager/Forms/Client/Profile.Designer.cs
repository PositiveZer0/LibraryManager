namespace LibraryManager.Forms.Client
{

    partial class Profile
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
            this.changePsw_btn = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.email_box = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.username_wrapper = new System.Windows.Forms.Panel();
            this.name_box = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editPhoto_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.username_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changePsw_btn
            // 
            this.changePsw_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.changePsw_btn.FlatAppearance.BorderSize = 0;
            this.changePsw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePsw_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePsw_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePsw_btn.Location = new System.Drawing.Point(631, 814);
            this.changePsw_btn.Name = "changePsw_btn";
            this.changePsw_btn.Size = new System.Drawing.Size(306, 126);
            this.changePsw_btn.TabIndex = 12;
            this.changePsw_btn.Text = "Change Password";
            this.changePsw_btn.UseVisualStyleBackColor = false;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.email_label.Location = new System.Drawing.Point(456, 433);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(88, 41);
            this.email_label.TabIndex = 19;
            this.email_label.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(456, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(463, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.email_box);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(463, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 86);
            this.panel3.TabIndex = 16;
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_box.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.email_box.Location = new System.Drawing.Point(113, 25);
            this.email_box.Name = "email_box";
            this.email_box.ReadOnly = true;
            this.email_box.Size = new System.Drawing.Size(921, 45);
            this.email_box.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryManager.Properties.Resources.email;
            this.pictureBox4.Location = new System.Drawing.Point(-18, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.surname_box);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(463, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 86);
            this.panel2.TabIndex = 15;
            // 
            // surname_box
            // 
            this.surname_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surname_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.surname_box.Location = new System.Drawing.Point(113, 25);
            this.surname_box.Name = "surname_box";
            this.surname_box.ReadOnly = true;
            this.surname_box.Size = new System.Drawing.Size(921, 58);
            this.surname_box.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryManager.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(-18, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // username_wrapper
            // 
            this.username_wrapper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_wrapper.Controls.Add(this.name_box);
            this.username_wrapper.Controls.Add(this.pictureBox2);
            this.username_wrapper.Location = new System.Drawing.Point(463, 149);
            this.username_wrapper.Name = "username_wrapper";
            this.username_wrapper.Size = new System.Drawing.Size(1040, 86);
            this.username_wrapper.TabIndex = 14;
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.name_box.Location = new System.Drawing.Point(118, 28);
            this.name_box.Name = "name_box";
            this.name_box.ReadOnly = true;
            this.name_box.Size = new System.Drawing.Size(919, 58);
            this.name_box.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManager.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManager.Properties.Resources.defaultProfilePIcture2;
            this.pictureBox1.Location = new System.Drawing.Point(30, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // editPhoto_btn
            // 
            this.editPhoto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.editPhoto_btn.FlatAppearance.BorderSize = 0;
            this.editPhoto_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPhoto_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPhoto_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editPhoto_btn.Location = new System.Drawing.Point(30, 456);
            this.editPhoto_btn.Name = "editPhoto_btn";
            this.editPhoto_btn.Size = new System.Drawing.Size(291, 126);
            this.editPhoto_btn.TabIndex = 21;
            this.editPhoto_btn.Text = "Edit Photo";
            this.editPhoto_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1104, 848);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 126);
            this.button1.TabIndex = 22;
            this.button1.Text = "add book test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.logOut_btn.FlatAppearance.BorderSize = 0;
            this.logOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOut_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOut_btn.Location = new System.Drawing.Point(70, 895);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(306, 126);
            this.logOut_btn.TabIndex = 23;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1162);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editPhoto_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.username_wrapper);
            this.Controls.Add(this.changePsw_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.ShowInTaskbar = false;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.username_wrapper.ResumeLayout(false);
            this.username_wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changePsw_btn;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel username_wrapper;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editPhoto_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logOut_btn;
    }
}