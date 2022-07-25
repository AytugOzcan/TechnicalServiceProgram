using System;
using System.Windows.Forms;
using TechnicalService.DAL;

namespace TechnicalService
{
    public partial class UserOperations : Form
    {
        public UserOperations()
        {
            InitializeComponent();
        }

        UserOperationsDAL userOperationsDal = new UserOperationsDAL();
        LoginDAL loginDal = new LoginDAL();

        private void users_Update_Click(object sender, EventArgs e)
        {
            if (users_OldPassword.Text != "" && users_Password.Text != "" && users_Password2.Text != "") {
                if (users_Password.Text == users_Password2.Text)
                {
                    string oldPwd = MD5.MD5Hash(users_OldPassword.Text);
                    string result = loginDal.Password(oldPwd);
                    if (result.Contains("!") == true)
                    {
                        MessageBox.Show(result);
                    }
                    else
                    {
                        string pwd = MD5.MD5Hash(users_Password.Text);

                        result = userOperationsDal.Update(oldPwd, pwd);
                        Shared.showMessage(result);
                    }
                }
                else
                {
                    MessageBox.Show("The new passwords did not match!");
                }
            }
            else {
                MessageBox.Show("Text boxes cannot be left empty!");
            }
        }
    }
}
