using System;
using System.Windows.Forms;
using TechnicalService.DAL;

namespace TechnicalService
{
    public partial class CustomerOperations : Form
    {
        public CustomerOperations()
        {
            InitializeComponent();
        }
        CustomerDAL customerDal = new CustomerDAL();

        private void CustomerOperations_Load(object sender, EventArgs e)
        {
            GetCustomerList();
            ClearForm();
        }

        string cust_id;
        private void cust_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (cust_DataGridView.CurrentRow!=null)
            {
                int selectedIndex = cust_DataGridView.CurrentRow.Index;
                cust_id = cust_DataGridView[0, selectedIndex].Value.ToString();
                cust_FullName.Text = cust_DataGridView[1, selectedIndex].Value.ToString();
                cust_PhoneNumber.Text = cust_DataGridView[2, selectedIndex].Value.ToString();
                cust_Email.Text = cust_DataGridView[3, selectedIndex].Value.ToString();
                cust_Address.Text = cust_DataGridView[4, selectedIndex].Value.ToString();
            }
        }

        private void GetCustomerList()
        {
            cust_DataGridView.DataSource = customerDal.GetCustomerList();
            cust_DataGridView.Columns[0].Visible = false;
            int dg_width = cust_DataGridView.Width;
            int visible_column_count = cust_DataGridView.Columns.Count - 1;
            for (int i = 1; i < cust_DataGridView.Columns.Count; i++)
            {
                cust_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            cust_DataGridView.Columns[1].HeaderText = "Full Name";
            cust_DataGridView.Columns[2].HeaderText = "Phone";
            cust_DataGridView.Columns[3].HeaderText = "Email";
            cust_DataGridView.Columns[4].HeaderText = "Address";
        }

        private void cust_IsEmpty(int a)
        {
            if (cust_FullName.Text == "")
            {
                MessageBox.Show("Full name cannot be empty!");
            }
            else if (cust_PhoneNumber.Text == "")
            {
                MessageBox.Show("Phone Number cannot be empty!");
            }
            else if (cust_Email.Text == "")
            {
                MessageBox.Show("Email cannot be empty!");
            }
            else if (cust_Address.Text == "")
            {
                MessageBox.Show("Address cannot be empty!");
            }
            else
            {
                bool emailCheck = Shared.EmailChecker(cust_Email.Text);
                bool phoneCheck = Shared.PhoneNumberChecker(cust_PhoneNumber.Text);
                if ((emailCheck == true) && (phoneCheck == true))
                {
                    string result = "";
                    if (a == 1)
                    {
                        result = customerDal.CustomerAdd(cust_FullName.Text, cust_PhoneNumber.Text, cust_Email.Text, cust_Address.Text);
                    }
                    else if (a == 2)
                    {
                        result = customerDal.CustomerUpdate(cust_id, cust_FullName.Text, cust_PhoneNumber.Text, cust_Email.Text, cust_Address.Text);
                    }
                    Shared.showMessage(result);
                    GetCustomerList();
                }
                else
                {
                    MessageBox.Show("Invalid phone number or e-mail address entered!");
                }
            }
        }

        private void cust_Add_Click(object sender, EventArgs e)
        {
            cust_IsEmpty(1);
        }

        private void cust_Update_Click(object sender, EventArgs e)
        {
            cust_IsEmpty(2);
        }

        private void ClearForm()
        {
            cust_FullName.Text = "";
            cust_PhoneNumber.Text = "";
            cust_Email.Text = "";
            cust_Address.Text = "";
        }

        private void cust_ClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
