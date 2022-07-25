namespace TechnicalService
{
    partial class MainForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.repair_CustQuery = new System.Windows.Forms.Button();
            this.repair_ClearForm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repair_Description = new System.Windows.Forms.TextBox();
            this.repair_Phone = new System.Windows.Forms.TextBox();
            this.device_Model = new System.Windows.Forms.ComboBox();
            this.device_Brand = new System.Windows.Forms.ComboBox();
            this.device_Type = new System.Windows.Forms.ComboBox();
            this.repair_Operation = new System.Windows.Forms.ComboBox();
            this.repair_Technician = new System.Windows.Forms.ComboBox();
            this.receivedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.repair_Add = new System.Windows.Forms.Button();
            this.repair_Update = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.devices_DataGridView2 = new System.Windows.Forms.DataGridView();
            this.devices_DataGridView1 = new System.Windows.Forms.DataGridView();
            this.devices_DataGridView = new System.Windows.Forms.DataGridView();
            this.pendingDevices = new System.Windows.Forms.RadioButton();
            this.repairedDevices = new System.Windows.Forms.RadioButton();
            this.deliveredDevices = new System.Windows.Forms.RadioButton();
            this.checkRepaired = new System.Windows.Forms.CheckBox();
            this.checkDelivered = new System.Windows.Forms.CheckBox();
            this.repairedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveredTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devices_DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devices_DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devices_DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.repair_CustQuery);
            this.groupBox3.Controls.Add(this.repair_ClearForm);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.repair_Description);
            this.groupBox3.Controls.Add(this.repair_Phone);
            this.groupBox3.Controls.Add(this.device_Model);
            this.groupBox3.Controls.Add(this.device_Brand);
            this.groupBox3.Controls.Add(this.device_Type);
            this.groupBox3.Controls.Add(this.repair_Operation);
            this.groupBox3.Controls.Add(this.repair_Technician);
            this.groupBox3.Controls.Add(this.receivedTimePicker);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.repair_Add);
            this.groupBox3.Controls.Add(this.repair_Update);
            this.groupBox3.Location = new System.Drawing.Point(12, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 474);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repair Registration";
            // 
            // repair_CustQuery
            // 
            this.repair_CustQuery.Location = new System.Drawing.Point(6, 66);
            this.repair_CustQuery.Name = "repair_CustQuery";
            this.repair_CustQuery.Size = new System.Drawing.Size(193, 23);
            this.repair_CustQuery.TabIndex = 1;
            this.repair_CustQuery.Text = "Customer Inquiry";
            this.repair_CustQuery.UseVisualStyleBackColor = true;
            this.repair_CustQuery.Click += new System.EventHandler(this.repair_CustQuery_Click);
            // 
            // repair_ClearForm
            // 
            this.repair_ClearForm.Location = new System.Drawing.Point(6, 438);
            this.repair_ClearForm.Name = "repair_ClearForm";
            this.repair_ClearForm.Size = new System.Drawing.Size(194, 23);
            this.repair_ClearForm.TabIndex = 11;
            this.repair_ClearForm.Text = "Clear Form";
            this.repair_ClearForm.UseVisualStyleBackColor = true;
            this.repair_ClearForm.Click += new System.EventHandler(this.repair_ClearForm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Technician";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Repair Operation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Repair Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Device Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Device Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Device Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number";
            // 
            // repair_Description
            // 
            this.repair_Description.Location = new System.Drawing.Point(6, 270);
            this.repair_Description.MaxLength = 255;
            this.repair_Description.Name = "repair_Description";
            this.repair_Description.Size = new System.Drawing.Size(193, 20);
            this.repair_Description.TabIndex = 6;
            // 
            // repair_Phone
            // 
            this.repair_Phone.Location = new System.Drawing.Point(6, 38);
            this.repair_Phone.MaxLength = 11;
            this.repair_Phone.Name = "repair_Phone";
            this.repair_Phone.Size = new System.Drawing.Size(193, 20);
            this.repair_Phone.TabIndex = 0;
            // 
            // device_Model
            // 
            this.device_Model.FormattingEnabled = true;
            this.device_Model.Location = new System.Drawing.Point(6, 190);
            this.device_Model.Name = "device_Model";
            this.device_Model.Size = new System.Drawing.Size(193, 21);
            this.device_Model.TabIndex = 4;
            // 
            // device_Brand
            // 
            this.device_Brand.FormattingEnabled = true;
            this.device_Brand.Location = new System.Drawing.Point(5, 150);
            this.device_Brand.Name = "device_Brand";
            this.device_Brand.Size = new System.Drawing.Size(193, 21);
            this.device_Brand.TabIndex = 3;
            this.device_Brand.SelectedIndexChanged += new System.EventHandler(this.device_Brand_SelectedIndexChanged);
            // 
            // device_Type
            // 
            this.device_Type.FormattingEnabled = true;
            this.device_Type.Location = new System.Drawing.Point(6, 110);
            this.device_Type.Name = "device_Type";
            this.device_Type.Size = new System.Drawing.Size(193, 21);
            this.device_Type.TabIndex = 2;
            this.device_Type.SelectedIndexChanged += new System.EventHandler(this.device_Type_SelectedIndexChanged);
            this.device_Type.TextChanged += new System.EventHandler(this.device_Type_TextChanged);
            // 
            // repair_Operation
            // 
            this.repair_Operation.FormattingEnabled = true;
            this.repair_Operation.Location = new System.Drawing.Point(6, 230);
            this.repair_Operation.Name = "repair_Operation";
            this.repair_Operation.Size = new System.Drawing.Size(193, 21);
            this.repair_Operation.TabIndex = 5;
            // 
            // repair_Technician
            // 
            this.repair_Technician.FormattingEnabled = true;
            this.repair_Technician.Location = new System.Drawing.Point(5, 309);
            this.repair_Technician.Name = "repair_Technician";
            this.repair_Technician.Size = new System.Drawing.Size(194, 21);
            this.repair_Technician.TabIndex = 7;
            // 
            // receivedTimePicker
            // 
            this.receivedTimePicker.Location = new System.Drawing.Point(5, 350);
            this.receivedTimePicker.Name = "receivedTimePicker";
            this.receivedTimePicker.Size = new System.Drawing.Size(194, 20);
            this.receivedTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Received Date:";
            // 
            // repair_Add
            // 
            this.repair_Add.Location = new System.Drawing.Point(5, 380);
            this.repair_Add.Name = "repair_Add";
            this.repair_Add.Size = new System.Drawing.Size(194, 23);
            this.repair_Add.TabIndex = 9;
            this.repair_Add.Text = "Add";
            this.repair_Add.UseVisualStyleBackColor = true;
            this.repair_Add.Click += new System.EventHandler(this.repair_Add_Click);
            // 
            // repair_Update
            // 
            this.repair_Update.Location = new System.Drawing.Point(5, 409);
            this.repair_Update.Name = "repair_Update";
            this.repair_Update.Size = new System.Drawing.Size(194, 23);
            this.repair_Update.TabIndex = 10;
            this.repair_Update.Text = "Update ";
            this.repair_Update.UseVisualStyleBackColor = true;
            this.repair_Update.Click += new System.EventHandler(this.repair_Update_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.devices_DataGridView2);
            this.groupBox4.Controls.Add(this.devices_DataGridView1);
            this.groupBox4.Controls.Add(this.devices_DataGridView);
            this.groupBox4.Controls.Add(this.pendingDevices);
            this.groupBox4.Controls.Add(this.repairedDevices);
            this.groupBox4.Controls.Add(this.deliveredDevices);
            this.groupBox4.Controls.Add(this.checkRepaired);
            this.groupBox4.Controls.Add(this.checkDelivered);
            this.groupBox4.Controls.Add(this.repairedTimePicker);
            this.groupBox4.Controls.Add(this.deliveredTimePicker);
            this.groupBox4.Location = new System.Drawing.Point(224, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(918, 474);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Repair Details";
            // 
            // devices_DataGridView2
            // 
            this.devices_DataGridView2.AllowUserToAddRows = false;
            this.devices_DataGridView2.AllowUserToDeleteRows = false;
            this.devices_DataGridView2.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.devices_DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devices_DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.devices_DataGridView2.Location = new System.Drawing.Point(18, 45);
            this.devices_DataGridView2.MultiSelect = false;
            this.devices_DataGridView2.Name = "devices_DataGridView2";
            this.devices_DataGridView2.RowHeadersVisible = false;
            this.devices_DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devices_DataGridView2.Size = new System.Drawing.Size(886, 387);
            this.devices_DataGridView2.TabIndex = 9;
            this.devices_DataGridView2.Visible = false;
            this.devices_DataGridView2.SelectionChanged += new System.EventHandler(this.devices_DataGridView2_SelectionChanged);
            // 
            // devices_DataGridView1
            // 
            this.devices_DataGridView1.AllowUserToAddRows = false;
            this.devices_DataGridView1.AllowUserToDeleteRows = false;
            this.devices_DataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.devices_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devices_DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.devices_DataGridView1.Location = new System.Drawing.Point(18, 45);
            this.devices_DataGridView1.MultiSelect = false;
            this.devices_DataGridView1.Name = "devices_DataGridView1";
            this.devices_DataGridView1.RowHeadersVisible = false;
            this.devices_DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devices_DataGridView1.Size = new System.Drawing.Size(886, 387);
            this.devices_DataGridView1.TabIndex = 8;
            this.devices_DataGridView1.Visible = false;
            this.devices_DataGridView1.SelectionChanged += new System.EventHandler(this.devices_DataGridView1_SelectionChanged);
            // 
            // devices_DataGridView
            // 
            this.devices_DataGridView.AllowUserToAddRows = false;
            this.devices_DataGridView.AllowUserToDeleteRows = false;
            this.devices_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.devices_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devices_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.devices_DataGridView.Location = new System.Drawing.Point(18, 45);
            this.devices_DataGridView.MultiSelect = false;
            this.devices_DataGridView.Name = "devices_DataGridView";
            this.devices_DataGridView.RowHeadersVisible = false;
            this.devices_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devices_DataGridView.Size = new System.Drawing.Size(886, 387);
            this.devices_DataGridView.TabIndex = 3;
            this.devices_DataGridView.Visible = false;
            this.devices_DataGridView.SelectionChanged += new System.EventHandler(this.devices_DataGridView_SelectionChanged);
            // 
            // pendingDevices
            // 
            this.pendingDevices.AutoSize = true;
            this.pendingDevices.Location = new System.Drawing.Point(18, 22);
            this.pendingDevices.Name = "pendingDevices";
            this.pendingDevices.Size = new System.Drawing.Size(104, 17);
            this.pendingDevices.TabIndex = 0;
            this.pendingDevices.TabStop = true;
            this.pendingDevices.Text = "Pending devices";
            this.pendingDevices.UseVisualStyleBackColor = true;
            this.pendingDevices.CheckedChanged += new System.EventHandler(this.pendingDevices_CheckedChanged);
            // 
            // repairedDevices
            // 
            this.repairedDevices.AutoSize = true;
            this.repairedDevices.Location = new System.Drawing.Point(128, 22);
            this.repairedDevices.Name = "repairedDevices";
            this.repairedDevices.Size = new System.Drawing.Size(108, 17);
            this.repairedDevices.TabIndex = 1;
            this.repairedDevices.TabStop = true;
            this.repairedDevices.Text = "Repaired devices";
            this.repairedDevices.UseVisualStyleBackColor = true;
            this.repairedDevices.CheckedChanged += new System.EventHandler(this.repairedDevices_CheckedChanged);
            // 
            // deliveredDevices
            // 
            this.deliveredDevices.AutoSize = true;
            this.deliveredDevices.Location = new System.Drawing.Point(242, 22);
            this.deliveredDevices.Name = "deliveredDevices";
            this.deliveredDevices.Size = new System.Drawing.Size(110, 17);
            this.deliveredDevices.TabIndex = 2;
            this.deliveredDevices.TabStop = true;
            this.deliveredDevices.Text = "Delivered devices";
            this.deliveredDevices.UseVisualStyleBackColor = true;
            this.deliveredDevices.CheckedChanged += new System.EventHandler(this.deliveredDevices_CheckedChanged);
            // 
            // checkRepaired
            // 
            this.checkRepaired.AutoSize = true;
            this.checkRepaired.Location = new System.Drawing.Point(218, 445);
            this.checkRepaired.Name = "checkRepaired";
            this.checkRepaired.Size = new System.Drawing.Size(69, 17);
            this.checkRepaired.TabIndex = 5;
            this.checkRepaired.Text = "Repaired";
            this.checkRepaired.UseVisualStyleBackColor = true;
            this.checkRepaired.CheckedChanged += new System.EventHandler(this.checkRepaired_CheckedChanged);
            // 
            // checkDelivered
            // 
            this.checkDelivered.AutoSize = true;
            this.checkDelivered.Location = new System.Drawing.Point(513, 444);
            this.checkDelivered.Name = "checkDelivered";
            this.checkDelivered.Size = new System.Drawing.Size(71, 17);
            this.checkDelivered.TabIndex = 7;
            this.checkDelivered.Text = "Delivered";
            this.checkDelivered.UseVisualStyleBackColor = true;
            this.checkDelivered.CheckedChanged += new System.EventHandler(this.checkDelivered_CheckedChanged);
            // 
            // repairedTimePicker
            // 
            this.repairedTimePicker.Location = new System.Drawing.Point(18, 441);
            this.repairedTimePicker.Name = "repairedTimePicker";
            this.repairedTimePicker.Size = new System.Drawing.Size(194, 20);
            this.repairedTimePicker.TabIndex = 4;
            // 
            // deliveredTimePicker
            // 
            this.deliveredTimePicker.Location = new System.Drawing.Point(313, 440);
            this.deliveredTimePicker.Name = "deliveredTimePicker";
            this.deliveredTimePicker.Size = new System.Drawing.Size(194, 20);
            this.deliveredTimePicker.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.customerOperationsToolStripMenuItem,
            this.userOperationsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.deviceManagementToolStripMenuItem,
            this.operationManagementToolStripMenuItem,
            this.paymentOperationsToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // employeeManagementToolStripMenuItem
            // 
            this.employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            this.employeeManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.employeeManagementToolStripMenuItem.Text = "Employee Management";
            this.employeeManagementToolStripMenuItem.Click += new System.EventHandler(this.employeeManagementToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // deviceManagementToolStripMenuItem
            // 
            this.deviceManagementToolStripMenuItem.Name = "deviceManagementToolStripMenuItem";
            this.deviceManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deviceManagementToolStripMenuItem.Text = "Device Management";
            this.deviceManagementToolStripMenuItem.Click += new System.EventHandler(this.deviceManagementToolStripMenuItem_Click);
            // 
            // operationManagementToolStripMenuItem
            // 
            this.operationManagementToolStripMenuItem.Name = "operationManagementToolStripMenuItem";
            this.operationManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.operationManagementToolStripMenuItem.Text = "Operation Management";
            this.operationManagementToolStripMenuItem.Click += new System.EventHandler(this.operationManagementToolStripMenuItem_Click);
            // 
            // paymentOperationsToolStripMenuItem
            // 
            this.paymentOperationsToolStripMenuItem.Name = "paymentOperationsToolStripMenuItem";
            this.paymentOperationsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.paymentOperationsToolStripMenuItem.Text = "Payments";
            this.paymentOperationsToolStripMenuItem.Click += new System.EventHandler(this.paymentOperationsToolStripMenuItem_Click);
            // 
            // customerOperationsToolStripMenuItem
            // 
            this.customerOperationsToolStripMenuItem.Name = "customerOperationsToolStripMenuItem";
            this.customerOperationsToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.customerOperationsToolStripMenuItem.Text = "Customer Operations";
            this.customerOperationsToolStripMenuItem.Click += new System.EventHandler(this.customerOperationsToolStripMenuItem_Click);
            // 
            // userOperationsToolStripMenuItem
            // 
            this.userOperationsToolStripMenuItem.Name = "userOperationsToolStripMenuItem";
            this.userOperationsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.userOperationsToolStripMenuItem.Text = "User Operations";
            this.userOperationsToolStripMenuItem.Click += new System.EventHandler(this.userOperationsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1154, 517);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Technical Service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devices_DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devices_DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devices_DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox repair_Description;
        private System.Windows.Forms.ComboBox repair_Operation;
        private System.Windows.Forms.ComboBox repair_Technician;
        private System.Windows.Forms.DateTimePicker receivedTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button repair_Add;
        private System.Windows.Forms.Button repair_Update;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView devices_DataGridView;
        private System.Windows.Forms.RadioButton pendingDevices;
        private System.Windows.Forms.RadioButton repairedDevices;
        private System.Windows.Forms.RadioButton deliveredDevices;
        private System.Windows.Forms.CheckBox checkRepaired;
        private System.Windows.Forms.CheckBox checkDelivered;
        private System.Windows.Forms.DateTimePicker repairedTimePicker;
        private System.Windows.Forms.DateTimePicker deliveredTimePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOperationsToolStripMenuItem;
        private System.Windows.Forms.TextBox repair_Phone;
        private System.Windows.Forms.ComboBox device_Model;
        private System.Windows.Forms.ComboBox device_Brand;
        private System.Windows.Forms.ComboBox device_Type;
        private System.Windows.Forms.ToolStripMenuItem paymentOperationsToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView devices_DataGridView1;
        private System.Windows.Forms.DataGridView devices_DataGridView2;
        private System.Windows.Forms.Button repair_ClearForm;
        private System.Windows.Forms.Button repair_CustQuery;
    }
}