namespace TechnicalService
{
    partial class CustomerOperations
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
            this.cust_ClearForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cust_DataGridView = new System.Windows.Forms.DataGridView();
            this.cust_Update = new System.Windows.Forms.Button();
            this.cust_Add = new System.Windows.Forms.Button();
            this.cust_FullName = new System.Windows.Forms.TextBox();
            this.cust_PhoneNumber = new System.Windows.Forms.TextBox();
            this.cust_Email = new System.Windows.Forms.TextBox();
            this.cust_Address = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cust_ClearForm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cust_DataGridView);
            this.groupBox1.Controls.Add(this.cust_Update);
            this.groupBox1.Controls.Add(this.cust_Add);
            this.groupBox1.Controls.Add(this.cust_FullName);
            this.groupBox1.Controls.Add(this.cust_PhoneNumber);
            this.groupBox1.Controls.Add(this.cust_Email);
            this.groupBox1.Controls.Add(this.cust_Address);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // cust_ClearForm
            // 
            this.cust_ClearForm.Location = new System.Drawing.Point(106, 209);
            this.cust_ClearForm.Name = "cust_ClearForm";
            this.cust_ClearForm.Size = new System.Drawing.Size(96, 23);
            this.cust_ClearForm.TabIndex = 6;
            this.cust_ClearForm.Text = "Clear Form";
            this.cust_ClearForm.UseVisualStyleBackColor = true;
            this.cust_ClearForm.Click += new System.EventHandler(this.cust_ClearForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name";
            // 
            // cust_DataGridView
            // 
            this.cust_DataGridView.AllowUserToAddRows = false;
            this.cust_DataGridView.AllowUserToDeleteRows = false;
            this.cust_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.cust_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cust_DataGridView.Location = new System.Drawing.Point(208, 35);
            this.cust_DataGridView.MultiSelect = false;
            this.cust_DataGridView.Name = "cust_DataGridView";
            this.cust_DataGridView.RowHeadersVisible = false;
            this.cust_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cust_DataGridView.Size = new System.Drawing.Size(735, 197);
            this.cust_DataGridView.TabIndex = 7;
            this.cust_DataGridView.SelectionChanged += new System.EventHandler(this.cust_DataGridView_SelectionChanged);
            // 
            // cust_Update
            // 
            this.cust_Update.Location = new System.Drawing.Point(6, 209);
            this.cust_Update.Name = "cust_Update";
            this.cust_Update.Size = new System.Drawing.Size(96, 23);
            this.cust_Update.TabIndex = 5;
            this.cust_Update.Text = "Update";
            this.cust_Update.UseVisualStyleBackColor = true;
            this.cust_Update.Click += new System.EventHandler(this.cust_Update_Click);
            // 
            // cust_Add
            // 
            this.cust_Add.Location = new System.Drawing.Point(6, 180);
            this.cust_Add.Name = "cust_Add";
            this.cust_Add.Size = new System.Drawing.Size(197, 23);
            this.cust_Add.TabIndex = 4;
            this.cust_Add.Text = "Add";
            this.cust_Add.UseVisualStyleBackColor = true;
            this.cust_Add.Click += new System.EventHandler(this.cust_Add_Click);
            // 
            // cust_FullName
            // 
            this.cust_FullName.Location = new System.Drawing.Point(9, 35);
            this.cust_FullName.MaxLength = 100;
            this.cust_FullName.Name = "cust_FullName";
            this.cust_FullName.Size = new System.Drawing.Size(194, 20);
            this.cust_FullName.TabIndex = 0;
            // 
            // cust_PhoneNumber
            // 
            this.cust_PhoneNumber.Location = new System.Drawing.Point(9, 74);
            this.cust_PhoneNumber.MaxLength = 11;
            this.cust_PhoneNumber.Name = "cust_PhoneNumber";
            this.cust_PhoneNumber.Size = new System.Drawing.Size(194, 20);
            this.cust_PhoneNumber.TabIndex = 1;
            // 
            // cust_Email
            // 
            this.cust_Email.Location = new System.Drawing.Point(8, 113);
            this.cust_Email.MaxLength = 100;
            this.cust_Email.Name = "cust_Email";
            this.cust_Email.Size = new System.Drawing.Size(194, 20);
            this.cust_Email.TabIndex = 2;
            // 
            // cust_Address
            // 
            this.cust_Address.Location = new System.Drawing.Point(9, 151);
            this.cust_Address.MaxLength = 255;
            this.cust_Address.Name = "cust_Address";
            this.cust_Address.Size = new System.Drawing.Size(194, 20);
            this.cust_Address.TabIndex = 3;
            // 
            // CustomerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(973, 267);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustomerOperations";
            this.Text = "Customer Operations";
            this.Load += new System.EventHandler(this.CustomerOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cust_FullName;
        private System.Windows.Forms.TextBox cust_PhoneNumber;
        private System.Windows.Forms.TextBox cust_Email;
        private System.Windows.Forms.TextBox cust_Address;
        private System.Windows.Forms.DataGridView cust_DataGridView;
        private System.Windows.Forms.Button cust_Update;
        private System.Windows.Forms.Button cust_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cust_ClearForm;
    }
}