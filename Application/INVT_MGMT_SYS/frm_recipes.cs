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
    public partial class frm_recipes : Form
    {
        public frm_recipes()
        {
            InitializeComponent();
        }
        
        Connection c = new Connection();
        string QRY = string.Empty;
      //  string cnstr = "Data Source=PC180;Initial Catalog=DB_IMS;Integrated Security=True";

        void BindMyGrid()
        {
            QRY = "SELECT RM.Recp_ID,CM.Cust_Name,RM.Recp_Amt,RM.Recp_PaidDate,RM.Recp_PaidAmt FROM tbl9_CustMaster CM,tbl13_RecieptMaster RM";
            QRY += " WHERE ";
            QRY += "RM.Cust_ID = CM.Cust_ID AND";
            QRY += " RM.Recp_Act = 'true' ORDER BY RM.Recp_ID DESC";
            c.BindMyGrid(QRY, dtg_Reciep);
            if (dtg_Reciep.Rows.Count > 0)
            {
                dtg_Reciep.Visible = true;
            }
            else
            {
                dtg_Reciep.Visible = false;
                dtp_Date.ResetText();
                lbl_tot_amt.Text = "--NONE--";
                ddl_Name.SelectedIndex = 0;
            }
        }

        void search(string name, string value)
        {
            QRY = "SELECT RM.Recp_ID,CM.Cust_Name,RM.Recp_Amt,RM.Recp_PaidDate,RM.Recp_PaidAmt FROM tbl9_CustMaster CM,tbl13_RecieptMaster RM";
            QRY += " WHERE ";
            QRY += "RM.Cust_ID = CM.Cust_ID AND";
            QRY += " (" + name + " like '%" + value + "%') AND ";
            QRY += " RM.Recp_Act = 'true' ORDER BY RM.Recp_ID DESC";    
         
            c.BindMyGrid(QRY, dtg_Reciep);
            if (dtg_Reciep.Rows.Count > 0)
            {
                dtg_Reciep.Visible = true;
            }
            else dtg_Reciep.Visible = false;
        }

        void EnableMainButtons(bool b)
        {
            btn_new.Enabled = b;
            btn_edit.Enabled = b;
            btn_delete.Enabled = b;
        }

        void Fillcontrols(int row)
        {
            lbl_ID.Text = dtg_Reciep.Rows[row].Cells[0].Value.ToString();
            ddl_Name.SelectedItem = dtg_Reciep.Rows[row].Cells[1].Value.ToString();
            lbl_tot_amt.Text = dtg_Reciep.Rows[row].Cells[2].Value.ToString();
            dtp_Date.Text = dtg_Reciep.Rows[row].Cells[3].Value.ToString();
            txt_paid_amt.Text = dtg_Reciep.Rows[row].Cells[4].Value.ToString();
        }

        private void frm_recipes_Load(object sender, EventArgs e)
        {
            QRY = "SELECT Cust_Name FROM tbl9_CustMaster WHERE Cust_ID > 0 AND Cust_ID IN(Select Cust_ID from tbl10_SalesMaster) AND Cust_Act = 'True'";
            c.LoadDDL(ddl_Name, QRY);

            dtg_Reciep.Visible = true;
            BindMyGrid();
            splitContainer1.Panel1.Enabled = false;
            lbl_tot_amt.Visible = lbl_TotAMT.Visible = false;
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
            lbl_tot_amt.Visible = lbl_TotAMT.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "UPDATE";
            splitContainer1.Panel1.Enabled = true;
            dtg_Reciep.Focus();
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
                QRY = "DELETE FROM tbl13_RecieptMaster WHERE Recp_ID = " + lbl_ID.Text.ToString() + "";
                c.TransMyData(QRY);
                BindMyGrid();
            }
        }

        private void dtg_Reciep_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fillcontrols(e.RowIndex);
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "ADD")
            {
                EnableMainButtons(true);
                QRY = "Insert into tbl13_RecieptMaster values((SELECT MAX(Recp_ID) +1 from tbl13_RecieptMaster),'" + ddl_Name.SelectedIndex + "'," + lbl_tot_amt.Text + ",'" + dtp_Date.Text + "'," + txt_paid_amt.Text + ",'True')";
                c.TransMyData(QRY);
                BindMyGrid();
                splitContainer1.Panel1.Enabled = false;
                splitContainer1.Panel2.Enabled = true;
                dtg_Reciep.Enabled = true;
                dtg_Reciep.Focus();
                lbl_tot_amt.Visible = lbl_TotAMT.Visible = false;
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
                    QRY = "UPDATE tbl13_RecieptMaster SET Cust_ID = (Select Cust_ID from tbl9_CustMaster where Cust_Name = '" + ddl_Name.Text.ToString() + "'),Recp_PaidDate = '" + dtp_Date.Text.ToString() + "',Recp_PaidAmt = " + txt_paid_amt.Text + " WHERE Recp_ID = " + lbl_ID.Text.ToString() + "";
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
            lbl_tot_amt.Visible = lbl_TotAMT.Visible = false;           
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
                QRY = "Select Cust_ID ";
                QRY += "from tbl13_RecieptMaster ";
                QRY += "where ";
                QRY += "Cust_ID = (select Cust_ID from tbl9_CustMaster where Cust_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "')";

                if (chk(QRY) > 0)
                {
                    QRY = "select Distinct((Select SUM(Sales_TotAmt) from tbl10_SalesMaster where Cust_ID = ";
                    QRY += "(select Cust_ID from tbl9_CustMaster where Cust_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "')";
                    QRY += ") - (Select SUM(Recp_PaidAmt) from tbl13_RecieptMaster where Cust_ID = ";
                    QRY += "(select Cust_ID from tbl9_CustMaster where Cust_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "'))";
                    QRY += ")";
                    QRY += "from tbl13_RecieptMaster";
                }
                else
                {
                    QRY = "select Distinct((Select SUM(Sales_TotAmt) from tbl10_SalesMaster where Cust_ID = ";
                    QRY += "(select Cust_ID from tbl9_CustMaster where Cust_Name = '" + ddl_Name.Items[ddl_Name.SelectedIndex].ToString() + "'))) from tbl12_PaymentMaster";
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

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            string s = "CM.Cust_Name";
            search(s, txt_SearchName.Text.ToString());
        }

        private void dtp_Search_CloseUp(object sender, EventArgs e)
        {
            QRY = "SELECT RM.Recp_ID,CM.Cust_Name,RM.Recp_Amt,RM.Recp_PaidDate,RM.Recp_PaidAmt FROM tbl9_CustMaster CM,tbl13_RecieptMaster RM";
            QRY += " WHERE ";
            QRY += "RM.Cust_ID = CM.Cust_ID AND ";
            QRY += "RM.Recp_PaidDate = '" + dtp_Search.Text.ToString() + "' AND";
            QRY += " RM.Recp_Act = 'true' ORDER BY RM.Recp_ID DESC";   
            c.BindMyGrid(QRY, dtg_Reciep);
            if (dtg_Reciep.Rows.Count > 0)
            {
                dtg_Reciep.Visible = true;
            }
            else
            {
                dtg_Reciep.Visible = false;
                dtp_Date.ResetText();
            }
        }

    }
}
