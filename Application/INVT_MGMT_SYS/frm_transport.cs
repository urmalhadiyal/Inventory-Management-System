using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace INVT_MGMT_SYS
{
    public partial class frm_transport : Form
    {
        public frm_transport()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;


        private void frm_transport_Load(object sender, EventArgs e)
        {
            BindMyGrid();
            EnableMainButtons(true);
            EnableMyControls(false);
        }

        void EnableMyControls(bool b)
        {
            txt_name.Enabled = b;
            txt_remarks.Enabled = b;
            btn_save.Enabled = b;
            btn_cancel.Enabled = b;
        }
    
        void EnableMainButtons(bool b)
        {
            btn_new.Enabled = b;
            btn_update.Enabled = b;
            btn_delete.Enabled = b;     
        }

        void ClearMyControls()
        {
            txt_name.Clear();
            txt_remarks.Clear();
         
        }




        void BindMyGrid()
        {
            QRY = "SELECT * FROM tbl2_TransMaster WHERE Tm_ID > 0 AND Tm_Act = 'True'";
            c.BindMyGrid(QRY, dtg_trans);
            if (dtg_trans.Rows.Count > 0)
            {
                dtg_trans.Visible = true;
            }
            else dtg_trans.Visible = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EnableMainButtons(false);
            EnableMyControls(true);
            ClearMyControls();
            btn_save.Text = "Save";
            dtg_trans.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            EnableMainButtons(false);
            EnableMyControls(true);
            btn_save.Text = "Delete";
        } 

        private void btn_update_Click(object sender, EventArgs e)
        {
            EnableMainButtons(false);
            EnableMyControls(true);
            btn_save.Text = "Update";
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnableMainButtons(true);
            EnableMyControls(false);
            btn_save.Text = "Action";
            dtg_trans.Enabled = true;
            BindMyGrid();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "Save")
            {
                QRY = "INSERT INTO tbl2_TransMaster VALUES((SELECT MAX(Tm_ID) + 1 FROM tbl2_TransMaster)  ,'" + txt_name.Text + "','" + txt_remarks.Text + "','TRUE')";
               
                 if (c.TransMyData(QRY) > 0)
                     MessageBox.Show("Data inserted..");
                 else 
                     MessageBox.Show("Data Not Added");

                 dtg_trans.Enabled = true;
            }
            else if(btn_save.Text=="Update")
            {
         
                QRY = "Update tbl2_TransMaster SET Tm_Name='"+ txt_name.Text +"',Tm_Remarks='"+ txt_remarks.Text +"' Where Tm_ID="+ lbl_id.Text +"";

                if (c.TransMyData(QRY) > 0)
                    MessageBox.Show("Data Updated..");
                else
                    MessageBox.Show("Data Not Updated");

            }
            else if (btn_save.Text == "Delete")
            {
                QRY = "Delete tbl2_TransMaster Where Tm_ID=" + lbl_id.Text + "";

                if (c.TransMyData(QRY) > 0)
                    MessageBox.Show("Data Deleted..");
                else
                    MessageBox.Show("Data Can not Deleted...");

            }

            btn_save.Text = "Action";
            lbl_id.Text = "";
            EnableMyControls(false);
            EnableMainButtons(true);
            BindMyGrid();
        }

        private void dtg_trans_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillToControls(e.RowIndex);
        }

        void FillToControls(int RID)
        {
            lbl_id.Text = dtg_trans.Rows[RID].Cells[0].Value.ToString();
            txt_name.Text = dtg_trans.Rows[RID].Cells[1].Value.ToString();
            txt_remarks.Text = dtg_trans.Rows[RID].Cells[2].Value.ToString();
        }

   
      



    }
}
