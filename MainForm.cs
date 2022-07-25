using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TechnicalService.DAL;
using TechnicalService.Models;

namespace TechnicalService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ManagerAuthDAL managerAuth = new ManagerAuthDAL();
        RepairDAL repairDal = new RepairDAL();
        CustomerDAL customerDal = new CustomerDAL();
        DeviceDAL deviceDal = new DeviceDAL();
        OperationDAL operationDal = new OperationDAL();

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void userOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserOperations form4 = new UserOperations();
            form4.Show();
        }

        private void menuItemAuth(int a)
        {
            string result = managerAuth.Authority(a, Shared.user_id);
            if (result.Contains("!") == true)
            {
                MessageBox.Show(result);
            }
            else if (result == "Successful")
            {
                if (a == 1)
                {
                    EmployeeManagement form2 = new EmployeeManagement();
                    form2.Show();
                }
                else if (a == 2)
                {
                    UserManagement userManagement = new UserManagement();
                    userManagement.Show();
                }
                else if (a == 3)
                {
                    DeviceManagement deviceManagement = new DeviceManagement();
                    deviceManagement.Show();
                }
                else if (a == 4)
                {
                    OperationManagement operationManagement = new OperationManagement();
                    operationManagement.Show();
                }
                else if (a == 5)
                {
                    Payments paymentOperations = new Payments();
                    paymentOperations.Show();
                }
                else if (a == 6)
                {
                    CustomerOperations customerOperation = new CustomerOperations();
                    customerOperation.Show();
                }
                
            }
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemAuth(1);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemAuth(2);
        }

        private void deviceManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemAuth(3);
        }

        private void operationManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemAuth(4);
        }

        private void paymentOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemAuth(5);
        }

        private void customerOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemAuth(6);
        }
        
        private void pendingDevices_CheckedChanged(object sender, EventArgs e)
        {
            if (pendingDevices.Checked == true)
            {
                devices_DataGridView.Visible = true;
                GetPendingDevicesList();
                checkRepaired.Enabled = true;
                checkDelivered.Enabled = false;
                ClearForm();
            }
            else
            {
                devices_DataGridView.Visible = false;
            }
        }

        private void GetPendingDevicesList()
        {
            devices_DataGridView.DataSource = repairDal.GetPendingDevicesList();
            devices_DataGridView.Columns[0].Visible = false;
            int dg_width = devices_DataGridView.Width;
            int visible_column_count = devices_DataGridView.Columns.Count - 1;
            for (int i = 1; i < devices_DataGridView.Columns.Count; i++)
            {
                devices_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            devices_DataGridView.Columns[1].HeaderText = "Received Date";
            devices_DataGridView.Columns[2].HeaderText = "Type Name";
            devices_DataGridView.Columns[3].HeaderText = "Brand Name";
            devices_DataGridView.Columns[4].HeaderText = "Model Name";
            devices_DataGridView.Columns[5].HeaderText = "Operation";
            devices_DataGridView.Columns[6].HeaderText = "Description";
            devices_DataGridView.Columns[7].HeaderText = "Technician";
            devices_DataGridView.Columns[8].HeaderText = "Customer";
        }

        string repairid, cst_name, cst_id, opr_name;
        private void devices_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (devices_DataGridView.CurrentRow != null)
            {
                repairid = "";
                cst_name = "";
                cst_id = "";
                opr_name = "";
                int selectedIndex = devices_DataGridView.CurrentRow.Index;
                repairid = devices_DataGridView[0, selectedIndex].Value.ToString();
                receivedTimePicker.Value = Convert.ToDateTime(devices_DataGridView[1, selectedIndex].Value);
                device_Type.Text = devices_DataGridView[2, selectedIndex].Value.ToString();
                device_Brand.Text = devices_DataGridView[3, selectedIndex].Value.ToString();
                device_Model.Text = devices_DataGridView[4, selectedIndex].Value.ToString();
                repair_Operation.Text = devices_DataGridView[5, selectedIndex].Value.ToString();
                repair_Description.Text = devices_DataGridView[6, selectedIndex].Value.ToString();
                repair_Technician.Text = devices_DataGridView[7, selectedIndex].Value.ToString();
                cst_name = devices_DataGridView[8, selectedIndex].Value.ToString();
                cst_id = repairDal.GetCustomerID(1,repairid);
                opr_name = repair_Operation.Text;
                repair_Phone.Text = customerDal.GetCustomerPhone(cst_id);
                repair_Phone.Enabled = true;
            }
        }

        private void repairedDevices_CheckedChanged(object sender, EventArgs e)
        {
            if (repairedDevices.Checked == true)
            {
                devices_DataGridView1.Visible = true;
                GetRepairedDevicesList();
                checkRepaired.Enabled = false;
                checkDelivered.Enabled = true;
                ClearForm();
            }
            else
            {
                devices_DataGridView1.Visible = false;
            }
        }

        private void GetRepairedDevicesList()
        {
            devices_DataGridView1.DataSource = repairDal.GetRepairedDevicesList();
            devices_DataGridView1.Columns[0].Visible = false;
            int dg_width = devices_DataGridView1.Width;
            int visible_column_count = devices_DataGridView1.Columns.Count - 1;
            for (int i = 1; i < devices_DataGridView1.Columns.Count; i++)
            {
                devices_DataGridView1.Columns[i].Width = dg_width / visible_column_count;
            }
            devices_DataGridView1.Columns[1].HeaderText = "Repaired Date";
            devices_DataGridView1.Columns[2].HeaderText = "Type Name";
            devices_DataGridView1.Columns[3].HeaderText = "Brand Name";
            devices_DataGridView1.Columns[4].HeaderText = "Model Name";
            devices_DataGridView1.Columns[5].HeaderText = "Operation";
            devices_DataGridView1.Columns[6].HeaderText = "Description";
            devices_DataGridView1.Columns[7].HeaderText = "Technician";
            devices_DataGridView1.Columns[8].HeaderText = "Customer";
        }

        private void devices_DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (devices_DataGridView1.CurrentRow != null)
            {
                repairid = "";
                cst_name = "";
                cst_id = "";
                int selectedIndex = devices_DataGridView1.CurrentRow.Index;
                repairid = devices_DataGridView1[0, selectedIndex].Value.ToString();
                repairedTimePicker.Value = Convert.ToDateTime(devices_DataGridView1[1, selectedIndex].Value);
                device_Type.Text = devices_DataGridView1[2, selectedIndex].Value.ToString();
                device_Brand.Text = devices_DataGridView1[3, selectedIndex].Value.ToString();
                device_Model.Text = devices_DataGridView1[4, selectedIndex].Value.ToString();
                repair_Operation.Text = devices_DataGridView1[5, selectedIndex].Value.ToString();
                repair_Description.Text = devices_DataGridView1[6, selectedIndex].Value.ToString();
                repair_Technician.Text = devices_DataGridView1[7, selectedIndex].Value.ToString();
                cst_name = devices_DataGridView1[8, selectedIndex].Value.ToString();
                cst_id = repairDal.GetCustomerID(1,repairid);
                opr_name = repair_Operation.Text;
                repair_Phone.Text = customerDal.GetCustomerPhone(cst_id);
                repair_Phone.Enabled = true;
            }
        }

        private void deliveredDevices_CheckedChanged(object sender, EventArgs e)
        {
            if (deliveredDevices.Checked == true)
            {
                devices_DataGridView2.Visible = true;
                GetDeliveredDevicesList();
                checkRepaired.Enabled = false;
                checkDelivered.Enabled = false;
                ClearForm();
            }
            else
            {
                devices_DataGridView2.Visible = false;
            }
        }

        private void GetDeliveredDevicesList()
        {
            devices_DataGridView2.DataSource = repairDal.GetDeliveredDevicesList();
            devices_DataGridView2.Columns[0].Visible = false;
            int dg_width = devices_DataGridView2.Width;
            int visible_column_count = devices_DataGridView2.Columns.Count - 1;
            for (int i = 1; i < devices_DataGridView2.Columns.Count; i++)
            {
                devices_DataGridView2.Columns[i].Width = dg_width / visible_column_count;
            }
            devices_DataGridView2.Columns[1].HeaderText = "Delivered Date";
            devices_DataGridView2.Columns[2].HeaderText = "Type Name";
            devices_DataGridView2.Columns[3].HeaderText = "Brand Name";
            devices_DataGridView2.Columns[4].HeaderText = "Model Name";
            devices_DataGridView2.Columns[5].HeaderText = "Operation";
            devices_DataGridView2.Columns[6].HeaderText = "Description";
            devices_DataGridView2.Columns[7].HeaderText = "Technician";
            devices_DataGridView2.Columns[8].HeaderText = "Customer";
        }


        private void devices_DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (devices_DataGridView2.CurrentRow != null)
            {
                repairid = "";
                cst_name = "";
                cst_id = "";
                int selectedIndex = devices_DataGridView2.CurrentRow.Index;
                repairid = devices_DataGridView2[0, selectedIndex].Value.ToString();
                deliveredTimePicker.Value = Convert.ToDateTime(devices_DataGridView2[1, selectedIndex].Value);
                device_Type.Text = devices_DataGridView2[2, selectedIndex].Value.ToString();
                device_Brand.Text = devices_DataGridView2[3, selectedIndex].Value.ToString();
                device_Model.Text = devices_DataGridView2[4, selectedIndex].Value.ToString();
                repair_Operation.Text = devices_DataGridView2[5, selectedIndex].Value.ToString();
                repair_Description.Text = devices_DataGridView2[6, selectedIndex].Value.ToString();
                repair_Technician.Text = devices_DataGridView2[7, selectedIndex].Value.ToString();
                cst_name = devices_DataGridView2[8, selectedIndex].Value.ToString();
                cst_id = repairDal.GetCustomerID(1,repairid);
                opr_name = repair_Operation.Text;
                repair_Phone.Text = customerDal.GetCustomerPhone(cst_id);
                repair_Phone.Enabled = true;
            }
        }

        private void GetDeviceTypeComboBox()
        {
            List<DeviceType> DeviceTypeList = deviceDal.GetDeviceTypeList();
            foreach (var deviceType in DeviceTypeList)
            {
                device_Type.Items.Add(deviceType.device_type_name);
            }
        }

        private void GetDeviceBrandComboBox()
        {
            List<DeviceBrand> DeviceBrandList = deviceDal.GetDeviceBrandList();
            foreach (var deviceBrand in DeviceBrandList)
            {
                device_Brand.Items.Add(deviceBrand.device_brand_name);
            }
        }

        private void GetOperationComboBox()
        {
            List<Operation> OperationList = operationDal.GetOperationList();
            foreach (var operationList in OperationList)
            {
                repair_Operation.Items.Add(operationList.operation_name);
            }
        }

        private void GetTechnicianComboBox()
        {
            List<Technician> TechnicianList = repairDal.GetTechnicianList();
            foreach (var technicianList in TechnicianList)
            {
                repair_Technician.Items.Add(technicianList.employee_id+"-"+ technicianList.employee_fullname);
            }
        }

        private void ClearForm()
        {
            repair_Phone.Text = "";
            device_Type.Text = "";
            device_Brand.Text = "";
            device_Model.Text = "";
            device_Brand.Items.Clear();
            device_Model.Items.Clear();
            repair_Operation.Text = "";
            repair_Description.Text = "";
            repair_Technician.Text = "";
            repair_Phone.Enabled = true;
            checkRepaired.Checked = false;
            checkDelivered.Checked = false;
            receivedTimePicker.Value = DateTime.Now;
            repairedTimePicker.Value = DateTime.Now;
            deliveredTimePicker.Value = DateTime.Now;
        }

        private void device_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            device_Brand.Items.Clear();
            GetDeviceBrandComboBox();
        }

        private void device_Type_TextChanged(object sender, EventArgs e)
        {
            if (device_Type.Text == "")
            {
                device_Brand.Items.Clear();
            }
        }

        string dtype_id = "";

        private string GetDeviceTypeID(string dtype_name)
        {
            List<DeviceType> DeviceTypeList = deviceDal.GetDeviceTypeList();
            dtype_id = "";

            dtype_id = (from d in DeviceTypeList where d.device_type_name == dtype_name select d.device_type_id).FirstOrDefault().ToString();
            return dtype_id;
        }

        string dbrand_id = "";
        private string GetDeviceBrandID(string dbrand_name)
        {
            List<DeviceBrand> DeviceBrandList = deviceDal.GetDeviceBrandList();
            dbrand_id = "";

            dbrand_id = (from d in DeviceBrandList where d.device_brand_name == dbrand_name select d.device_brand_id).FirstOrDefault().ToString();
            return dbrand_id;
        }


        private void device_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type_id = GetDeviceTypeID(device_Type.Text);
            string brand_id = GetDeviceBrandID(device_Brand.Text);
            device_Model.Items.Clear();
            List<DeviceModel2> deviceModel2List = deviceDal.GetDeviceModel2List(type_id, brand_id);
            foreach (var deviceModel in deviceModel2List)
            {
                device_Model.Items.Add(deviceModel.device_model_name);
            }
        }


        private void repair_Add_Click(object sender, EventArgs e)
        {
            string result = managerAuth.Authority(7, Shared.user_id);
            if (result.Contains("!") == true)
            {
                MessageBox.Show(result);
            }
            else if (result == "Successful")
            { 
                if (repair_Phone.Enabled == false)
                {
                    if ((device_Type.Text != "") && (device_Brand.Text != "") && (device_Model.Text != "") && (repair_Operation.Text != "") && (repair_Description.Text != "") && (repair_Technician.Text != ""))
                    {
                        dtype_id = GetDeviceTypeID(device_Type.Text);
                        dbrand_id = GetDeviceBrandID(device_Brand.Text);
                        string dmodel_id = deviceDal.deviceModelIdQuery(device_Model.Text, dtype_id, dbrand_id);
                        if (dmodel_id.Contains("!") == true)
                        {
                            MessageBox.Show(dmodel_id);
                        }
                        else
                        {
                            string opr_id = operationDal.operationIdQuery(repair_Operation.Text);
                            if (opr_id.Contains("!") == true)
                            {
                                MessageBox.Show(opr_id);
                            }
                            else
                            {
                                string tech_id = "";
                                if (repair_Technician.Text.Contains("-") == true)
                                {
                                    int split_char = repair_Technician.Text.IndexOf("-");
                                    tech_id = repair_Technician.Text.Substring(0, split_char);
                                }
                                else
                                {
                                    tech_id = repairDal.GetTechnicianID(repairid);
                                    if (tech_id.Contains("!") == true)
                                    {
                                        MessageBox.Show(tech_id);
                                        return;
                                    }
                                }
                                result = repairDal.RepairAdd(repair_Description.Text, receivedTimePicker.Value.Date.ToString("yyyy-MM-dd"), cust_id, dmodel_id, opr_id, tech_id);
                                MessageBox.Show(result);
                                if (pendingDevices.Checked == true) { GetPendingDevicesList(); }
                                else if (repairedDevices.Checked == true) { GetRepairedDevicesList(); }
                                else if (deliveredDevices.Checked == true) { GetDeliveredDevicesList(); }
                                ClearForm();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("TextBoxes cannot be left blank!");
                    }

                }
                else
                {
                    MessageBox.Show("Customer inquiry failed!");
                }
            }
        }

        string cust_id;
        private void repair_CustQuery_Click(object sender, EventArgs e)
        {

            bool phoneCheck = Shared.PhoneNumberChecker(repair_Phone.Text);
            if (phoneCheck == true)
            {
                cust_id = repairDal.GetCustomerID(2, repair_Phone.Text);
                if (cust_id.Contains("!") == true)
                {
                    MessageBox.Show(cust_id);
                }
                else
                {
                    repair_Phone.Enabled = false;
                    MessageBox.Show("Customer record found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid phone number entered!");
            }
        }

        private void repair_Update_Click(object sender, EventArgs e)
        {
            string result = managerAuth.Authority(7, Shared.user_id);
            if (result.Contains("!") == true)
            {
                MessageBox.Show(result);
            }
            else if (result == "Successful")
            {
                if (repair_Phone.Enabled == false)
                {
                    if ((device_Type.Text != "") && (device_Brand.Text != "") && (device_Model.Text != "") && (repair_Operation.Text != "") && (repair_Description.Text != "") && (repair_Technician.Text != ""))
                    {
                        dtype_id = GetDeviceTypeID(device_Type.Text);
                        dbrand_id = GetDeviceBrandID(device_Brand.Text);
                        string dmodel_id = deviceDal.deviceModelIdQuery(device_Model.Text, dtype_id, dbrand_id);
                        if (dmodel_id.Contains("!") == true)
                        {
                            MessageBox.Show(dmodel_id);
                        }
                        else
                        {
                            string opr_id = operationDal.operationIdQuery(repair_Operation.Text);
                            if (opr_id.Contains("!") == true)
                            {
                                MessageBox.Show(opr_id);
                            }
                            else
                            {
                                string tech_id = "";
                                if (repair_Technician.Text.Contains("-") == true)
                                {
                                    int split_char = repair_Technician.Text.IndexOf("-");
                                    tech_id = repair_Technician.Text.Substring(0, split_char);
                                }
                                else
                                {
                                    tech_id = repairDal.GetTechnicianID(repairid);
                                    if (tech_id.Contains("!") == true)
                                    {
                                        MessageBox.Show(tech_id);
                                        return;
                                    }
                                }
                                result = repairDal.RepairUpdate(repairid, repair_Description.Text, receivedTimePicker.Value.Date.ToString("yyyy-MM-dd"), cust_id, dmodel_id, opr_id, tech_id);
                                MessageBox.Show(result);
                                if (pendingDevices.Checked == true) { GetPendingDevicesList(); }
                                else if (repairedDevices.Checked == true) { GetRepairedDevicesList(); }
                                else if (deliveredDevices.Checked == true) { GetDeliveredDevicesList(); }
                                ClearForm();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("TextBoxes cannot be left blank!");
                    }

                }
                else
                {
                    MessageBox.Show("Customer inquiry failed!");
                }
            }
           
        }

        private void checkRepaired_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRepaired.Checked == true)
            {
                string result = managerAuth.Authority(8, Shared.user_id);
                if (result.Contains("!") == true)
                {
                    MessageBox.Show(result);
                    checkRepaired.Checked = false;
                }
                else if (result == "Successful")
                {
                    DialogResult dialogResult = MessageBox.Show("Has the device been repaired?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        result = repairDal.DeviceRepaired(repairid, repairedTimePicker.Value.Date.ToString("yyyy-MM-dd"));
                        MessageBox.Show(result);
                    }
                    GetPendingDevicesList();
                    GetRepairedDevicesList();
                    GetDeliveredDevicesList();
                    ClearForm();
                }
            }


        }

        private void checkDelivered_CheckedChanged(object sender, EventArgs e)
        {
                if (checkDelivered.Checked == true)
                {
                    string result = managerAuth.Authority(9, Shared.user_id);
                    if (result.Contains("!") == true)
                    {
                        MessageBox.Show(result);
                        checkDelivered.Checked = false;
                    }
                    else if (result == "Successful")
                    {
                        string opr_price = operationDal.operationPriceQuery(opr_name);
                        if (opr_price.Contains("!") == true)
                        {
                            MessageBox.Show(opr_price);
                        }
                        else
                        {
                            int discount;
                            result = repairDal.CountRepaired(cst_id);
                            string result2 = repairDal.CountDelivered(cst_id);
                            string opr_price2 = "";
                            if ((Convert.ToInt16(result) == 3) && (Convert.ToInt16(result2) == 2))
                            {
                                discount = 30;
                                opr_price2 = (Convert.ToDouble(opr_price) * 0.7).ToString();
                            }
                            else
                            {
                                discount = 0;
                                opr_price2 = opr_price;
                            }
                            MessageBox.Show("The cost of the transaction: "+ opr_price + " TRY\n\nDiscount applied: " + discount + "%\n\nFee payable: " + opr_price2 + " TRY");
                            DialogResult dialogResult = MessageBox.Show("Has the transaction been paid for?", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                result = repairDal.DeviceDelivered(repairid, deliveredTimePicker.Value.Date.ToString("yyyy-MM-dd"), opr_price2, discount);
                                MessageBox.Show(result);
                            }
                            GetPendingDevicesList();
                            GetRepairedDevicesList();
                            GetDeliveredDevicesList();
                            ClearForm();
                        }
                    }
                }
            
        }

        private void repair_ClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetDeviceTypeComboBox();
            GetOperationComboBox();
            GetTechnicianComboBox();
            pendingDevices.Checked = true;
            device_Brand.Items.Clear();
            ClearForm();
        }
    }
}
