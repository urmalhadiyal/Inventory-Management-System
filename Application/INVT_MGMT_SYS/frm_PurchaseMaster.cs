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
    public partial class frm_PurchaseMaster : Form
    {
        public frm_PurchaseMaster()
        {
            InitializeComponent();
        }


        Connection c = new Connection();
        String QRY = String.Empty;

        void BindMyGrid()
        {
            QRY = "SELECT PM.Pur_ID, PM.OM_ID, PM.Pur_Date, PM.Pur_InvNo, SM.Sup_Name, PM.Pur_Qty, PM.Pur_TotAmt, PM.Pur_PayType, TM.Tm_Name, PM.Pur_Remarks FROM ";
            QRY += "tbl7_PurchaseMaster PM,tbl1_SupMaster SM,tbl2_TransMaster TM,tbl5_OrderMaster OM";
            QRY += " WHERE ";
            QRY += "PM.Sup_ID = SM.Sup_ID";
            QRY += " AND OM.OM_ID = PM.OM_ID";
            QRY += " AND TM.Tm_ID = PM.Tm_ID";
            QRY += " AND PM.Pur_ID > 0";
            QRY += " AND PM.Pur_Act = 'True'";
            QRY += " ORDER BY PM.Pur_Date DESC";

            c.BindMyGrid(QRY, dtg_PM);
            if (dtg_PM.Rows.Count > 0)
            {
                dtg_PM.Visible = true;
                btn_edit.Enabled = btn_delete.Enabled = true;
            }
            else
            {
                dtg_PM.Visible = false;
                btn_edit.Enabled = btn_delete.Enabled = false;
            }
        }

        void search(string name, string value)
        {
            QRY = "SELECT PM.Pur_ID, PM.OM_ID, PM.Pur_Date, PM.Pur_InvNo, SM.Sup_Name, PM.Pur_Qty, PM.Pur_TotAmt, PM.Pur_PayType, TM.Tm_Name, PM.Pur_Remarks FROM ";
            QRY += "tbl7_PurchaseMaster PM,tbl1_SupMaster SM,tbl2_TransMaster TM,tbl5_OrderMaster OM";
            QRY += " WHERE ";
            QRY += "PM.Sup_ID = SM.Sup_ID";
            QRY += " AND (" + name + " like '%" + value + "%')";
            QRY += " AND OM.OM_ID = PM.OM_ID";
            QRY += " AND TM.Tm_ID = PM.Tm_ID";
            QRY += " AND PM.Pur_ID > 0";
            QRY += " AND PM.Pur_Act = 'True'";
            QRY += " ORDER BY PM.Pur_Date DESC";

            c.BindMyGrid(QRY, dtg_PM);
            if (dtg_PM.Rows.Count > 0)
            {
                dtg_PM.Visible = true;
            }
            else dtg_PM.Visible = false;
        }

        private void frm_PurchaseMaster_Load(object sender, EventArgs e)
        {
            BindMyGrid();
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form f = new frm_Purchase_List();
            f.Text = "New Purchase Invoice";
            f.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Form f = new frm_Purchase_List(lbl_PM.Text.ToString());
            f.Text = "Edit Purchase Invoice";
            f.ShowDialog();
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
                QRY = "Delete tbl7_PurchaseMaster Where Pur_ID=" + lbl_PM.Text + "";
                c.TransMyData(QRY);

                QRY = "Delete tbl8_PurListMaster Where Pur_ID = " + lbl_PM.Text + "";
                c.TransMyData(QRY);
            }
            lbl_PM.Text = "";
            BindMyGrid();
        }

        private void dtg_PM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lbl_PM.Text = dtg_PM.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void frm_PurchaseMaster_Activated(object sender, EventArgs e)
        {
            BindMyGrid();
        }

        private void txt_order_id_TextChanged(object sender, EventArgs e)
        {
            string s = "PM.OM_ID";
            search(s, txt_order_id.Text);
        }

        private void txt_inv_no_TextChanged(object sender, EventArgs e)
        {
            string s = "PM.Pur_InvNo";
            search(s, txt_inv_no.Text);
        }

        private void txt_SupName_TextChanged(object sender, EventArgs e)
        {
            string s = "SM.Sup_Name";
            search(s, txt_SupName.Text.ToString());
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            QRY = "SELECT PM.Pur_ID, PM.OM_ID, PM.Pur_Date, PM.Pur_InvNo, SM.Sup_Name, PM.Pur_Qty, PM.Pur_TotAmt, PM.Pur_PayType, TM.Tm_Name, PM.Pur_Remarks FROM ";
            QRY += "tbl7_PurchaseMaster PM,tbl1_SupMaster SM,tbl2_TransMaster TM,tbl5_OrderMaster OM";
            QRY += " WHERE ";
            QRY += "PM.Sup_ID = SM.Sup_ID";
            QRY += " AND PM.Pur_Date = '" + dtp_search_date.Text.ToString() + "'";
            QRY += " AND OM.OM_ID = PM.OM_ID";
            QRY += " AND TM.Tm_ID = PM.Tm_ID";
            QRY += " AND PM.Pur_ID > 0";
            QRY += " AND PM.Pur_Act = 'True'";
            QRY += " ORDER BY PM.Pur_Date DESC";

            c.BindMyGrid(QRY, dtg_PM);
            if (dtg_PM.Rows.Count > 0)
            {
                dtg_PM.Visible = true;
            }
            else dtg_PM.Visible = false;
        }

        
    }
}
