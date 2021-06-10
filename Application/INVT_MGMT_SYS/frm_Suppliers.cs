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
    public partial class frm_supmast : Form
    {
        Connection c = new Connection();
        string QRY = string.Empty;

        public frm_supmast()
        {
            InitializeComponent();
        }

        private void frm_supmast_Load(object sender, EventArgs e)
        {
            BindMygridview();
            splitContainer1.Panel1.Enabled = false;
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

        void BindMygridview()
        {
            QRY = "select Sup_ID,Sup_Name,Sup_Address,Sup_Email,Sup_Mobile,Sup_Remarks from tbl1_SupMaster where Sup_Act = 'true' ORDER BY Sup_ID ASC";
            c.BindMyGrid(QRY, dtg_sup);
            if (dtg_sup.Rows.Count > 0)
                dtg_sup.Visible = true;
            else
                dtg_sup.Visible = false;
        }

        void Fillcontrols(int row)
        {
            lblSupID.Text = dtg_sup.Rows[row].Cells[0].Value.ToString();
            txt_Name.Text = dtg_sup.Rows[row].Cells[1].Value.ToString();
            txt_Address.Text = dtg_sup.Rows[row].Cells[2].Value.ToString();
            txt_email.Text = dtg_sup.Rows[row].Cells[3].Value.ToString();
            txt_mobile.Text = dtg_sup.Rows[row].Cells[4].Value.ToString();
            txt_remarks.Text = dtg_sup.Rows[row].Cells[5].Value.ToString();
        }

        private void dtg_cust_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fillcontrols(e.RowIndex);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            if (dtg_sup.Enabled == true)
            {
                dtg_sup.Enabled = false;
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
            BindMygridview();
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
                QRY = "DELETE FROM tbl1_SupMaster WHERE Sup_ID = " + lblSupID.Text.ToString() + "";
                c.TransMyData(QRY);
                BindMygridview();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Add")
            {
                EnableMainButtons(true);

                QRY = "Insert into tbl1_SupMaster values((SELECT MAX(Sup_ID) +1 from tbl1_SupMaster),'" + txt_Name.Text + "','" + txt_Address.Text + "','" + txt_email.Text + "','" + txt_mobile.Text + "','" + txt_remarks.Text + "','True')";
                c.TransMyData(QRY);
                BindMygridview();
                MessageBox.Show("Insert Data");
                splitContainer1.Panel1.Enabled = false;
                dtg_sup.Enabled = true;

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
                    QRY = "UPDATE tbl1_SupMaster SET Sup_NAME ='" + txt_Name.Text + "',Sup_Address = '" + txt_Address.Text + "',Sup_Email = '" + txt_email.Text + "',Sup_Mobile = '" + txt_mobile.Text + "', Sup_Remarks='" + txt_remarks.Text + "'  WHERE Sup_ID = " + lblSupID.Text.ToString() + "";
                    c.TransMyData(QRY);
                    BindMygridview();
                    MessageBox.Show("Update MyData");
                    splitContainer1.Panel1.Enabled = false;
                }

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearMyControls(string.Empty);
            splitContainer1.Panel1.Enabled = false;
            EnableMainButtons(true);
            dtg_sup.Enabled = true;
        }

        
    }
}
