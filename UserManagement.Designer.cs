namespace TechnicalService
{
    partial class UserManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mUsers_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mUsers_DataGridView = new System.Windows.Forms.DataGridView();
            this.mUsers_Delete = new System.Windows.Forms.Button();
            this.mUsers_UserName = new System.Windows.Forms.TextBox();
            this.mUsers_Update = new System.Windows.Forms.Button();
            this.mUsers_Password = new System.Windows.Forms.TextBox();
            this.mUsers_Add = new System.Windows.Forms.Button();
            this.mUsers_Password2 = new System.Windows.Forms.TextBox();
            this.mUsers_Passive = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mUsers_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mUsers_Clear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mUsers_DataGridView);
            this.groupBox1.Controls.Add(this.mUsers_Delete);
            this.groupBox1.Controls.Add(this.mUsers_UserName);
            this.groupBox1.Controls.Add(this.mUsers_Update);
            this.groupBox1.Controls.Add(this.mUsers_Password);
            this.groupBox1.Controls.Add(this.mUsers_Add);
            this.groupBox1.Controls.Add(this.mUsers_Password2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Management";
            // 
            // mUsers_Clear
            // 
            this.mUsers_Clear.Location = new System.Drawing.Point(6, 202);
            this.mUsers_Clear.Name = "mUsers_Clear";
            this.mUsers_Clear.Size = new System.Drawing.Size(193, 23);
            this.mUsers_Clear.TabIndex = 11;
            this.mUsers_Clear.Text = "Clear Form";
            this.mUsers_Clear.UseVisualStyleBackColor = true;
            this.mUsers_Clear.Click += new System.EventHandler(this.mUsers_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // mUsers_DataGridView
            // 
            this.mUsers_DataGridView.AllowUserToAddRows = false;
            this.mUsers_DataGridView.AllowUserToDeleteRows = false;
            this.mUsers_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.mUsers_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mUsers_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mUsers_DataGridView.Location = new System.Drawing.Point(216, 35);
            this.mUsers_DataGridView.MultiSelect = false;
            this.mUsers_DataGridView.Name = "mUsers_DataGridView";
            this.mUsers_DataGridView.RowHeadersVisible = false;
            this.mUsers_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mUsers_DataGridView.Size = new System.Drawing.Size(258, 190);
            this.mUsers_DataGridView.TabIndex = 7;
            this.mUsers_DataGridView.SelectionChanged += new System.EventHandler(this.mUsers_DataGridView_SelectionChanged);
            // 
            // mUsers_Delete
            // 
            this.mUsers_Delete.Location = new System.Drawing.Point(104, 173);
            this.mUsers_Delete.Name = "mUsers_Delete";
            this.mUsers_Delete.Size = new System.Drawing.Size(95, 23);
            this.mUsers_Delete.TabIndex = 6;
            this.mUsers_Delete.Text = "Delete";
            this.mUsers_Delete.UseVisualStyleBackColor = true;
            this.mUsers_Delete.Click += new System.EventHandler(this.mUsers_Delete_Click);
            // 
            // mUsers_UserName
            // 
            this.mUsers_UserName.Location = new System.Drawing.Point(6, 35);
            this.mUsers_UserName.MaxLength = 16;
            this.mUsers_UserName.Name = "mUsers_UserName";
            this.mUsers_UserName.Size = new System.Drawing.Size(193, 20);
            this.mUsers_UserName.TabIndex = 0;
            // 
            // mUsers_Update
            // 
            this.mUsers_Update.Location = new System.Drawing.Point(104, 144);
            this.mUsers_Update.Name = "mUsers_Update";
            this.mUsers_Update.Size = new System.Drawing.Size(95, 23);
            this.mUsers_Update.TabIndex = 4;
            this.mUsers_Update.Text = "Update";
            this.mUsers_Update.UseVisualStyleBackColor = true;
            this.mUsers_Update.Click += new System.EventHandler(this.mUsers_Update_Click);
            // 
            // mUsers_Password
            // 
            this.mUsers_Password.Location = new System.Drawing.Point(6, 74);
            this.mUsers_Password.MaxLength = 16;
            this.mUsers_Password.Name = "mUsers_Password";
            this.mUsers_Password.Size = new System.Drawing.Size(193, 20);
            this.mUsers_Password.TabIndex = 1;
            this.mUsers_Password.UseSystemPasswordChar = true;
            // 
            // mUsers_Add
            // 
            this.mUsers_Add.Location = new System.Drawing.Point(6, 144);
            this.mUsers_Add.Name = "mUsers_Add";
            this.mUsers_Add.Size = new System.Drawing.Size(95, 23);
            this.mUsers_Add.TabIndex = 3;
            this.mUsers_Add.Text = "Add";
            this.mUsers_Add.UseVisualStyleBackColor = true;
            this.mUsers_Add.Click += new System.EventHandler(this.mUsers_Add_Click);
            // 
            // mUsers_Password2
            // 
            this.mUsers_Password2.Location = new System.Drawing.Point(6, 113);
            this.mUsers_Password2.MaxLength = 16;
            this.mUsers_Password2.Name = "mUsers_Password2";
            this.mUsers_Password2.Size = new System.Drawing.Size(193, 20);
            this.mUsers_Password2.TabIndex = 2;
            this.mUsers_Password2.UseSystemPasswordChar = true;
            // 
            // mUsers_Passive
            // 
            this.mUsers_Passive.Location = new System.Drawing.Point(18, 185);
            this.mUsers_Passive.Name = "mUsers_Passive";
            this.mUsers_Passive.Size = new System.Drawing.Size(95, 23);
            this.mUsers_Passive.TabIndex = 5;
            this.mUsers_Passive.Text = "Passive";
            this.mUsers_Passive.UseVisualStyleBackColor = true;
            this.mUsers_Passive.Click += new System.EventHandler(this.mUsers_Passive_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(527, 261);
            this.Controls.Add(this.mUsers_Passive);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mUsers_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView mUsers_DataGridView;
        private System.Windows.Forms.Button mUsers_Delete;
        private System.Windows.Forms.TextBox mUsers_UserName;
        private System.Windows.Forms.Button mUsers_Update;
        private System.Windows.Forms.TextBox mUsers_Password;
        private System.Windows.Forms.Button mUsers_Add;
        private System.Windows.Forms.TextBox mUsers_Password2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mUsers_Passive;
        private System.Windows.Forms.Button mUsers_Clear;
    }
}