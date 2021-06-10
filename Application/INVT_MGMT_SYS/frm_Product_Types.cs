using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVT_MGMT_SYS
{
    public partial class frm_Product_Types : Form
    {
        public frm_Product_Types()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;

        void BindMyGrid()
        {
            QRY = "SELECT PTM_ID, PTM_Name From ";
            QRY += "tbl3_ProdTypeMaster";
            QRY += " WHERE ";
            QRY += "PTM_ID > 0 ";
            QRY += " AND PTM_Act = 'True'";
            QRY += " ORDER BY PTM_ID ASC";

            c.BindMyGrid(QRY, dtg_Ptype);
            if (dtg_Ptype.Rows.Count > 0)
            {
                dtg_Ptype.Visible = true;
            }
            else
            {
                dtg_Ptype.Visible = false;
            }
        }

        void EnableMyControls(bool b)
        {
            txt_name.Enabled = b;
            btn_Action.Enabled = b;
            btn_cancel.Enabled = b;
        }

        void EnableMainButtons(bool b)
        {
            btn_new.Enabled = b;
            btn_Edit.Enabled = b;
            btn_delete.Enabled = b;
        }

        void FillToControls(int RID)
        {
            lbl_id.Text = dtg_Ptype.Rows[RID].Cells[0].Value.ToString();
            txt_name.Text = dtg_Ptype.Rows[RID].Cells[1].Value.ToString();
        }

        private void frm_Product_Types_Load(object sender, EventArgs e)
        {
            BindMyGrid();
            EnableMainButtons(true);
            EnableMyControls(false);
            dtg_Ptype.Enabled = true;
         
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EnableMainButtons(false);
            EnableMyControls(true);
            dtg_Ptype.Enabled = false;
            txt_name.Clear();
            txt_name.Focus();
            btn_Action.Text = "ADD";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EnableMainButtons(false);
            EnableMyControls(true);
            dtg_Ptype.Enabled = true;
            txt_name.Focus();
            btn_Action.Text = "Update";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you Sure to Delete Data ??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == ans)
            {
                return;
            }
            else if (ans == DialogResult.Yes)
            {
                QRY = "Delete tbl3_ProdTypeMaster Where PTM_ID=" + lbl_id.Text + "";
                c.TransMyData(QRY);
            }
            lbl_id.Text = "";
            BindMyGrid();
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "ADD")
            {
                QRY = "INSERT INTO tbl3_ProdTypeMaster VALUES((SELECT MAX(PTM_ID) + 1 FROM tbl3_ProdTypeMaster), '" + txt_name.Text + "','TRUE')";

                 c.TransMyData(QRY);
                    
            }
            else if (btn_Action.Text == "Update")
            {
                QRY = "Update tbl3_ProdTypeMaster SET PTM_Name='" + txt_name.Text + "' Where PTM_ID = " + lbl_id.Text + "";

                    if (c.TransMyData(QRY) != 1)
                        MessageBox.Show("Data Not Updated");
            }


            btn_Action.Text = "Action";
            lbl_id.Text = "";
            EnableMyControls(false);
            EnableMainButtons(true);
            dtg_Ptype.Enabled = true;
            BindMyGrid();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnableMyControls(false);
            EnableMainButtons(true);
            dtg_Ptype.Enabled = true;

        }

        private void dtg_Ptype_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillToControls(e.RowIndex);
        }


    }
}
