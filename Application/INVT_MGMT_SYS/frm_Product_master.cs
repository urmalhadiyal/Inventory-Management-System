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
    public partial class frm_Product_master : Form
    {
        public frm_Product_master()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;
 //       string cnstr = "Data Source=DESKTOP-OTO79BH;Initial Catalog=DB_IMS;Integrated Security=True";

        void EnableMyControls(bool b)
        {
            splitContainer1.Panel1.Enabled = b;
        }

        void EnableMainButtons(bool b)
        {
            btn_new.Enabled = b;
            btn_Edit.Enabled = b;
            btn_delete.Enabled = b;
        }

        void ClearMyControls()
        {
            txt_name.Clear();
            ddl_type.SelectedIndex = 0;
            txt_desc.Clear();

        }

        void BindMyGrid()
        {
            QRY = "SELECT PM.Pro_ID,PT.PTM_Name,PM.Pro_Name,PM.Pro_Desc FROM ";
            QRY += "tbl4_ProMaster PM,tbl3_ProdTypeMaster PT";
            QRY += " WHERE ";
            QRY += "PM.PTM_ID = PT.PTM_ID";
            QRY += " AND PM.Pro_ID > 0";
            QRY += " AND PM.Pro_Act = 'True'";
            QRY += " ORDER BY PM.Pro_ID DESC";


            c.BindMyGrid(QRY, dtg_products);
            if (dtg_products.Rows.Count > 0)
            {
                dtg_products.Visible = true;
            }
            else dtg_products.Visible = false;
        }

        void FillToControls(int RID)
        {
            lbl_id.Text = dtg_products.Rows[RID].Cells[0].Value.ToString();
            txt_name.Text = dtg_products.Rows[RID].Cells[2].Value.ToString();
            ddl_type.SelectedItem = dtg_products.Rows[RID].Cells[1].Value.ToString(); 
            txt_desc.Text = dtg_products.Rows[RID].Cells[3].Value.ToString();
        }

        private void frm_Product_master_Load(object sender, EventArgs e)
        {
            
            BindMyGrid();
            EnableMainButtons(true);
            EnableMyControls(false);
            
            QRY = "SELECT PTM_Name FROM tbl3_ProdTypeMaster WHERE PTM_ID > 0 AND PTM_Act = 'True'";
            c.LoadDDL(ddl_type,QRY);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
            EnableMainButtons(false);
            EnableMyControls(true);
            txt_name.Focus();
            ClearMyControls();
            btn_Action.Text = "ADD";
            splitContainer1.Panel2.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EnableMainButtons(false);
            EnableMyControls(true);
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
                QRY = "Delete tbl4_ProMaster Where Pro_ID=" + lbl_id.Text + "";
                c.TransMyData(QRY);
            }
            lbl_id.Text = "";
            BindMyGrid();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnableMainButtons(true);
            EnableMyControls(false);
            btn_Action.Text = "Action";
            //dtg_products.Enabled = true;
            splitContainer1.Panel2.Enabled = true;
        }

        private void dtg_products_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillToControls(e.RowIndex);
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "ADD")
            {
                if (ddl_type.SelectedIndex > 0)
                {
                    QRY = "INSERT INTO tbl4_ProMaster VALUES((SELECT MAX(Pro_ID) + 1 FROM tbl4_ProMaster),(SELECT PTM_ID FROM tbl3_ProdTypeMaster WHERE PTM_Name ='" + ddl_type.Items[ddl_type.SelectedIndex].ToString() + "') , '" + txt_name.Text + "','" + txt_desc.Text + "','TRUE')";

                    c.TransMyData(QRY);
                    splitContainer1.Panel2.Enabled = true;
                }
            }
            else if (btn_Action.Text == "Update")
            {
                if(ddl_type.SelectedIndex > 0)
                {
                QRY = "Update tbl4_ProMaster SET PTM_ID = (Select PTM_ID From tbl3_ProdTypeMaster Where PTM_Name='"+ ddl_type.Items[ddl_type.SelectedIndex].ToString()+"'), Pro_Name='" + txt_name.Text + "',Pro_Desc='" + txt_desc.Text + "' Where Pro_ID = " + lbl_id.Text + "";

                if (c.TransMyData(QRY) != 1)
                    MessageBox.Show("Data Not Updated");
                   
                }
            }
            

            btn_Action.Text = "Action";
            lbl_id.Text = "";
            EnableMyControls(false);
            EnableMainButtons(true);
            BindMyGrid();
        }

    
    
    
    
    }
}
