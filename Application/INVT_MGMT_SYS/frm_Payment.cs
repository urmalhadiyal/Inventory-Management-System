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
    public partial class frm_Payment : Form
    {
        public frm_Payment()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        string QRY = string.Empty;
        //string cnstr = "Data Source=PC180;Initial Catalog=DB_IMS;Integrated Security=True";

        void BindMyGrid()
        {
            QRY = "SELECT PM.Pay_ID,SM.Sup_Name,PM.Pay_Amt,PM.Pay_PaidDate,PM.Pay_PaidAmt FROM tbl1_SupMaster SM,tbl12_PaymentMaster PM";
            QRY += " WHERE ";
            QRY += "PM.Sup_ID = SM.Sup_ID AND";
            QRY += " PM.Pay_Act = 'true' ORDER BY PM.Pay_ID DESC";
            c.BindMyGrid(QRY, dtg_PayMaster);
            if (dtg_PayMaster.Rows.Count > 0)
            {
                dtg_PayMaster.Visible = true;
            }
            else
            {

                dtg_PayMaster.Visible = false;
                dtp_Date.ResetText();
                lbl_tot_amt.Text = "--NONE--";
                ddl_Name.SelectedIndex = 0;
            }
        }

        void search(string name, string value)
        {
            QRY = "SELECT PM.Pay_ID,SM.Sup_Name,PM.Pay_Amt,PM.Pay_PaidDate,PM.Pay_PaidAmt FROM tbl1_SupMaster SM,tbl12_PaymentMaster PM";
            QRY += " WHERE ";
            QRY += "PM.Sup_ID = SM.Sup_ID AND";
            QRY += " (" + name + " like '%" + value + "%') AND ";
            QRY += " PM.Pay_Act = 'true' ORDER BY PM.Pay_ID DESC";          

            c.BindMyGrid(QRY, dtg_PayMaster);
            if (dtg_PayMaster.Rows.Count > 0)
            {
                dtg_PayMaster.Visible = true;
            }
            else dtg_PayMaster.Visible = false;
        }


        void EnableMainButtons(bool b)
        {
            btn_new.Enabled = b;
            btn_edit.Enabled = b;
            btn_delete.Enabled = b;
        }

        void Fillcontrols(int row)
        {
            lbl_ID.Text = dtg_PayMaster.Rows[row].Cells[0].Value.ToString();
            ddl_Name.SelectedItem = dtg_PayMaster.Rows[row].Cells[1].Value.ToString();
            lbl_tot_amt.Text = dtg_PayMaster.Rows[row].Cells[2].Value.ToString();
            dtp_Date.Text = dtg_PayMaster.Rows[row].Cells[3].Value.ToString();
            txt_paid_amt.Text = dtg_PayMaster.Rows[row].Cells[4].Value.ToString();
        }

        private void frm_Payment_Load(object sender, EventArgs e)
        {
            QRY = "SELECT Sup_Name FROM tbl1_SupMaster SM WHERE Sup_ID > 0 AND Sup_ID IN(Select Sup_ID from tbl7_PurchaseMaster) AND Sup_Act = 'True'";
            c.LoadDDL(ddl_Name, QRY);

            dtg_PayMaster.Visible = true;
            BindMyGrid();
            splitContainer1.Panel1.Enabled = false;
            lbl_tot_amt.Visible = lbl_totAMT.Visible = false;

            
        }
        
        void clearcontrol()
        {
            ddl_Name.SelectedIndex = 0;
            lbl_tot_amt.Text = "--NONE--";
            txt_paid_amt.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "ADD";
            splitContainer1.Panel1.Enabled = true;
            splitContainer1.Panel2.Enabled = false;
            EnableMainButtons(false);
            dtp_Date.ResetText();
            clearcontrol();
            lbl_tot_amt.Visible = lbl_totAMT.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "UPDATE";
            splitContainer1.Panel1.Enabled = true;
            dtg_PayMaster.Focus();
            EnableMainButtons(false);          

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            EnableMainButtons(true);
            DialogResult ans = MessageBox.Show("Are You Sure Delete Data??", "Delete Your Important Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == ans)
            {
                return;
            }
            else if (ans == DialogResult.Yes)
            {
                QRY = "DELETE FROM tbl12_PaymentMaster WHERE Pay_ID = " + lbl_ID.Text.ToString() + "";
                c.TransMyData(QRY);
                BindMyGrid();
            }
        }

        private void dtg_PayMaster_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fillcontrols(e.RowIndex);
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "ADD")
            {
                EnableMainButtons(true);
                QRY = "Insert into tbl12_PaymentMaster values((SELECT MAX(Pay_ID) +1 from tbl12_PaymentMaster)," + ddl_Name.SelectedIndex + "," + lbl_tot_amt.Text + ",'" + dtp_Date.Text.ToString() + "'," + txt_paid_amt.Text + ",'True')";
                c.TransMyData(QRY);
                BindMyGrid();
                splitContainer1.Panel1.Enabled = false;
                splitContainer1.Panel2.Enabled = true;
                dtg_PayMaster.Enabled = true;
                dtg_PayMaster.Focus();
                lbl_tot_amt.Visible = lbl_totAMT.Visible = false;
            }
            else if (btn_Action.Text == "UPDATE")
            {
                EnableMainButtons(true);
                DialogResult ans = MessageBox.Show("Do You Want To Edited Data ??", "Edit Your Important Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Cancel == ans)
                {
                    return;
                }
                else if (ans == DialogResult.Yes)
                {
                    QRY = "UPDATE tbl12_PaymentMaster SET Sup_ID = (Select Sup_ID from tbl1_SupMaster where Sup_Name = '" + ddl_Name.Text.ToString() + "'),Pay_PaidDate = '" + dtp_Date.Text.ToString() + "',Pay_PaidAmt = " + txt_paid_amt.Text + " WHERE Pay_ID = " + lbl_ID.Text.ToString() + "";
                    c.TransMyData(QRY);
                    splitContainer1.Panel1.Enabled = false;
                    BindMyGrid();
                }

            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_paid_amt.Text = string.Empty;
            splitContainer1.Panel1.Enabled = false;
            splitContainer1.Panel2.Enabled = true;
            EnableMainButtons(true);
            lbl_tot_amt.Visible = lbl_totAMT.Visible = false;           
        }

        int chk(String QRY)
        {
            SqlConnection cnn = new SqlConnection(c.cnstr());
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.Read())
                return 1;              
            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
            return 0;
        }



        private void ddl_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_Name.SelectedIndex > 0)
            {
                QRY = "Select Sup_ID ";
                QRY += "from tbl12_PaymentMaster ";
                QRY += "where ";
                QRY += "Sup_ID = (select Sup_ID from tbl1_SupMaster where Sup_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "')";

                if (chk(QRY) > 0)
                {
                    QRY = "select Distinct((Select SUM(Pur_TotAmt) from tbl7_PurchaseMaster where Sup_ID = ";
                    QRY += "(select Sup_ID from tbl1_SupMaster where Sup_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "')";
                    QRY += ") - (Select SUM(Pay_PaidAmt) from tbl12_PaymentMaster where Sup_ID = ";
                    QRY += "(select Sup_ID from tbl1_SupMaster where Sup_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "'))";
                    QRY += ")";
                    QRY += "from tbl12_PaymentMaster";
                }
                else
                {
                    QRY = "select Distinct((Select SUM(Pur_TotAmt) from tbl7_PurchaseMaster where Sup_ID = ";
                    QRY += "(select Sup_ID from tbl1_SupMaster where Sup_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "'))) from tbl12_PaymentMaster";
                }

                SqlConnection cnn = new SqlConnection(c.cnstr());
                SqlCommand cmd = new SqlCommand(QRY, cnn);
                cnn.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                    lbl_tot_amt.Text = DR.GetValue(0).ToString();
                DR.Close();
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();

            }
            else
                if (btn_Action.Text == "UPDATE")
                    BindMyGrid();
                else
                    lbl_tot_amt.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = "SM.Sup_Name";
            search(s, txt_SearchName.Text.ToString());
        }

        private void dtp_Search_CloseUp(object sender, EventArgs e)
        {
            QRY = "SELECT PM.Pay_ID,SM.Sup_Name,PM.Pay_Amt,PM.Pay_PaidDate,PM.Pay_PaidAmt FROM tbl1_SupMaster SM,tbl12_PaymentMaster PM";
            QRY += " WHERE ";
            QRY += "PM.Sup_ID = SM.Sup_ID AND ";
            QRY += "PM.Pay_PaidDate = '" + dtp_Search.Text.ToString() + "' AND";
            QRY += " PM.Pay_Act = 'true' ORDER BY PM.Pay_ID DESC";
            c.BindMyGrid(QRY, dtg_PayMaster);
            if (dtg_PayMaster.Rows.Count > 0)
            {
                dtg_PayMaster.Visible = true;
            }
            else
            {
                dtg_PayMaster.Visible = false;
                dtp_Date.ResetText();
            }
        }

       
    }
}
