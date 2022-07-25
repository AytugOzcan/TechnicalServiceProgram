using System;
using System.Windows.Forms;
using TechnicalService.DAL;

namespace TechnicalService
{
    public partial class UserManagement : Form
    {
        UserDAL userDal = new UserDAL();
        public UserManagement()
        {
            InitializeComponent();
        }

        private void GetUserList()
        {
            mUsers_DataGridView.DataSource = userDal.GetUserList();
            mUsers_DataGridView.Columns[0].Visible = false;
            int dg_width = mUsers_DataGridView.Width;
            int visible_column_count = mUsers_DataGridView.Columns.Count - 1;
            for (int i = 1; i < mUsers_DataGridView.Columns.Count; i++)
            {
                mUsers_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            mUsers_DataGridView.Columns[1].HeaderText = "User Name";
        }

        string mUsers_id;
        private void mUsers_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mUsers_DataGridView.CurrentRow != null)
            {
                int selectedIndex = mUsers_DataGridView.CurrentRow.Index;
                mUsers_id = mUsers_DataGridView[0, selectedIndex].Value.ToString();
                mUsers_UserName.Text = mUsers_DataGridView[1, selectedIndex].Value.ToString();
            }
        }

        private void mUsers_IsEmpty(int a)
        {
            if (mUsers_UserName.Text == "")
            {
                MessageBox.Show("User name cannot be empty!");
            }
            else if (mUsers_Password.Text == "")
            {
                MessageBox.Show("New password cannot be empty!");
            }
            else if (mUsers_Password2.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty!");
            }
            else
            {
                string result = "";
                if (a == 1)
                {
                    result = userDal.UserQuery(mUsers_UserName.Text);
                    if (result.Contains("!") == true)
                    {
                        result = userDal.UserAdd(mUsers_UserName.Text, MD5.MD5Hash(mUsers_Password.Text));
                    }
                }
                else if (a == 2)
                {
                    result = userDal.UserUpdate(mUsers_id, mUsers_UserName.Text, MD5.MD5Hash(mUsers_Password.Text));      
                }
                Shared.showMessage(result);
                GetUserList();
                ClearForm();
            }
        }

        private void mUsers_Add_Click(object sender, EventArgs e)
        {
            if (mUsers_Password.Text == mUsers_Password2.Text)
            {
                mUsers_IsEmpty(1);
            }
            else
            {
                MessageBox.Show("The new passwords did not match!");
            }
            
        }

        private void mUsers_Update_Click(object sender, EventArgs e)
        {
            if (mUsers_Password.Text == mUsers_Password2.Text)
            {
                mUsers_IsEmpty(2);
            }
            else
            {
                MessageBox.Show("The new passwords did not match!");
            }
        }

        private void mUsers_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected user?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = userDal.UserPassive(mUsers_id);
                Shared.showMessage(result);
                GetUserList();
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            GetUserList();
            ClearForm();
        }


        private void mUsers_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this user?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = userDal.UserDelete(mUsers_id);
                Shared.showMessage(result);
                GetUserList();
            }
        }

        private void ClearForm()
        {
            mUsers_UserName.Text = "";
            mUsers_Password.Text = "";
            mUsers_Password2.Text = "";
        }

        private void mUsers_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
