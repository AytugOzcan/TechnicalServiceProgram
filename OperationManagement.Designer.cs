namespace TechnicalService
{
    partial class OperationManagement
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.opr_ClearForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opr_Passive = new System.Windows.Forms.Button();
            this.opr_Update = new System.Windows.Forms.Button();
            this.opr_Add = new System.Windows.Forms.Button();
            this.opr_DataGridView = new System.Windows.Forms.DataGridView();
            this.opr_Price = new System.Windows.Forms.TextBox();
            this.opr_Name = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opr_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.opr_ClearForm);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.opr_Passive);
            this.groupBox6.Controls.Add(this.opr_Update);
            this.groupBox6.Controls.Add(this.opr_Add);
            this.groupBox6.Controls.Add(this.opr_DataGridView);
            this.groupBox6.Controls.Add(this.opr_Price);
            this.groupBox6.Controls.Add(this.opr_Name);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(424, 179);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operation";
            // 
            // opr_ClearForm
            // 
            this.opr_ClearForm.Location = new System.Drawing.Point(6, 137);
            this.opr_ClearForm.Name = "opr_ClearForm";
            this.opr_ClearForm.Size = new System.Drawing.Size(94, 23);
            this.opr_ClearForm.TabIndex = 4;
            this.opr_ClearForm.Text = "Clear Form";
            this.opr_ClearForm.UseVisualStyleBackColor = true;
            this.opr_ClearForm.Click += new System.EventHandler(this.opr_ClearForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operation Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operation Name";
            // 
            // opr_Passive
            // 
            this.opr_Passive.Location = new System.Drawing.Point(103, 137);
            this.opr_Passive.Name = "opr_Passive";
            this.opr_Passive.Size = new System.Drawing.Size(95, 23);
            this.opr_Passive.TabIndex = 5;
            this.opr_Passive.Text = "Passive";
            this.opr_Passive.UseVisualStyleBackColor = true;
            this.opr_Passive.Click += new System.EventHandler(this.opr_Passive_Click);
            // 
            // opr_Update
            // 
            this.opr_Update.Location = new System.Drawing.Point(103, 108);
            this.opr_Update.Name = "opr_Update";
            this.opr_Update.Size = new System.Drawing.Size(95, 23);
            this.opr_Update.TabIndex = 3;
            this.opr_Update.Text = "Update";
            this.opr_Update.UseVisualStyleBackColor = true;
            this.opr_Update.Click += new System.EventHandler(this.opr_Update_Click);
            // 
            // opr_Add
            // 
            this.opr_Add.Location = new System.Drawing.Point(4, 108);
            this.opr_Add.Name = "opr_Add";
            this.opr_Add.Size = new System.Drawing.Size(96, 23);
            this.opr_Add.TabIndex = 2;
            this.opr_Add.Text = "Add";
            this.opr_Add.UseVisualStyleBackColor = true;
            this.opr_Add.Click += new System.EventHandler(this.opr_Add_Click);
            // 
            // opr_DataGridView
            // 
            this.opr_DataGridView.AllowUserToAddRows = false;
            this.opr_DataGridView.AllowUserToDeleteRows = false;
            this.opr_DataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.opr_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opr_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.opr_DataGridView.Location = new System.Drawing.Point(216, 34);
            this.opr_DataGridView.MultiSelect = false;
            this.opr_DataGridView.Name = "opr_DataGridView";
            this.opr_DataGridView.RowHeadersVisible = false;
            this.opr_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.opr_DataGridView.Size = new System.Drawing.Size(202, 129);
            this.opr_DataGridView.TabIndex = 6;
            this.opr_DataGridView.SelectionChanged += new System.EventHandler(this.opr_DataGridView_SelectionChanged);
            // 
            // opr_Price
            // 
            this.opr_Price.Location = new System.Drawing.Point(5, 73);
            this.opr_Price.MaxLength = 6;
            this.opr_Price.Name = "opr_Price";
            this.opr_Price.Size = new System.Drawing.Size(193, 20);
            this.opr_Price.TabIndex = 1;
            // 
            // opr_Name
            // 
            this.opr_Name.Location = new System.Drawing.Point(5, 34);
            this.opr_Name.MaxLength = 100;
            this.opr_Name.Name = "opr_Name";
            this.opr_Name.Size = new System.Drawing.Size(193, 20);
            this.opr_Name.TabIndex = 0;
            // 
            // OperationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(447, 205);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OperationManagement";
            this.Text = "Operation Management";
            this.Load += new System.EventHandler(this.OperationManagement_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opr_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button opr_Passive;
        private System.Windows.Forms.Button opr_Update;
        private System.Windows.Forms.Button opr_Add;
        private System.Windows.Forms.DataGridView opr_DataGridView;
        private System.Windows.Forms.TextBox opr_Price;
        private System.Windows.Forms.TextBox opr_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opr_ClearForm;
    }
}