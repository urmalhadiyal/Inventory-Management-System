using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INVT_MGMT_SYS
{
    public partial class frm_Customers : Form
    {
     //   string cnStr = "Data Source=PC180;Initial Catalog=DB_IMS;Integrated Security=True";
        Connection c = new Connection();
        string QRY = string.Empty;

        public frm_Customers()
        {
            InitializeComponent();
        }

        void EnableMainButtons(bool b)
        {
            btn_New.Enabled = b;
            btn_Edit.Enabled = b;
            btn_delete.Enabled = b;
        }

        void EnableMyControls(bool b)
        {
            txt_Name.Enabled = b;
            txt_Address.Enabled = b;
            txt_email.Enabled = b;
            txt_mobile.Enabled = b;
            txt_remarks.Enabled = b;
        }

        void ClearMyControls(string cl)
        {
            txt_Name.Text = txt_Address.Text = txt_mobile.Text = txt_email.Text = txt_remarks.Text = cl;
        }

        void BindMyGrid()
        {
            QRY = "select Cust_ID,Cust_Name,Cust_Address,Cust_Email,Cust_Mobile,Cust_Remarks from tbl9_CustMaster where Cust_Act = 'true' ORDER BY Cust_ID DESC";
            c.BindMyGrid(QRY, dtg_cust);
            if(dtg_cust.Rows.Count > 0)
                dtg_cust.Visible = true;
            else
                dtg_cust.Visible = false;

        }

        void Fillcontrols(int row)
        {
            lblcustID.Text = dtg_cust.Rows[row].Cells[0].Value.ToString();
            txt_Name.Text = dtg_cust.Rows[row].Cells[1].Value.ToString();
            txt_Address.Text = dtg_cust.Rows[row].Cells[2].Value.ToString();
            txt_email.Text = dtg_cust.Rows[row].Cells[3].Value.ToString();
            txt_mobile.Text = dtg_cust.Rows[row].Cells[4].Value.ToString();
            txt_remarks.Text = dtg_cust.Rows[row].Cells[5].Value.ToString();
        }

        private void dtg_cust_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fillcontrols(e.RowIndex);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            if (dtg_cust.Enabled == true)
            {
                dtg_cust.Enabled = false;
                btn_Save.Text = "Add";
                splitContainer1.Panel1.Enabled = true;
                ClearMyControls(string.Empty);
                EnableMainButtons(false);
                txt_Name.Focus();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            btn_Save.Text = "Update";
            splitContainer1.Panel1.Enabled = true;
            BindMyGrid();
            EnableMainButtons(false);
            txt_Name.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            EnableMainButtons(true);
            splitContainer1.Panel1.Enabled = false;
            DialogResult ans = MessageBox.Show("Are You Sure Delete Data??", "Delete Your Important Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == ans)
            {
                return;
            }
            else if (ans == DialogResult.Yes)
            {
                QRY = "DELETE FROM tbl9_CustMaster WHERE Cust_ID = " + lblcustID.Text.ToString() + "";
                c.TransMyData(QRY);
                BindMyGrid();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Add")
            {
                EnableMainButtons(true);

                QRY = "Insert into tbl9_CustMaster values((SELECT MAX(Cust_ID) +1 from tbl9_CustMaster),'" + txt_Name.Text + "','" + txt_Address.Text + "','" + txt_email.Text + "','" + txt_mobile.Text + "','" + txt_remarks.Text + "','True')";
                c.TransMyData(QRY);
                BindMyGrid();
                MessageBox.Show("Insert Data");
                splitContainer1.Panel1.Enabled = false;
                dtg_cust.Enabled = true;
            }

            else if (btn_Save.Text == "Update")
            {
                EnableMainButtons(true);
                DialogResult ans = MessageBox.Show("Do You Want To Edited Data ??", "Edit Your Important Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Cancel == ans)
                {
                    return;
                }
                else if (ans == DialogResult.Yes)
                {
                    QRY = "UPDATE tbl9_CustMaster SET Cust_NAME ='" + txt_Name.Text + "',Cust_Address = '" + txt_Address.Text + "',Cust_Email = '" + txt_email.Text + "',Cust_Mobile = '" + txt_mobile.Text + "',Cust_Remarks='" + txt_remarks.Text + "'  WHERE Cust_ID = " + lblcustID.Text.ToString() + "";
                    c.TransMyData(QRY);
                    BindMyGrid();
                    MessageBox.Show("Update MyData");
                    splitContainer1.Panel1.Enabled = false;
                }

            }
        }

        private void btn_Cancel_Click_Click(object sender, EventArgs e)
        {
            ClearMyControls(string.Empty);
            splitContainer1.Panel1.Enabled = false;
            EnableMainButtons(true);
            dtg_cust.Enabled = true;
            dtg_cust.Focus();
        }

        
        private void frm_Customers_Load(object sender, EventArgs e)
        {
            BindMyGrid();
            splitContainer1.Panel1.Enabled = false;
           
        }


    }
}
