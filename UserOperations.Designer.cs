namespace TechnicalService
{
    partial class UserOperations
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
            this.users_Password = new System.Windows.Forms.TextBox();
            this.users_Password2 = new System.Windows.Forms.TextBox();
            this.users_Update = new System.Windows.Forms.Button();
            this.users_OldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // users_Password
            // 
            this.users_Password.Location = new System.Drawing.Point(12, 64);
            this.users_Password.MaxLength = 16;
            this.users_Password.Name = "users_Password";
            this.users_Password.Size = new System.Drawing.Size(193, 20);
            this.users_Password.TabIndex = 1;
            this.users_Password.UseSystemPasswordChar = true;
            // 
            // users_Password2
            // 
            this.users_Password2.Location = new System.Drawing.Point(12, 103);
            this.users_Password2.MaxLength = 16;
            this.users_Password2.Name = "users_Password2";
            this.users_Password2.Size = new System.Drawing.Size(193, 20);
            this.users_Password2.TabIndex = 2;
            this.users_Password2.UseSystemPasswordChar = true;
            // 
            // users_Update
            // 
            this.users_Update.Location = new System.Drawing.Point(12, 135);
            this.users_Update.Name = "users_Update";
            this.users_Update.Size = new System.Drawing.Size(193, 23);
            this.users_Update.TabIndex = 3;
            this.users_Update.Text = "Update";
            this.users_Update.UseVisualStyleBackColor = true;
            this.users_Update.Click += new System.EventHandler(this.users_Update_Click);
            // 
            // users_OldPassword
            // 
            this.users_OldPassword.Location = new System.Drawing.Point(12, 25);
            this.users_OldPassword.MaxLength = 16;
            this.users_OldPassword.Name = "users_OldPassword";
            this.users_OldPassword.Size = new System.Drawing.Size(193, 20);
            this.users_OldPassword.TabIndex = 0;
            this.users_OldPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(219, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.users_OldPassword);
            this.Controls.Add(this.users_Update);
            this.Controls.Add(this.users_Password2);
            this.Controls.Add(this.users_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "User Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox users_Password;
        private System.Windows.Forms.TextBox users_Password2;
        private System.Windows.Forms.Button users_Update;
        private System.Windows.Forms.TextBox users_OldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}