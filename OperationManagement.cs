using System;
using System.Windows.Forms;
using TechnicalService.DAL;

namespace TechnicalService
{
    public partial class OperationManagement : Form
    {
        public OperationManagement()
        {
            InitializeComponent();
        }
        OperationDAL operationDal = new OperationDAL();
        
        private void GetOperationList()
        {
            opr_DataGridView.DataSource = operationDal.GetOperationList();
            opr_DataGridView.Columns[0].Visible = false;
            int dg_width = opr_DataGridView.Width;
            int visible_column_count = opr_DataGridView.Columns.Count - 1;
            for (int i = 1; i < opr_DataGridView.Columns.Count; i++)
            {
                opr_DataGridView.Columns[i].Width = dg_width / visible_column_count;
            }
            opr_DataGridView.Columns[1].HeaderText = "Operation Name";
            opr_DataGridView.Columns[2].HeaderText = "Operation Price";
        }

        string opr_id;

        private void opr_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (opr_DataGridView.CurrentRow != null)
            {
                int selectedIndex = opr_DataGridView.CurrentRow.Index;
                opr_id = opr_DataGridView[0, selectedIndex].Value.ToString();
                opr_Name.Text = opr_DataGridView[1, selectedIndex].Value.ToString();
                opr_Price.Text = opr_DataGridView[2, selectedIndex].Value.ToString();
            }
        }


        private void opr(int a)
        {
            if (opr_Name.Text == "")
            {
                MessageBox.Show("Operation name cannot be empty!");
            }
            else
            {
                float salry;
                bool isfloat = float.TryParse(opr_Price.Text, out salry);
                if ((isfloat == true) && (opr_Price.Text.Contains(",") == false))
                {
                    string result = "";
                    if (a == 1)
                    {
                        result = operationDal.operationAdd(opr_Name.Text, opr_Price.Text);
                    }
                    else if (a == 2)
                    {
                        result = operationDal.operationUpdate(opr_id, opr_Name.Text, opr_Price.Text);
                    }
                    Shared.showMessage(result);
                }
                else
                {
                    MessageBox.Show("The price entry format is not correct.");
                }
                GetOperationList();
                ClearForm();
            }
        }

        private void opr_Add_Click(object sender, EventArgs e)
        {
                opr(1);
        }

        private void opr_Update_Click(object sender, EventArgs e)
        {
                opr(2);
        }

        private void opr_Passive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to passive the selected operation?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = operationDal.operationPassive(opr_id);
                Shared.showMessage(result);
                GetOperationList();
                ClearForm();
            }
        }

        private void OperationManagement_Load(object sender, EventArgs e)
        {
            GetOperationList();
            ClearForm();
        }

        private void ClearForm()
        {
            opr_Name.Text = "";
            opr_Price.Text = "";
        }

        private void opr_ClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
