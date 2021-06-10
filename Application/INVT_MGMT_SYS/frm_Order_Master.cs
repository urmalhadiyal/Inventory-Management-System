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
    public partial class frm_Order_Master : Form
    {
        public frm_Order_Master()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;

        void BindMyGrid()
        {
            QRY = "SELECT OM.OM_ID, OM.OM_Date, SM.Sup_Name, OM.OM_Qty, OM.OM_TOT_AMT, OM.OM_Remarks FROM ";
            QRY += "tbl5_OrderMaster OM,tbl1_SupMaster SM";
            QRY += " WHERE ";
            QRY += "OM.Sup_ID = SM.Sup_ID";
            QRY += " AND OM.OM_ID > 0";
            QRY += " AND OM.OM_Act = 'True'";
            QRY += " ORDER BY OM.OM_ID DESC";

            c.BindMyGrid(QRY, dtg_OM);
            if (dtg_OM.Rows.Count > 0)
            {
                dtg_OM.Visible = true;
                btn_Delete.Enabled = btn_Edit.Enabled = true;
            }
            else { dtg_OM.Visible = false; btn_Delete.Enabled = btn_Edit.Enabled = false; }
        }

        void search(string name,string value)
        {
            QRY = "SELECT OM.OM_ID, OM.OM_Date, SM.Sup_Name, OM.OM_Qty, OM.OM_TOT_AMT, OM.OM_Remarks FROM ";
            QRY += "tbl5_OrderMaster OM,tbl1_SupMaster SM";
            QRY += " WHERE ";
            QRY += "OM.Sup_ID = SM.Sup_ID";
            QRY += " AND ("+name+" like '%" + value + "%')";
            QRY += " AND OM.OM_ID > 0";
            QRY += " AND OM.OM_Act = 'True'";
            QRY += " ORDER BY OM.OM_ID DESC";


            c.BindMyGrid(QRY, dtg_OM);
            if (dtg_OM.Rows.Count > 0)
            {
                dtg_OM.Visible = true;
                
            }
            else
            
                dtg_OM.Visible = false;
               
        }

        private void frm_Order_Master_Load(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            BindMyGrid();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form f = new frm_Order_List();
            f.Text = "NEW ORDER";
            f.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form f = new frm_Order_List(lbl_OMID.Text);
            f.Text = "EDIT ORDER";
            f.ShowDialog();
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you Sure to Delete Data ??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == ans)
            {
                return;
            }
            else if (ans == DialogResult.Yes)
            {
                QRY = "Delete tbl5_OrderMaster Where OM_ID=" + lbl_OMID.Text + "";
                c.TransMyData(QRY);
                
                QRY = "Delete tbl6_OrderListMaster Where OM_ID = " + lbl_OMID.Text + "";
                c.TransMyData(QRY);
            }
            lbl_OMID.Text = "";
            BindMyGrid();
            
        }

        private void frm_Order_Master_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dtg_OM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lbl_OMID.Text = dtg_OM.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            string s="OM.OM_ID";
            search(s,txt_id.Text);
        }

        private void frm_Order_Master_Activated(object sender, EventArgs e)
        {
            BindMyGrid();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            string s = "SM.Sup_Name";
            search(s, txt_name.Text);
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
         
            QRY = "SELECT OM.OM_ID, OM.OM_Date, SM.Sup_Name, OM.OM_Qty, OM.OM_TOT_AMT, OM.OM_Remarks FROM ";
            QRY += "tbl5_OrderMaster OM,tbl1_SupMaster SM";
            QRY += " WHERE ";
            QRY += "OM.Sup_ID = SM.Sup_ID";
            QRY += " AND OM.OM_Date = '" + dateTimePicker1.Text.ToString() + "'";
            QRY += " AND OM.OM_ID > 0";
            QRY += " AND OM.OM_Act = 'True'";
            QRY += " ORDER BY OM.OM_ID DESC";

            c.BindMyGrid(QRY, dtg_OM);
            if (dtg_OM.Rows.Count > 0)
            {
                dtg_OM.Visible = true;
            }
            else dtg_OM.Visible = false;
        }

        

       

    }
}
