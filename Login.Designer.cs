namespace TechnicalService
{
    partial class Login
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
            this.login_UserName = new System.Windows.Forms.TextBox();
            this.login_Password = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_UserName
            // 
            this.login_UserName.Location = new System.Drawing.Point(12, 25);
            this.login_UserName.MaxLength = 16;
            this.login_UserName.Name = "login_UserName";
            this.login_UserName.Size = new System.Drawing.Size(194, 20);
            this.login_UserName.TabIndex = 0;
            this.login_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_UserName_KeyDown);
            // 
            // login_Password
            // 
            this.login_Password.Location = new System.Drawing.Point(12, 64);
            this.login_Password.MaxLength = 16;
            this.login_Password.Name = "login_Password";
            this.login_Password.Size = new System.Drawing.Size(194, 20);
            this.login_Password.TabIndex = 1;
            this.login_Password.UseSystemPasswordChar = true;
            this.login_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_Password_KeyDown);
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(12, 96);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(194, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Log in";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(220, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_UserName);
            this.Controls.Add(this.login_Password);
            this.Controls.Add(this.login_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.TextBox login_Password;
        private System.Windows.Forms.TextBox login_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

