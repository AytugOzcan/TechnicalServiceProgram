using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TechnicalService.DAL;
using TechnicalService.Models;

namespace TechnicalService
{
    public partial class DeviceManagement : Form
    {
        DeviceDAL deviceDal = new DeviceDAL();
        public DeviceManagement()
        {
            InitializeComponent();
        }

        string mDeviceType_id, mDeviceBrand_id, mDeviceModel_id;
        private void GetDeviceTypeList()
        {
            mDeviceType_DataGridView.DataSource = deviceDal.GetDeviceTypeList();
            mDeviceType_DataGridView.Columns[0].Visible = false;
            int dg_width = mDeviceType_DataGridView.Width;
            int visible_column_count = mDeviceType_DataGridView.Columns.Count - 1;
            for (int i = 1; i < mDeviceType_DataGridView.Columns.Count; i++)
            {
                mDeviceType_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            mDeviceType_DataGridView.Columns[1].HeaderText = "Device Type";
        }

        private void mDeviceType_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mDeviceType_DataGridView.CurrentRow != null)
            {
                int selectedIndex = mDeviceType_DataGridView.CurrentRow.Index;
                mDeviceType_id = mDeviceType_DataGridView[0, selectedIndex].Value.ToString();
                mDeviceType_Name.Text = mDeviceType_DataGridView[1, selectedIndex].Value.ToString();
            }
        }
        

        private void GetDeviceBrandList()
        {
            mDeviceBrand_DataGridView.DataSource = deviceDal.GetDeviceBrandList();
            mDeviceBrand_DataGridView.Columns[0].Visible = false;
            int dg_width = mDeviceBrand_DataGridView.Width;
            int visible_column_count = mDeviceBrand_DataGridView.Columns.Count - 1;
            for (int i = 1; i < mDeviceBrand_DataGridView.Columns.Count; i++)
            {
                mDeviceBrand_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            mDeviceBrand_DataGridView.Columns[1].HeaderText = "Device Brand";
        }

        private void mDeviceBrand_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mDeviceBrand_DataGridView.CurrentRow != null)
            {
                int selectedIndex = mDeviceBrand_DataGridView.CurrentRow.Index;
                mDeviceBrand_id = mDeviceBrand_DataGridView[0, selectedIndex].Value.ToString();
                mDeviceBrand_Name.Text = mDeviceBrand_DataGridView[1, selectedIndex].Value.ToString();
            }
        }

        private void GetDeviceModelList()
        {
            mDeviceModel_DataGridView.DataSource = deviceDal.GetDeviceModelList();
            mDeviceModel_DataGridView.Columns[0].Visible = false;
            int dg_width = mDeviceModel_DataGridView.Width;
            int visible_column_count = mDeviceModel_DataGridView.Columns.Count - 1;
            for (int i = 1; i < mDeviceModel_DataGridView.Columns.Count; i++)
            {
                mDeviceModel_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            mDeviceModel_DataGridView.Columns[1].HeaderText = "Device Type";
            mDeviceModel_DataGridView.Columns[2].HeaderText = "Device Brand";
            mDeviceModel_DataGridView.Columns[3].HeaderText = "Device Model";
        }


        private void devicetype(int a)
        {
            if (mDeviceType_Name.Text == "")
            {
                MessageBox.Show("Device type cannot be empty!");
            }
            else
            {
                string result = "";
                if (a == 1) {
                    result = deviceDal.deviceTypeAdd(mDeviceType_Name.Text);
                }
                else if (a == 2)
                {
                    result = deviceDal.deviceTypeUpdate(mDeviceType_id, mDeviceType_Name.Text);
                }
                Shared.showMessage(result);
                GetDeviceTypeList();
                ClearForm();
            }
        }

        private void mDeviceType_Add_Click(object sender, EventArgs e)
        {
            devicetype(1);
            GetDeviceTypeComboBox();
            ClearForm();
        }

        private void mDeviceType_Update_Click(object sender, EventArgs e)
        {
            devicetype(2);
            GetDeviceTypeComboBox();
            ClearForm();
        }

        private void mDeviceType_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected device type?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = deviceDal.deviceTypePassive(mDeviceType_id);
                Shared.showMessage(result);
                GetDeviceTypeList();
                GetDeviceTypeComboBox();
                ClearForm();
            }
        }

        private void devicebrand(int a)
        {
            if (mDeviceBrand_Name.Text == "")
            {
                MessageBox.Show("Device brand cannot be empty!");
            }
            else
            {
                string result = "";
                if (a == 1)
                {
                    result = deviceDal.deviceBrandAdd(mDeviceBrand_Name.Text);
                }
                else if (a == 2)
                {
                    result = deviceDal.deviceBrandUpdate(mDeviceBrand_id, mDeviceBrand_Name.Text);
                }
                Shared.showMessage(result);
                GetDeviceBrandList();
                ClearForm();
            }
        }

        private void mDeviceBrand_Add_Click(object sender, EventArgs e)
        {
            devicebrand(1);
            GetDeviceBrandComboBox();
            ClearForm();
        }

        private void mDeviceBrand_Update_Click(object sender, EventArgs e)
        {
            devicebrand(2);
            GetDeviceBrandComboBox();
            ClearForm();
        }

        private void mDeviceBrand_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected brand?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = deviceDal.deviceBrandPassive(mDeviceBrand_id);
                Shared.showMessage(result);
                GetDeviceBrandList();
                GetDeviceBrandComboBox();
                ClearForm();
            }
        }

        private void mDeviceModel_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mDeviceModel_DataGridView.CurrentRow != null)
            {
                int selectedIndex = mDeviceModel_DataGridView.CurrentRow.Index;
                mDeviceModel_id = mDeviceModel_DataGridView[0, selectedIndex].Value.ToString();
                mDeviceModel_Type.Text = mDeviceModel_DataGridView[1, selectedIndex].Value.ToString();
                mDeviceModel_Brand.Text = mDeviceModel_DataGridView[2, selectedIndex].Value.ToString();
                mDeviceModel_Name.Text = mDeviceModel_DataGridView[3, selectedIndex].Value.ToString();
            }
        }

        private string GetDeviceTypeID(string dtype_name)
        {
            List<DeviceType> DeviceTypeList = deviceDal.GetDeviceTypeList();
            string dtype_id = "";

            dtype_id = (from d in DeviceTypeList where d.device_type_name == dtype_name select d.device_type_id).FirstOrDefault().ToString();
            return dtype_id;
        }

        private string GetDeviceBrandID(string dbrand_name)
        {
            List<DeviceBrand> DeviceBrandList = deviceDal.GetDeviceBrandList();
            string dbrand_id = "";

            dbrand_id = (from d in DeviceBrandList where d.device_brand_name == dbrand_name select d.device_brand_id).FirstOrDefault().ToString();
            return dbrand_id;
        }

        private void GetDeviceTypeComboBox()
        {
            List<DeviceType> DeviceTypeList = deviceDal.GetDeviceTypeList();
            mDeviceModel_Type.Items.Clear();
            foreach (var deviceType in DeviceTypeList)
            {
                mDeviceModel_Type.Items.Add(deviceType.device_type_name);
            }
        }
        
        private void GetDeviceBrandComboBox()
        {
            List<DeviceBrand> DeviceBrandList = deviceDal.GetDeviceBrandList();
            mDeviceModel_Brand.Items.Clear();
            foreach (var deviceBrand in DeviceBrandList)
            {
                mDeviceModel_Brand.Items.Add(deviceBrand.device_brand_name);
            }
        }

        private void devicemodel(int a)
        {
            if ((mDeviceModel_Type.Text == "") && (mDeviceModel_Brand.Text == "") && (mDeviceModel_Name.Text == ""))
            {
                MessageBox.Show("There is a defect(s) in the information entry!");
            }
            else
            {
                string type_id = GetDeviceTypeID(mDeviceModel_Type.Text);
                string brand_id = GetDeviceBrandID(mDeviceModel_Brand.Text);
                string result = "";
                if (a == 1)
                {
                    result = deviceDal.deviceModelAdd(mDeviceModel_Name.Text, type_id, brand_id);
                }
                else if (a == 2)
                {
                    result = deviceDal.deviceModelUpdate(mDeviceModel_id, mDeviceModel_Name.Text, type_id, brand_id); 
                }
                Shared.showMessage(result);
                GetDeviceModelList();
                ClearForm();
            }
        }

        private void mDeviceModel_Add_Click(object sender, EventArgs e)
        {
            devicemodel(1);
        }

        private void mDeviceModel_Update_Click(object sender, EventArgs e)
        {
            devicemodel(2);
        }

        private void mDeviceModel_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected device model?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = deviceDal.deviceModelPassive(mDeviceModel_id);
                Shared.showMessage(result);
                GetDeviceModelList();
                ClearForm();
            }
        }

        private void ClearForm()
        {
            mDeviceType_Name.Text = "";
            mDeviceBrand_Name.Text = "";
            mDeviceModel_Type.Text = "";
            mDeviceModel_Brand.Text = "";
            mDeviceModel_Name.Text = "";
        }

        private void DeviceManagement_Load(object sender, EventArgs e)
        {
            GetDeviceTypeList();
            GetDeviceBrandList();
            GetDeviceModelList();
            GetDeviceTypeComboBox();
            GetDeviceBrandComboBox();
            ClearForm();
        }


    }
}
