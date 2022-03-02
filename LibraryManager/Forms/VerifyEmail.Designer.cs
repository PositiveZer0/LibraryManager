﻿namespace LibraryManager.Forms
{

    partial class VerifyEmail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verifyEmail_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.email_box = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.email_label = new System.Windows.Forms.Label();
            this.verificationCode_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.code_box = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.verify_btn = new System.Windows.Forms.Button();
            this.resendCode_btn = new System.Windows.Forms.Button();
            this.wrongCode_textbox = new System.Windows.Forms.TextBox();
            this.back_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(541, 1212);
            this.panel1.TabIndex = 2;
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
            // verifyEmail_label
            // 
            this.verifyEmail_label.AutoSize = true;
            this.verifyEmail_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verifyEmail_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.verifyEmail_label.Location = new System.Drawing.Point(882, 236);
            this.verifyEmail_label.Name = "verifyEmail_label";
            this.verifyEmail_label.Size = new System.Drawing.Size(365, 74);
            this.verifyEmail_label.TabIndex = 3;
            this.verifyEmail_label.Text = "Verify Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.email_box);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(547, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 86);
            this.panel3.TabIndex = 9;
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.email_box.Location = new System.Drawing.Point(115, 25);
            this.email_box.Name = "email_box";
            this.email_box.ReadOnly = true;
            this.email_box.Size = new System.Drawing.Size(952, 58);
            this.email_box.TabIndex = 0;
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
            // email_label
            // 
            this.email_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.email_label.Location = new System.Drawing.Point(547, 411);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(127, 49);
            this.email_label.TabIndex = 13;
            this.email_label.Text = "Email";
            // 
            // verificationCode_label
            // 
            this.verificationCode_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verificationCode_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.verificationCode_label.Location = new System.Drawing.Point(547, 620);
            this.verificationCode_label.Name = "verificationCode_label";
            this.verificationCode_label.Size = new System.Drawing.Size(493, 49);
            this.verificationCode_label.TabIndex = 14;
            this.verificationCode_label.Text = "6 digit code verification";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.code_box);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(547, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 86);
            this.panel2.TabIndex = 15;
            // 
            // code_box
            // 
            this.code_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.code_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code_box.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.code_box.Location = new System.Drawing.Point(115, 25);
            this.code_box.Name = "code_box";
            this.code_box.Size = new System.Drawing.Size(952, 58);
            this.code_box.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManager.Properties.Resources.verificationEmail;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // verify_btn
            // 
            this.verify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.verify_btn.FlatAppearance.BorderSize = 0;
            this.verify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verify_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verify_btn.Location = new System.Drawing.Point(721, 900);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.Size = new System.Drawing.Size(319, 119);
            this.verify_btn.TabIndex = 16;
            this.verify_btn.Text = "Verify Email";
            this.verify_btn.UseVisualStyleBackColor = false;
            this.verify_btn.Click += new System.EventHandler(this.verify_btn_Click);
            // 
            // resendCode_btn
            // 
            this.resendCode_btn.BackColor = System.Drawing.SystemColors.Control;
            this.resendCode_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.resendCode_btn.FlatAppearance.BorderSize = 0;
            this.resendCode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resendCode_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resendCode_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.resendCode_btn.Location = new System.Drawing.Point(1143, 900);
            this.resendCode_btn.Name = "resendCode_btn";
            this.resendCode_btn.Size = new System.Drawing.Size(319, 119);
            this.resendCode_btn.TabIndex = 17;
            this.resendCode_btn.Text = "Resend code";
            this.resendCode_btn.UseVisualStyleBackColor = false;
            this.resendCode_btn.Click += new System.EventHandler(this.resendCode_btn_Click);
            // 
            // wrongCode_textbox
            // 
            this.wrongCode_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wrongCode_textbox.Font = new System.Drawing.Font("Century Gothic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wrongCode_textbox.ForeColor = System.Drawing.Color.Red;
            this.wrongCode_textbox.Location = new System.Drawing.Point(541, 795);
            this.wrongCode_textbox.Multiline = true;
            this.wrongCode_textbox.Name = "wrongCode_textbox";
            this.wrongCode_textbox.ReadOnly = true;
            this.wrongCode_textbox.Size = new System.Drawing.Size(1076, 63);
            this.wrongCode_textbox.TabIndex = 18;
            this.wrongCode_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wrongCode_textbox.Visible = false;
            // 
            // back_pictureBox
            // 
            this.back_pictureBox.Image = global::LibraryManager.Properties.Resources.back;
            this.back_pictureBox.Location = new System.Drawing.Point(541, 0);
            this.back_pictureBox.Name = "back_pictureBox";
            this.back_pictureBox.Size = new System.Drawing.Size(118, 67);
            this.back_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pictureBox.TabIndex = 20;
            this.back_pictureBox.TabStop = false;
            this.back_pictureBox.Click += new System.EventHandler(this.back_pictureBox_Click);
            // 
            // VerifyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1212);
            this.Controls.Add(this.back_pictureBox);
            this.Controls.Add(this.wrongCode_textbox);
            this.Controls.Add(this.resendCode_btn);
            this.Controls.Add(this.verify_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.verificationCode_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.verifyEmail_label);
            this.Controls.Add(this.panel1);
            this.Name = "VerifyEmail";
            this.Text = "VerifyEmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label verifyEmail_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label verificationCode_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox code_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button verify_btn;
        private System.Windows.Forms.Button resendCode_btn;
        private System.Windows.Forms.TextBox wrongCode_textbox;
        private System.Windows.Forms.PictureBox back_pictureBox;
    }
}