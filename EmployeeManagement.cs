using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TechnicalService.DAL;
using TechnicalService.Models;

namespace TechnicalService
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        EmpRoleDAL roleDal = new EmpRoleDAL();
        EmployeeDAL employeeDal = new EmployeeDAL();
        UserDAL userDal = new UserDAL();

        string role_id, emp_id, emp_role_id, emp_user_id;
        string auths_Employee = "0", auths_User = "0", auths_Device = "0", auths_Operation = "0", auths_Payment = "0";
        string auths_Customer = "0", auths_RepairReg = "0", auths_Repair = "0", auths_Delivery = "0";

        private void authsChecked()
        {
            if (auths_Employee == "0")
            {
                roleAuths_Employee.Checked = false;
            }
            else if(auths_Employee == "1")
            {
                roleAuths_Employee.Checked = true;
            }
            if (auths_User == "0")
            {
                roleAuths_User.Checked = false;
            }
            else if (auths_User == "1")
            {
                roleAuths_User.Checked = true;
            }
            if (auths_Device == "0")
            {
                roleAuths_Device.Checked = false;
            }
            else if (auths_Device == "1")
            {
                roleAuths_Device.Checked = true;
            }
            if (auths_Operation == "0")
            {
                roleAuths_Operation.Checked = false;
            }
            else if (auths_Operation == "1")
            {
                roleAuths_Operation.Checked = true;
            }
            if (auths_Payment == "0")
            {
                roleAuths_Payment.Checked = false;
            }
            else if (auths_Payment == "1")
            {
                roleAuths_Payment.Checked = true;
            }
            if (auths_Customer == "0")
            {
                roleAuths_Customer.Checked = false;
            }
            else if (auths_Customer == "1")
            {
                roleAuths_Customer.Checked = true;
            }
            if (auths_RepairReg == "0")
            {
                roleAuths_RepairReg.Checked = false;
            }
            else if (auths_RepairReg == "1")
            {
                roleAuths_RepairReg.Checked = true;
            }
            if (auths_Repair == "0")
            {
                roleAuths_Repair.Checked = false;
            }
            else if (auths_Repair == "1")
            {
                roleAuths_Repair.Checked = true;
            }
            if (auths_Delivery == "0")
            {
                roleAuths_Delivery.Checked = false;
            }
            else if (auths_Delivery == "1")
            {
                roleAuths_Delivery.Checked = true;
            }
        }

        private void role_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (role_DataGridView.CurrentRow != null)
            {
                int selectedIndex = role_DataGridView.CurrentRow.Index;
                role_id = role_DataGridView[0, selectedIndex].Value.ToString();
                role_Role.Text = role_DataGridView[1, selectedIndex].Value.ToString();
                auths_Employee = role_DataGridView[2, selectedIndex].Value.ToString();
                auths_User = role_DataGridView[3, selectedIndex].Value.ToString();
                auths_Device = role_DataGridView[4, selectedIndex].Value.ToString();
                auths_Operation = role_DataGridView[5, selectedIndex].Value.ToString();
                auths_Payment = role_DataGridView[6, selectedIndex].Value.ToString();
                auths_Customer = role_DataGridView[7, selectedIndex].Value.ToString();
                auths_RepairReg = role_DataGridView[8, selectedIndex].Value.ToString();
                auths_Repair = role_DataGridView[9, selectedIndex].Value.ToString();
                auths_Delivery = role_DataGridView[10, selectedIndex].Value.ToString();
                authsChecked();
            }
        }
        

        private void GetRoleList()
        {
            role_DataGridView.DataSource = roleDal.GetRoleList();
            role_DataGridView.Columns[0].Visible = false;
            int dg_width = role_DataGridView.Width;
            int visible_column_count = role_DataGridView.Columns.Count - 1;
            for (int i = 1; i < role_DataGridView.Columns.Count; i++)
            {
                role_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            role_DataGridView.Columns[1].HeaderText = "Role";
            role_DataGridView.Columns[2].HeaderText = "Employee Auths";
            role_DataGridView.Columns[3].HeaderText = "User Auths";
            role_DataGridView.Columns[4].HeaderText = "Device Auths";
            role_DataGridView.Columns[5].HeaderText = "Operation Auths";
            role_DataGridView.Columns[6].HeaderText = "Payment Auths";
            role_DataGridView.Columns[7].HeaderText = "Customer Auths";
            role_DataGridView.Columns[8].HeaderText = "Repair Registration Auths";
            role_DataGridView.Columns[9].HeaderText = "Repair Auths";
            role_DataGridView.Columns[10].HeaderText = "Delivery Auths";
        }

        private void GetRoleComboBox()
        {
            List<Role> roleList = roleDal.GetRoleList();
            emp_Role.Items.Clear();
            foreach (var role in roleList)
            {
                emp_Role.Items.Add(role.role_name);
            }
        }
        private string GetUserID(string user_name)
        {
            List<User> userList = userDal.GetUserList();
            string employee_user_id = "";

             employee_user_id = (from u in userList where u.user_name == user_name select u.user_id).FirstOrDefault().ToString();
            return employee_user_id;
        }

        private string GetRoleID(string role_name)
        {
            List<Role> roleList = roleDal.GetRoleList();
            string employee_role_id = "";

            employee_role_id = (from r in roleList where r.role_name == role_name select r.role_id).FirstOrDefault().ToString();
            return employee_role_id;
        }

        private void role_Add_Click(object sender, EventArgs e)
        {
            if (role_Role.Text == "")
            {
                MessageBox.Show("Role cannot be empty!");
            }
            else
            {
                string result = roleDal.authsAdd(auths_Employee, auths_User, auths_Device, auths_Operation, auths_Payment, auths_Customer, auths_RepairReg, auths_Repair, auths_Delivery);
                if (result.Contains("!") == true)
                {
                    MessageBox.Show(result);
                }
                else if(result.Contains(" ") == true)
                {
                    DialogResult dialogResult = MessageBox.Show("These authorizations are registered in a passive role. Would you like to reactivate this role?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        roleDal.roleActive(result.Trim());
                        Shared.showMessage("The role has been reactivated.");
                    }
                    else
                    {
                        result = "The operation was cancelled.";
                        Shared.showMessage(result);
                    }
                }
                else
                {
                    result = roleDal.roleAdd(role_Role.Text, result);
                    Shared.showMessage(result);
                }
                GetRoleList();
                GetRoleComboBox();
                ClearRoleForm();
            }
            
        }

        private void role_Update_Click(object sender, EventArgs e)
        {
            if (role_Role.Text == "")
            {
                MessageBox.Show("Role cannot be empty!");
            }
            else
            {
                string authid = roleDal.authidQuery(role_id);
                string result = roleDal.authsUpdate(authid, auths_Employee, auths_User, auths_Device, auths_Operation, auths_Payment, auths_Customer, auths_RepairReg, auths_Repair, auths_Delivery);
                if (result.Contains("!") == true)
                {
                    MessageBox.Show(result);
                }
                else
                {
                    result = roleDal.roleUpdate(role_id, role_Role.Text);
                    Shared.showMessage(result);
                    GetRoleList();
                    GetRoleComboBox();
                    ClearRoleForm();
                }
            }
        }

        private void role_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected role?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = roleDal.rolePassive(role_id);
                Shared.showMessage(result);
                GetRoleList();
                GetRoleComboBox();
                ClearEmpOprForm();
                ClearRoleForm();
            }
        }

        private void emp_IsEmpty(int a)
        {
            if (emp_FullName.Text == "")
            {
                MessageBox.Show("Full name cannot be empty!");
            }
            else if (emp_PhoneNumber.Text == "")
            {
                MessageBox.Show("Phone Number cannot be empty!");
            }
            else if (emp_Email.Text == "")
            {
                MessageBox.Show("Email cannot be empty!");
            }
            else if (emp_Address.Text == "")
            {
                MessageBox.Show("Address cannot be empty!");
            }
            else if (emp_Salary.Text == "")
            {
                MessageBox.Show("Salary cannot be empty!");
            }
            else if (emp_User_Name.Text == "")
            {
                MessageBox.Show("User name cannot be empty!");
            }
            else if (emp_Role.Text == "")
            {
                MessageBox.Show("Role cannot be empty!");
            }
            else
            {
                bool emailCheck = Shared.EmailChecker(emp_Email.Text);
                bool phoneCheck = Shared.PhoneNumberChecker(emp_PhoneNumber.Text);
                if ((emailCheck == true) && (phoneCheck == true))
                {
                    float salry;
                    bool isfloat = float.TryParse(emp_Salary.Text, out salry);
                    if ((isfloat == true) && (emp_Salary.Text.Contains(",") == false))
                    {
                        if (a == 1)
                        {
                            string result = userDal.UserQuery(emp_User_Name.Text);
                            if (result.Contains("!") == true)
                            {
                                userDal.UserAdd(emp_User_Name.Text, MD5.MD5Hash(emp_PhoneNumber.Text));
                            }
                            emp_user_id = GetUserID(emp_User_Name.Text);
                            emp_role_id = GetRoleID(emp_Role.Text);
                            result = employeeDal.EmployeeAdd(emp_FullName.Text, emp_PhoneNumber.Text, emp_Email.Text, emp_Address.Text, emp_Salary.Text, emp_role_id, emp_user_id);
                            Shared.showMessage(result);
                        }
                        else if (a == 2)
                        {
                            string result = userDal.UserQuery(emp_User_Name.Text);
                            if (result.Contains("!") == false)
                            {
                                emp_user_id = GetUserID(emp_User_Name.Text);
                                emp_role_id = GetRoleID(emp_Role.Text);
                                result = employeeDal.EmployeeUpdate(emp_id, emp_FullName.Text, emp_PhoneNumber.Text, emp_Email.Text, emp_Address.Text, emp_Salary.Text, emp_role_id, emp_user_id);
                                Shared.showMessage(result);
                            }
                        }
                        GetEmpList();
                    }
                    else
                    {
                        MessageBox.Show("The salary information was entered incorrectly!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid phone number or e-mail address entered!");
                }
            }
        }
        
        private void emp_Add_Click(object sender, EventArgs e)
        {
            emp_IsEmpty(1);
        }

        private void ClearRoleForm()
        {
            role_Role.Text = "";
            roleAuths_All.Checked = false;
            roleAuths_Employee.Checked = false;
            roleAuths_User.Checked = false;
            roleAuths_Device.Checked = false;
            roleAuths_Operation.Checked = false;
            roleAuths_Payment.Checked = false;
            roleAuths_Customer.Checked = false;
            roleAuths_RepairReg.Checked = false;
            roleAuths_Repair.Checked = false;
            roleAuths_Delivery.Checked = false;
        }

        private void ClearEmpOprForm()
        {
            emp_FullName.Text = "";
            emp_PhoneNumber.Text = "";
            emp_Email.Text = "";
            emp_Address.Text = "";
            emp_Salary.Text = "";
            emp_User_Name.Text = "";
            emp_Role.Text = "";
        }

        private void emp_ClearForm_Click(object sender, EventArgs e)
        {
            ClearEmpOprForm();
        }

        private void emp_Update_Click(object sender, EventArgs e)
        {
            emp_IsEmpty(2);
        }

        private void emp_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected employee?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = employeeDal.employeePassive(emp_id);
                Shared.showMessage(result);
                GetEmpList();
            }
        }

        private void roleAuths_All_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_All.Checked == true)
            {
                roleAuths_Employee.Checked = true;
                roleAuths_User.Checked = true;
                roleAuths_Device.Checked = true;
                roleAuths_Operation.Checked = true;
                roleAuths_Payment.Checked = true;
                roleAuths_Customer.Checked = true;
                roleAuths_RepairReg.Checked = true;
                roleAuths_Repair.Checked = true;
                roleAuths_Delivery.Checked = true;
            }
        }

        private void role_Clear_Click(object sender, EventArgs e)
        {
            ClearRoleForm();
        }
        
        private void roleAuths_Delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Delivery.Checked == true)
            {
                auths_Delivery = "1";
            }
            else
            {
                auths_Delivery = "0";
            }
        }

        private void roleAuths_Repair_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Repair.Checked == true)
            {
                auths_Repair = "1";
            }
            else
            {
                auths_Repair = "0";
            }
        }

        private void roleAuths_RepairReg_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_RepairReg.Checked == true)
            {
                auths_RepairReg = "1";
            }
            else
            {
                auths_RepairReg = "0";
            }
        }

        private void roleAuths_Customer_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Customer.Checked == true)
            {
                auths_Customer = "1";
            }
            else
            {
                auths_Customer = "0";
            }
        }

        private void roleAuths_Payment_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Payment.Checked == true)
            {
                auths_Payment = "1";
            }
            else
            {
                auths_Payment = "0";
            }
        }

        private void roleAuths_Operation_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Operation.Checked == true)
            {
                auths_Operation = "1";
            }
            else
            {
                auths_Operation = "0";
            }
        }

        private void roleAuths_Device_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Device.Checked == true)
            {
                auths_Device = "1";
            }
            else
            {
                auths_Device = "0";
            }
        }

        private void roleAuths_User_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_User.Checked == true)
            {
                auths_User = "1";
            }
            else
            {
                auths_User = "0";
            }
        }

        private void roleAuths_Employee_CheckedChanged(object sender, EventArgs e)
        {
            if (roleAuths_Employee.Checked == true)
            {
                auths_Employee = "1";
            }
            else
            {
                auths_Employee = "0";
            }
        }

        private void emp_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (emp_DataGridView.CurrentRow != null)
            {
                int selectedIndex = emp_DataGridView.CurrentRow.Index;
                emp_id = emp_DataGridView[0, selectedIndex].Value.ToString();
                emp_FullName.Text = emp_DataGridView[1, selectedIndex].Value.ToString();
                emp_PhoneNumber.Text = emp_DataGridView[2, selectedIndex].Value.ToString();
                emp_Email.Text = emp_DataGridView[3, selectedIndex].Value.ToString();
                emp_Address.Text = emp_DataGridView[4, selectedIndex].Value.ToString();
                emp_Salary.Text = emp_DataGridView[5, selectedIndex].Value.ToString();
                emp_User_Name.Text = emp_DataGridView[6, selectedIndex].Value.ToString();
                emp_Role.Text = emp_DataGridView[7, selectedIndex].Value.ToString();
            }
        }

        private void GetEmpList()
        {
            emp_DataGridView.DataSource = employeeDal.GetEmployeeList();
            emp_DataGridView.Columns[0].Visible = false;
            int dg_width = emp_DataGridView.Width;
            int visible_column_count = emp_DataGridView.Columns.Count - 1;
            for (int i = 1; i < emp_DataGridView.Columns.Count; i++)
            {
                emp_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            emp_DataGridView.Columns[1].HeaderText = "Full Name";
            emp_DataGridView.Columns[2].HeaderText = "Phone";
            emp_DataGridView.Columns[3].HeaderText = "Email";
            emp_DataGridView.Columns[4].HeaderText = "Address";
            emp_DataGridView.Columns[5].HeaderText = "Salary";
            emp_DataGridView.Columns[6].HeaderText = "User Name";
            emp_DataGridView.Columns[7].HeaderText = "Role";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetRoleList();
            GetEmpList();
            GetRoleComboBox();
            ClearEmpOprForm();
            ClearRoleForm();
        }

    }
}
