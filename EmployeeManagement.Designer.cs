namespace TechnicalService
{
    partial class EmployeeManagement
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.role_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roleAuths_All = new System.Windows.Forms.CheckBox();
            this.roleAuths_Delivery = new System.Windows.Forms.CheckBox();
            this.roleAuths_Repair = new System.Windows.Forms.CheckBox();
            this.roleAuths_RepairReg = new System.Windows.Forms.CheckBox();
            this.roleAuths_Customer = new System.Windows.Forms.CheckBox();
            this.roleAuths_Payment = new System.Windows.Forms.CheckBox();
            this.roleAuths_Operation = new System.Windows.Forms.CheckBox();
            this.roleAuths_Device = new System.Windows.Forms.CheckBox();
            this.roleAuths_User = new System.Windows.Forms.CheckBox();
            this.roleAuths_Employee = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.role_DataGridView = new System.Windows.Forms.DataGridView();
            this.role_Passive = new System.Windows.Forms.Button();
            this.role_Update = new System.Windows.Forms.Button();
            this.role_Add = new System.Windows.Forms.Button();
            this.role_Role = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.emp_ClearForm = new System.Windows.Forms.Button();
            this.emp_User_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_Role = new System.Windows.Forms.ComboBox();
            this.emp_DataGridView = new System.Windows.Forms.DataGridView();
            this.emp_Passive = new System.Windows.Forms.Button();
            this.emp_Update = new System.Windows.Forms.Button();
            this.emp_Add = new System.Windows.Forms.Button();
            this.emp_Salary = new System.Windows.Forms.TextBox();
            this.emp_FullName = new System.Windows.Forms.TextBox();
            this.emp_Address = new System.Windows.Forms.TextBox();
            this.emp_PhoneNumber = new System.Windows.Forms.TextBox();
            this.emp_Email = new System.Windows.Forms.TextBox();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.role_DataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.role_Clear);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.role_DataGridView);
            this.groupBox7.Controls.Add(this.role_Passive);
            this.groupBox7.Controls.Add(this.role_Update);
            this.groupBox7.Controls.Add(this.role_Add);
            this.groupBox7.Controls.Add(this.role_Role);
            this.groupBox7.Location = new System.Drawing.Point(14, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1103, 270);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Employee Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "*The number 0 in the table means \'NO\' and the number 1 means \'YES\'.";
            // 
            // role_Clear
            // 
            this.role_Clear.Location = new System.Drawing.Point(5, 232);
            this.role_Clear.Name = "role_Clear";
            this.role_Clear.Size = new System.Drawing.Size(142, 23);
            this.role_Clear.TabIndex = 13;
            this.role_Clear.Text = "Clear Form";
            this.role_Clear.UseVisualStyleBackColor = true;
            this.role_Clear.Click += new System.EventHandler(this.role_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roleAuths_All);
            this.groupBox1.Controls.Add(this.roleAuths_Delivery);
            this.groupBox1.Controls.Add(this.roleAuths_Repair);
            this.groupBox1.Controls.Add(this.roleAuths_RepairReg);
            this.groupBox1.Controls.Add(this.roleAuths_Customer);
            this.groupBox1.Controls.Add(this.roleAuths_Payment);
            this.groupBox1.Controls.Add(this.roleAuths_Operation);
            this.groupBox1.Controls.Add(this.roleAuths_Device);
            this.groupBox1.Controls.Add(this.roleAuths_User);
            this.groupBox1.Controls.Add(this.roleAuths_Employee);
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role Auths.";
            // 
            // roleAuths_All
            // 
            this.roleAuths_All.AutoSize = true;
            this.roleAuths_All.Location = new System.Drawing.Point(6, 19);
            this.roleAuths_All.Name = "roleAuths_All";
            this.roleAuths_All.Size = new System.Drawing.Size(70, 17);
            this.roleAuths_All.TabIndex = 1;
            this.roleAuths_All.Text = "All Auths.";
            this.roleAuths_All.UseVisualStyleBackColor = true;
            this.roleAuths_All.CheckedChanged += new System.EventHandler(this.roleAuths_All_CheckedChanged);
            // 
            // roleAuths_Delivery
            // 
            this.roleAuths_Delivery.AutoSize = true;
            this.roleAuths_Delivery.Location = new System.Drawing.Point(149, 111);
            this.roleAuths_Delivery.Name = "roleAuths_Delivery";
            this.roleAuths_Delivery.Size = new System.Drawing.Size(97, 17);
            this.roleAuths_Delivery.TabIndex = 10;
            this.roleAuths_Delivery.Text = "Delivery Auths.";
            this.roleAuths_Delivery.UseVisualStyleBackColor = true;
            this.roleAuths_Delivery.CheckedChanged += new System.EventHandler(this.roleAuths_Delivery_CheckedChanged);
            // 
            // roleAuths_Repair
            // 
            this.roleAuths_Repair.AutoSize = true;
            this.roleAuths_Repair.Location = new System.Drawing.Point(6, 111);
            this.roleAuths_Repair.Name = "roleAuths_Repair";
            this.roleAuths_Repair.Size = new System.Drawing.Size(90, 17);
            this.roleAuths_Repair.TabIndex = 9;
            this.roleAuths_Repair.Text = "Repair Auths.";
            this.roleAuths_Repair.UseVisualStyleBackColor = true;
            this.roleAuths_Repair.CheckedChanged += new System.EventHandler(this.roleAuths_Repair_CheckedChanged);
            // 
            // roleAuths_RepairReg
            // 
            this.roleAuths_RepairReg.AutoSize = true;
            this.roleAuths_RepairReg.Location = new System.Drawing.Point(149, 88);
            this.roleAuths_RepairReg.Name = "roleAuths_RepairReg";
            this.roleAuths_RepairReg.Size = new System.Drawing.Size(116, 17);
            this.roleAuths_RepairReg.TabIndex = 8;
            this.roleAuths_RepairReg.Text = "Repair Registration";
            this.roleAuths_RepairReg.UseVisualStyleBackColor = true;
            this.roleAuths_RepairReg.CheckedChanged += new System.EventHandler(this.roleAuths_RepairReg_CheckedChanged);
            // 
            // roleAuths_Customer
            // 
            this.roleAuths_Customer.AutoSize = true;
            this.roleAuths_Customer.Location = new System.Drawing.Point(6, 88);
            this.roleAuths_Customer.Name = "roleAuths_Customer";
            this.roleAuths_Customer.Size = new System.Drawing.Size(124, 17);
            this.roleAuths_Customer.TabIndex = 7;
            this.roleAuths_Customer.Text = "Customer Operations";
            this.roleAuths_Customer.UseVisualStyleBackColor = true;
            this.roleAuths_Customer.CheckedChanged += new System.EventHandler(this.roleAuths_Customer_CheckedChanged);
            // 
            // roleAuths_Payment
            // 
            this.roleAuths_Payment.AutoSize = true;
            this.roleAuths_Payment.Location = new System.Drawing.Point(149, 65);
            this.roleAuths_Payment.Name = "roleAuths_Payment";
            this.roleAuths_Payment.Size = new System.Drawing.Size(121, 17);
            this.roleAuths_Payment.TabIndex = 6;
            this.roleAuths_Payment.Text = "Payment Operations";
            this.roleAuths_Payment.UseVisualStyleBackColor = true;
            this.roleAuths_Payment.CheckedChanged += new System.EventHandler(this.roleAuths_Payment_CheckedChanged);
            // 
            // roleAuths_Operation
            // 
            this.roleAuths_Operation.AutoSize = true;
            this.roleAuths_Operation.Location = new System.Drawing.Point(6, 65);
            this.roleAuths_Operation.Name = "roleAuths_Operation";
            this.roleAuths_Operation.Size = new System.Drawing.Size(137, 17);
            this.roleAuths_Operation.TabIndex = 5;
            this.roleAuths_Operation.Text = "Operation Management";
            this.roleAuths_Operation.UseVisualStyleBackColor = true;
            this.roleAuths_Operation.CheckedChanged += new System.EventHandler(this.roleAuths_Operation_CheckedChanged);
            // 
            // roleAuths_Device
            // 
            this.roleAuths_Device.AutoSize = true;
            this.roleAuths_Device.Location = new System.Drawing.Point(149, 42);
            this.roleAuths_Device.Name = "roleAuths_Device";
            this.roleAuths_Device.Size = new System.Drawing.Size(125, 17);
            this.roleAuths_Device.TabIndex = 4;
            this.roleAuths_Device.Text = "Device Management";
            this.roleAuths_Device.UseVisualStyleBackColor = true;
            this.roleAuths_Device.CheckedChanged += new System.EventHandler(this.roleAuths_Device_CheckedChanged);
            // 
            // roleAuths_User
            // 
            this.roleAuths_User.AutoSize = true;
            this.roleAuths_User.Location = new System.Drawing.Point(6, 42);
            this.roleAuths_User.Name = "roleAuths_User";
            this.roleAuths_User.Size = new System.Drawing.Size(113, 17);
            this.roleAuths_User.TabIndex = 3;
            this.roleAuths_User.Text = "User Management";
            this.roleAuths_User.UseVisualStyleBackColor = true;
            this.roleAuths_User.CheckedChanged += new System.EventHandler(this.roleAuths_User_CheckedChanged);
            // 
            // roleAuths_Employee
            // 
            this.roleAuths_Employee.AutoSize = true;
            this.roleAuths_Employee.Location = new System.Drawing.Point(149, 19);
            this.roleAuths_Employee.Name = "roleAuths_Employee";
            this.roleAuths_Employee.Size = new System.Drawing.Size(137, 17);
            this.roleAuths_Employee.TabIndex = 2;
            this.roleAuths_Employee.Text = "Employee Management";
            this.roleAuths_Employee.UseVisualStyleBackColor = true;
            this.roleAuths_Employee.CheckedChanged += new System.EventHandler(this.roleAuths_Employee_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Role:";
            // 
            // role_DataGridView
            // 
            this.role_DataGridView.AllowUserToAddRows = false;
            this.role_DataGridView.AllowUserToDeleteRows = false;
            this.role_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.role_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.role_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.role_DataGridView.Location = new System.Drawing.Point(301, 28);
            this.role_DataGridView.MultiSelect = false;
            this.role_DataGridView.Name = "role_DataGridView";
            this.role_DataGridView.RowHeadersVisible = false;
            this.role_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.role_DataGridView.Size = new System.Drawing.Size(796, 227);
            this.role_DataGridView.TabIndex = 15;
            this.role_DataGridView.SelectionChanged += new System.EventHandler(this.role_DataGridView_SelectionChanged);
            // 
            // role_Passive
            // 
            this.role_Passive.Location = new System.Drawing.Point(153, 232);
            this.role_Passive.Name = "role_Passive";
            this.role_Passive.Size = new System.Drawing.Size(142, 23);
            this.role_Passive.TabIndex = 14;
            this.role_Passive.Text = "Passive";
            this.role_Passive.UseVisualStyleBackColor = true;
            this.role_Passive.Click += new System.EventHandler(this.role_Passive_Click);
            // 
            // role_Update
            // 
            this.role_Update.Location = new System.Drawing.Point(153, 203);
            this.role_Update.Name = "role_Update";
            this.role_Update.Size = new System.Drawing.Size(142, 23);
            this.role_Update.TabIndex = 12;
            this.role_Update.Text = "Update";
            this.role_Update.UseVisualStyleBackColor = true;
            this.role_Update.Click += new System.EventHandler(this.role_Update_Click);
            // 
            // role_Add
            // 
            this.role_Add.Location = new System.Drawing.Point(5, 203);
            this.role_Add.Name = "role_Add";
            this.role_Add.Size = new System.Drawing.Size(142, 23);
            this.role_Add.TabIndex = 11;
            this.role_Add.Text = "Add";
            this.role_Add.UseVisualStyleBackColor = true;
            this.role_Add.Click += new System.EventHandler(this.role_Add_Click);
            // 
            // role_Role
            // 
            this.role_Role.Location = new System.Drawing.Point(39, 28);
            this.role_Role.MaxLength = 16;
            this.role_Role.Name = "role_Role";
            this.role_Role.Size = new System.Drawing.Size(143, 20);
            this.role_Role.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.emp_ClearForm);
            this.groupBox5.Controls.Add(this.emp_User_Name);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.emp_Role);
            this.groupBox5.Controls.Add(this.emp_DataGridView);
            this.groupBox5.Controls.Add(this.emp_Passive);
            this.groupBox5.Controls.Add(this.emp_Update);
            this.groupBox5.Controls.Add(this.emp_Add);
            this.groupBox5.Controls.Add(this.emp_Salary);
            this.groupBox5.Controls.Add(this.emp_FullName);
            this.groupBox5.Controls.Add(this.emp_Address);
            this.groupBox5.Controls.Add(this.emp_PhoneNumber);
            this.groupBox5.Controls.Add(this.emp_Email);
            this.groupBox5.Location = new System.Drawing.Point(14, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1103, 375);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee Operations";
            // 
            // emp_ClearForm
            // 
            this.emp_ClearForm.Location = new System.Drawing.Point(7, 334);
            this.emp_ClearForm.Name = "emp_ClearForm";
            this.emp_ClearForm.Size = new System.Drawing.Size(95, 23);
            this.emp_ClearForm.TabIndex = 9;
            this.emp_ClearForm.Text = "Clear Form";
            this.emp_ClearForm.UseVisualStyleBackColor = true;
            this.emp_ClearForm.Click += new System.EventHandler(this.emp_ClearForm_Click);
            // 
            // emp_User_Name
            // 
            this.emp_User_Name.Location = new System.Drawing.Point(7, 235);
            this.emp_User_Name.MaxLength = 16;
            this.emp_User_Name.Name = "emp_User_Name";
            this.emp_User_Name.Size = new System.Drawing.Size(192, 20);
            this.emp_User_Name.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Full Name";
            // 
            // emp_Role
            // 
            this.emp_Role.FormattingEnabled = true;
            this.emp_Role.Location = new System.Drawing.Point(7, 274);
            this.emp_Role.Name = "emp_Role";
            this.emp_Role.Size = new System.Drawing.Size(193, 21);
            this.emp_Role.TabIndex = 6;
            // 
            // emp_DataGridView
            // 
            this.emp_DataGridView.AllowUserToAddRows = false;
            this.emp_DataGridView.AllowUserToDeleteRows = false;
            this.emp_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.emp_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.emp_DataGridView.Location = new System.Drawing.Point(216, 38);
            this.emp_DataGridView.MultiSelect = false;
            this.emp_DataGridView.Name = "emp_DataGridView";
            this.emp_DataGridView.RowHeadersVisible = false;
            this.emp_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emp_DataGridView.Size = new System.Drawing.Size(881, 319);
            this.emp_DataGridView.TabIndex = 11;
            this.emp_DataGridView.SelectionChanged += new System.EventHandler(this.emp_DataGridView_SelectionChanged);
            // 
            // emp_Passive
            // 
            this.emp_Passive.Location = new System.Drawing.Point(104, 334);
            this.emp_Passive.Name = "emp_Passive";
            this.emp_Passive.Size = new System.Drawing.Size(95, 23);
            this.emp_Passive.TabIndex = 10;
            this.emp_Passive.Text = "Passive";
            this.emp_Passive.UseVisualStyleBackColor = true;
            this.emp_Passive.Click += new System.EventHandler(this.emp_Passive_Click);
            // 
            // emp_Update
            // 
            this.emp_Update.Location = new System.Drawing.Point(105, 305);
            this.emp_Update.Name = "emp_Update";
            this.emp_Update.Size = new System.Drawing.Size(95, 23);
            this.emp_Update.TabIndex = 8;
            this.emp_Update.Text = "Update";
            this.emp_Update.UseVisualStyleBackColor = true;
            this.emp_Update.Click += new System.EventHandler(this.emp_Update_Click);
            // 
            // emp_Add
            // 
            this.emp_Add.Location = new System.Drawing.Point(5, 305);
            this.emp_Add.Name = "emp_Add";
            this.emp_Add.Size = new System.Drawing.Size(97, 23);
            this.emp_Add.TabIndex = 7;
            this.emp_Add.Text = "Add";
            this.emp_Add.UseVisualStyleBackColor = true;
            this.emp_Add.Click += new System.EventHandler(this.emp_Add_Click);
            // 
            // emp_Salary
            // 
            this.emp_Salary.Location = new System.Drawing.Point(7, 197);
            this.emp_Salary.MaxLength = 10;
            this.emp_Salary.Name = "emp_Salary";
            this.emp_Salary.Size = new System.Drawing.Size(193, 20);
            this.emp_Salary.TabIndex = 4;
            // 
            // emp_FullName
            // 
            this.emp_FullName.Location = new System.Drawing.Point(7, 38);
            this.emp_FullName.MaxLength = 100;
            this.emp_FullName.Name = "emp_FullName";
            this.emp_FullName.Size = new System.Drawing.Size(193, 20);
            this.emp_FullName.TabIndex = 0;
            // 
            // emp_Address
            // 
            this.emp_Address.Location = new System.Drawing.Point(6, 158);
            this.emp_Address.MaxLength = 255;
            this.emp_Address.Name = "emp_Address";
            this.emp_Address.Size = new System.Drawing.Size(193, 20);
            this.emp_Address.TabIndex = 3;
            // 
            // emp_PhoneNumber
            // 
            this.emp_PhoneNumber.Location = new System.Drawing.Point(6, 78);
            this.emp_PhoneNumber.MaxLength = 11;
            this.emp_PhoneNumber.Name = "emp_PhoneNumber";
            this.emp_PhoneNumber.Size = new System.Drawing.Size(193, 20);
            this.emp_PhoneNumber.TabIndex = 1;
            // 
            // emp_Email
            // 
            this.emp_Email.Location = new System.Drawing.Point(7, 118);
            this.emp_Email.MaxLength = 100;
            this.emp_Email.Name = "emp_Email";
            this.emp_Email.Size = new System.Drawing.Size(193, 20);
            this.emp_Email.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1129, 671);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.role_DataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView role_DataGridView;
        private System.Windows.Forms.Button role_Passive;
        private System.Windows.Forms.Button role_Update;
        private System.Windows.Forms.Button role_Add;
        private System.Windows.Forms.TextBox role_Role;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox emp_Role;
        private System.Windows.Forms.DataGridView emp_DataGridView;
        private System.Windows.Forms.Button emp_Passive;
        private System.Windows.Forms.Button emp_Update;
        private System.Windows.Forms.Button emp_Add;
        private System.Windows.Forms.TextBox emp_Salary;
        private System.Windows.Forms.TextBox emp_FullName;
        private System.Windows.Forms.TextBox emp_Address;
        private System.Windows.Forms.TextBox emp_PhoneNumber;
        private System.Windows.Forms.TextBox emp_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emp_User_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emp_ClearForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox roleAuths_Delivery;
        private System.Windows.Forms.CheckBox roleAuths_Repair;
        private System.Windows.Forms.CheckBox roleAuths_RepairReg;
        private System.Windows.Forms.CheckBox roleAuths_Customer;
        private System.Windows.Forms.CheckBox roleAuths_Payment;
        private System.Windows.Forms.CheckBox roleAuths_Operation;
        private System.Windows.Forms.CheckBox roleAuths_Device;
        private System.Windows.Forms.CheckBox roleAuths_User;
        private System.Windows.Forms.CheckBox roleAuths_Employee;
        private System.Windows.Forms.CheckBox roleAuths_All;
        private System.Windows.Forms.Button role_Clear;
        private System.Windows.Forms.Label label9;
    }
}