using System;
using System.Windows.Forms;
using TechnicalService.DAL;

namespace TechnicalService
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        LoginDAL loginDal = new LoginDAL();

        private void log_in()
        {
            string pwd = MD5.MD5Hash(login_Password.Text);

            string result = loginDal.Login(login_UserName.Text.Trim(), pwd);
            if (result.Contains("!") == true)
            {
                MessageBox.Show(result);
            }
            else
            {
                MainForm form3 = new MainForm();
                form3.Show();
                this.Visible = false;
            }
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            log_in();      
        }

        private void login_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log_in();
            }
        }

        private void login_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log_in();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
