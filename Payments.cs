using System;
using System.Windows.Forms;
using TechnicalService.DAL;

namespace TechnicalService
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        PaymentDAL paymentDal = new PaymentDAL();

        private void GetPaymentList()
        {
            payment_DataGridView.DataSource = paymentDal.GetPaymentList();
            payment_DataGridView.Columns[0].Visible = false;
            int dg_width = payment_DataGridView.Width;
            int visible_column_count = payment_DataGridView.Columns.Count - 1;
            for (int i = 1; i < payment_DataGridView.Columns.Count; i++)
            {
                payment_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            payment_DataGridView.Columns[1].HeaderText = "Delivered Date";
            payment_DataGridView.Columns[2].HeaderText = "Repaired Date";
            payment_DataGridView.Columns[3].HeaderText = "Customer";
            payment_DataGridView.Columns[4].HeaderText = "Price (TRY)";
            payment_DataGridView.Columns[5].HeaderText = "Applied Discount (%)";
            payment_DataGridView.Columns[6].HeaderText = "Device Type";
            payment_DataGridView.Columns[7].HeaderText = "Device Brand";
            payment_DataGridView.Columns[8].HeaderText = "Device Model";
            payment_DataGridView.Columns[9].HeaderText = "Repair Description";
        }

        string paymentid;
        private void payment_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (payment_DataGridView.CurrentRow != null)
            {
                int selectedIndex = payment_DataGridView.CurrentRow.Index;
                paymentid = payment_DataGridView[0, selectedIndex].Value.ToString();
            }
        }

        private void PaymentOperations_Load(object sender, EventArgs e)
        {
            GetPaymentList();
        }

    }
}
