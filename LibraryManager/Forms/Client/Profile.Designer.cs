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
            this.button1 = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.changePsw_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.name_label.Location = new System.Drawing.Point(189, 45);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(141, 60);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "Name";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.surname_label.Location = new System.Drawing.Point(189, 233);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(196, 60);
            this.surname_label.TabIndex = 11;
            this.surname_label.Text = "Surname";
            // 
            // changePsw_btn
            // 
            this.changePsw_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.changePsw_btn.FlatAppearance.BorderSize = 0;
            this.changePsw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePsw_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePsw_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePsw_btn.Location = new System.Drawing.Point(239, 450);
            this.changePsw_btn.Name = "changePsw_btn";
            this.changePsw_btn.Size = new System.Drawing.Size(306, 126);
            this.changePsw_btn.TabIndex = 12;
            this.changePsw_btn.Text = "Change Password";
            this.changePsw_btn.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 1024);
            this.Controls.Add(this.changePsw_btn);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.ShowInTaskbar = false;
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Button changePsw_btn;
    }
}