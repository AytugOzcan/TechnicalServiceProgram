namespace TechnicalService
{
    partial class DeviceManagement
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mDeviceModel_DataGridView = new System.Windows.Forms.DataGridView();
            this.mDeviceModel_Passive = new System.Windows.Forms.Button();
            this.mDeviceModel_Update = new System.Windows.Forms.Button();
            this.mDeviceModel_Add = new System.Windows.Forms.Button();
            this.mDeviceModel_Brand = new System.Windows.Forms.ComboBox();
            this.mDeviceModel_Type = new System.Windows.Forms.ComboBox();
            this.mDeviceModel_Name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mDeviceBrand_DataGridView = new System.Windows.Forms.DataGridView();
            this.mDeviceBrand_Passive = new System.Windows.Forms.Button();
            this.mDeviceBrand_Update = new System.Windows.Forms.Button();
            this.mDeviceBrand_Add = new System.Windows.Forms.Button();
            this.mDeviceBrand_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mDeviceType_DataGridView = new System.Windows.Forms.DataGridView();
            this.mDeviceType_Passive = new System.Windows.Forms.Button();
            this.mDeviceType_Update = new System.Windows.Forms.Button();
            this.mDeviceType_Add = new System.Windows.Forms.Button();
            this.mDeviceType_Name = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDeviceModel_DataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDeviceBrand_DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDeviceType_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.mDeviceModel_DataGridView);
            this.groupBox4.Controls.Add(this.mDeviceModel_Passive);
            this.groupBox4.Controls.Add(this.mDeviceModel_Update);
            this.groupBox4.Controls.Add(this.mDeviceModel_Add);
            this.groupBox4.Controls.Add(this.mDeviceModel_Brand);
            this.groupBox4.Controls.Add(this.mDeviceModel_Type);
            this.groupBox4.Controls.Add(this.mDeviceModel_Name);
            this.groupBox4.Location = new System.Drawing.Point(12, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 193);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Device Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Device Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Device Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Device Type";
            // 
            // mDeviceModel_DataGridView
            // 
            this.mDeviceModel_DataGridView.AllowUserToAddRows = false;
            this.mDeviceModel_DataGridView.AllowUserToDeleteRows = false;
            this.mDeviceModel_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.mDeviceModel_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDeviceModel_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mDeviceModel_DataGridView.Location = new System.Drawing.Point(206, 45);
            this.mDeviceModel_DataGridView.MultiSelect = false;
            this.mDeviceModel_DataGridView.Name = "mDeviceModel_DataGridView";
            this.mDeviceModel_DataGridView.RowHeadersVisible = false;
            this.mDeviceModel_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDeviceModel_DataGridView.Size = new System.Drawing.Size(230, 130);
            this.mDeviceModel_DataGridView.TabIndex = 6;
            this.mDeviceModel_DataGridView.SelectionChanged += new System.EventHandler(this.mDeviceModel_DataGridView_SelectionChanged);
            // 
            // mDeviceModel_Passive
            // 
            this.mDeviceModel_Passive.Location = new System.Drawing.Point(134, 152);
            this.mDeviceModel_Passive.Name = "mDeviceModel_Passive";
            this.mDeviceModel_Passive.Size = new System.Drawing.Size(60, 23);
            this.mDeviceModel_Passive.TabIndex = 5;
            this.mDeviceModel_Passive.Text = "Passive";
            this.mDeviceModel_Passive.UseVisualStyleBackColor = true;
            this.mDeviceModel_Passive.Click += new System.EventHandler(this.mDeviceModel_Passive_Click);
            // 
            // mDeviceModel_Update
            // 
            this.mDeviceModel_Update.Location = new System.Drawing.Point(70, 152);
            this.mDeviceModel_Update.Name = "mDeviceModel_Update";
            this.mDeviceModel_Update.Size = new System.Drawing.Size(60, 23);
            this.mDeviceModel_Update.TabIndex = 4;
            this.mDeviceModel_Update.Text = "Update";
            this.mDeviceModel_Update.UseVisualStyleBackColor = true;
            this.mDeviceModel_Update.Click += new System.EventHandler(this.mDeviceModel_Update_Click);
            // 
            // mDeviceModel_Add
            // 
            this.mDeviceModel_Add.Location = new System.Drawing.Point(6, 152);
            this.mDeviceModel_Add.Name = "mDeviceModel_Add";
            this.mDeviceModel_Add.Size = new System.Drawing.Size(60, 23);
            this.mDeviceModel_Add.TabIndex = 3;
            this.mDeviceModel_Add.Text = "Add";
            this.mDeviceModel_Add.UseVisualStyleBackColor = true;
            this.mDeviceModel_Add.Click += new System.EventHandler(this.mDeviceModel_Add_Click);
            // 
            // mDeviceModel_Brand
            // 
            this.mDeviceModel_Brand.FormattingEnabled = true;
            this.mDeviceModel_Brand.Location = new System.Drawing.Point(6, 85);
            this.mDeviceModel_Brand.Name = "mDeviceModel_Brand";
            this.mDeviceModel_Brand.Size = new System.Drawing.Size(188, 21);
            this.mDeviceModel_Brand.TabIndex = 1;
            // 
            // mDeviceModel_Type
            // 
            this.mDeviceModel_Type.FormattingEnabled = true;
            this.mDeviceModel_Type.Location = new System.Drawing.Point(6, 45);
            this.mDeviceModel_Type.Name = "mDeviceModel_Type";
            this.mDeviceModel_Type.Size = new System.Drawing.Size(188, 21);
            this.mDeviceModel_Type.TabIndex = 0;
            // 
            // mDeviceModel_Name
            // 
            this.mDeviceModel_Name.Location = new System.Drawing.Point(6, 125);
            this.mDeviceModel_Name.MaxLength = 50;
            this.mDeviceModel_Name.Name = "mDeviceModel_Name";
            this.mDeviceModel_Name.Size = new System.Drawing.Size(188, 20);
            this.mDeviceModel_Name.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mDeviceBrand_DataGridView);
            this.groupBox3.Controls.Add(this.mDeviceBrand_Passive);
            this.groupBox3.Controls.Add(this.mDeviceBrand_Update);
            this.groupBox3.Controls.Add(this.mDeviceBrand_Add);
            this.groupBox3.Controls.Add(this.mDeviceBrand_Name);
            this.groupBox3.Location = new System.Drawing.Point(254, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 279);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Brand";
            // 
            // mDeviceBrand_DataGridView
            // 
            this.mDeviceBrand_DataGridView.AllowUserToAddRows = false;
            this.mDeviceBrand_DataGridView.AllowUserToDeleteRows = false;
            this.mDeviceBrand_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.mDeviceBrand_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDeviceBrand_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mDeviceBrand_DataGridView.Location = new System.Drawing.Point(6, 106);
            this.mDeviceBrand_DataGridView.MultiSelect = false;
            this.mDeviceBrand_DataGridView.Name = "mDeviceBrand_DataGridView";
            this.mDeviceBrand_DataGridView.RowHeadersVisible = false;
            this.mDeviceBrand_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDeviceBrand_DataGridView.Size = new System.Drawing.Size(188, 161);
            this.mDeviceBrand_DataGridView.TabIndex = 4;
            this.mDeviceBrand_DataGridView.SelectionChanged += new System.EventHandler(this.mDeviceBrand_DataGridView_SelectionChanged);
            // 
            // mDeviceBrand_Passive
            // 
            this.mDeviceBrand_Passive.Location = new System.Drawing.Point(104, 77);
            this.mDeviceBrand_Passive.Name = "mDeviceBrand_Passive";
            this.mDeviceBrand_Passive.Size = new System.Drawing.Size(90, 23);
            this.mDeviceBrand_Passive.TabIndex = 3;
            this.mDeviceBrand_Passive.Text = "Passive";
            this.mDeviceBrand_Passive.UseVisualStyleBackColor = true;
            this.mDeviceBrand_Passive.Click += new System.EventHandler(this.mDeviceBrand_Passive_Click);
            // 
            // mDeviceBrand_Update
            // 
            this.mDeviceBrand_Update.Location = new System.Drawing.Point(6, 77);
            this.mDeviceBrand_Update.Name = "mDeviceBrand_Update";
            this.mDeviceBrand_Update.Size = new System.Drawing.Size(90, 23);
            this.mDeviceBrand_Update.TabIndex = 2;
            this.mDeviceBrand_Update.Text = "Update";
            this.mDeviceBrand_Update.UseVisualStyleBackColor = true;
            this.mDeviceBrand_Update.Click += new System.EventHandler(this.mDeviceBrand_Update_Click);
            // 
            // mDeviceBrand_Add
            // 
            this.mDeviceBrand_Add.Location = new System.Drawing.Point(6, 48);
            this.mDeviceBrand_Add.Name = "mDeviceBrand_Add";
            this.mDeviceBrand_Add.Size = new System.Drawing.Size(188, 23);
            this.mDeviceBrand_Add.TabIndex = 1;
            this.mDeviceBrand_Add.Text = "Add";
            this.mDeviceBrand_Add.UseVisualStyleBackColor = true;
            this.mDeviceBrand_Add.Click += new System.EventHandler(this.mDeviceBrand_Add_Click);
            // 
            // mDeviceBrand_Name
            // 
            this.mDeviceBrand_Name.Location = new System.Drawing.Point(6, 19);
            this.mDeviceBrand_Name.MaxLength = 50;
            this.mDeviceBrand_Name.Name = "mDeviceBrand_Name";
            this.mDeviceBrand_Name.Size = new System.Drawing.Size(188, 20);
            this.mDeviceBrand_Name.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mDeviceType_DataGridView);
            this.groupBox2.Controls.Add(this.mDeviceType_Passive);
            this.groupBox2.Controls.Add(this.mDeviceType_Update);
            this.groupBox2.Controls.Add(this.mDeviceType_Add);
            this.groupBox2.Controls.Add(this.mDeviceType_Name);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Type";
            // 
            // mDeviceType_DataGridView
            // 
            this.mDeviceType_DataGridView.AllowUserToAddRows = false;
            this.mDeviceType_DataGridView.AllowUserToDeleteRows = false;
            this.mDeviceType_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.mDeviceType_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDeviceType_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mDeviceType_DataGridView.Location = new System.Drawing.Point(6, 106);
            this.mDeviceType_DataGridView.MultiSelect = false;
            this.mDeviceType_DataGridView.Name = "mDeviceType_DataGridView";
            this.mDeviceType_DataGridView.RowHeadersVisible = false;
            this.mDeviceType_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDeviceType_DataGridView.Size = new System.Drawing.Size(188, 161);
            this.mDeviceType_DataGridView.TabIndex = 4;
            this.mDeviceType_DataGridView.SelectionChanged += new System.EventHandler(this.mDeviceType_DataGridView_SelectionChanged);
            // 
            // mDeviceType_Passive
            // 
            this.mDeviceType_Passive.Location = new System.Drawing.Point(104, 77);
            this.mDeviceType_Passive.Name = "mDeviceType_Passive";
            this.mDeviceType_Passive.Size = new System.Drawing.Size(90, 23);
            this.mDeviceType_Passive.TabIndex = 3;
            this.mDeviceType_Passive.Text = "Passive";
            this.mDeviceType_Passive.UseVisualStyleBackColor = true;
            this.mDeviceType_Passive.Click += new System.EventHandler(this.mDeviceType_Passive_Click);
            // 
            // mDeviceType_Update
            // 
            this.mDeviceType_Update.Location = new System.Drawing.Point(6, 77);
            this.mDeviceType_Update.Name = "mDeviceType_Update";
            this.mDeviceType_Update.Size = new System.Drawing.Size(90, 23);
            this.mDeviceType_Update.TabIndex = 2;
            this.mDeviceType_Update.Text = "Update";
            this.mDeviceType_Update.UseVisualStyleBackColor = true;
            this.mDeviceType_Update.Click += new System.EventHandler(this.mDeviceType_Update_Click);
            // 
            // mDeviceType_Add
            // 
            this.mDeviceType_Add.Location = new System.Drawing.Point(6, 48);
            this.mDeviceType_Add.Name = "mDeviceType_Add";
            this.mDeviceType_Add.Size = new System.Drawing.Size(188, 23);
            this.mDeviceType_Add.TabIndex = 1;
            this.mDeviceType_Add.Text = "Add";
            this.mDeviceType_Add.UseVisualStyleBackColor = true;
            this.mDeviceType_Add.Click += new System.EventHandler(this.mDeviceType_Add_Click);
            // 
            // mDeviceType_Name
            // 
            this.mDeviceType_Name.Location = new System.Drawing.Point(6, 19);
            this.mDeviceType_Name.MaxLength = 50;
            this.mDeviceType_Name.Name = "mDeviceType_Name";
            this.mDeviceType_Name.Size = new System.Drawing.Size(188, 20);
            this.mDeviceType_Name.TabIndex = 0;
            // 
            // DeviceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(463, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DeviceManagement";
            this.Text = "Device Management";
            this.Load += new System.EventHandler(this.DeviceManagement_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDeviceModel_DataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDeviceBrand_DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDeviceType_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView mDeviceModel_DataGridView;
        private System.Windows.Forms.Button mDeviceModel_Passive;
        private System.Windows.Forms.Button mDeviceModel_Update;
        private System.Windows.Forms.Button mDeviceModel_Add;
        private System.Windows.Forms.ComboBox mDeviceModel_Brand;
        private System.Windows.Forms.ComboBox mDeviceModel_Type;
        private System.Windows.Forms.TextBox mDeviceModel_Name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView mDeviceBrand_DataGridView;
        private System.Windows.Forms.Button mDeviceBrand_Passive;
        private System.Windows.Forms.Button mDeviceBrand_Update;
        private System.Windows.Forms.Button mDeviceBrand_Add;
        private System.Windows.Forms.TextBox mDeviceBrand_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView mDeviceType_DataGridView;
        private System.Windows.Forms.Button mDeviceType_Passive;
        private System.Windows.Forms.Button mDeviceType_Update;
        private System.Windows.Forms.Button mDeviceType_Add;
        private System.Windows.Forms.TextBox mDeviceType_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}