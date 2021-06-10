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
    public partial class frm_Sales_List : Form
    {
        public frm_Sales_List()
        {
            InitializeComponent();
        }

        public frm_Sales_List(string sm_id)
        {
            InitializeComponent();
            lbl_SM.Text = sm_id;
        }

        int Print = 0;

        Connection c = new Connection();
        String QRY = String.Empty;
       // string cnstr = "Data Source=PC179;Initial Catalog=DB_IMS;Integrated Security=True";
        //string cnstr = "Data Source=DESKTOP-OTO79BH;Initial Catalog=DB_IMS;Integrated Security=True";

        void SET_ID(Label lbl, string QRY)
        {
            SqlConnection cnn = new SqlConnection(c.cnstr());
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                lbl.Text = DR.GetValue(0).ToString();
                txt_inv_no.Text += lbl.Text;
            }

            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
        }

        void BindMyGrid()
        {
            QRY = "SELECT SL.SL_ID, PRM.Pro_Name, SL.Qty, SL.SL_Rate, (SL.Qty*SL.SL_Rate) FROM ";
            QRY += "tbl11_SalesListMaster SL, tbl4_ProMaster PRM";
            QRY += " WHERE ";
            QRY += "SL.Pro_ID = PRM.Pro_ID ";
            QRY += " AND SL.Sales_ID=" + lbl_SM.Text.ToString() + "";
            QRY += " AND SL.SL_ID > 0";
            QRY += " AND SL.SL_Act = 'True'";
            QRY += " ORDER BY SL.SL_ID DESC";


            c.BindMyGrid(QRY, dtg_SL);
            if (dtg_SL.Rows.Count > 0)
            {
                dtg_SL.Visible = true;
                txt_nos.Text = dtg_SL.Rows.Count.ToString();
                int tot = 0;
                for (int x = 0; x < dtg_SL.Rows.Count; x++)
                    tot += int.Parse(dtg_SL.Rows[x].Cells[4].Value.ToString());
                txt_tot_amt.Text = tot.ToString();
            }

        }


        void ClearMyControls()
        {
            ddl_Product_Name.SelectedIndex = 0;
            txt_QTY.Clear();
            txt_Rate.Clear();
        }

        void FillToControls(int RID)
        {
            lbl_SL.Text = dtg_SL.Rows[RID].Cells[0].Value.ToString();
            ddl_Product_Name.SelectedItem = dtg_SL.Rows[RID].Cells[1].Value.ToString();
            txt_QTY.Text = dtg_SL.Rows[RID].Cells[2].Value.ToString();
            txt_Rate.Text = dtg_SL.Rows[RID].Cells[3].Value.ToString();
        }

        void FillMaster(string qry)
        {
            SqlConnection cnn = new SqlConnection(c.cnstr());
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {

                ddl_CustName.SelectedItem = DR.GetValue(0).ToString();
                dtp_inv_date.Text = DR.GetValue(1).ToString();
                txt_inv_no.Text = DR.GetValue(2).ToString();
                ddl_pay_type.SelectedItem = DR.GetValue(3).ToString();
                txt_Remarks.Text = DR.GetValue(4).ToString();
            }
            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
        }


        private void frm_Sales_List_TextChanged(object sender, EventArgs e)
        {
            lbl_Title.Text = this.Text;
            if (this.Text == "New Sales Invoice")
            {
                btn_Action.Text = "Save";

                QRY = "SELECT MAX(Sales_ID) + 1 FROM tbl10_SalesMaster";
                SET_ID(lbl_SM, QRY);
            }
            else if (this.Text == "Edit Sales Invoice")
            {
                btn_Action.Text = "Update";
                btn_pro_ADD.Text = "Change";
                btn_Cancel.Visible = false;
                BindMyGrid();

                QRY = "SELECT  CM.Cust_Name, SM.Sales_Date, SM.Sales_InvNo, SM.Sales_PayType, SM.Remarks FROM ";
                QRY += "tbl9_CustMaster CM, tbl10_SalesMaster SM";
                QRY += " WHERE ";
                QRY += "CM.Cust_ID = SM.Cust_ID";
                QRY += " AND SM.Sales_ID=" + lbl_SM.Text + "";
                QRY += " AND SM.Sales_ID > 0";
                QRY += " AND SM.Sales_Act = 'True'";
                FillMaster(QRY);
            }
        }

        private void frm_Sales_List_Load(object sender, EventArgs e)
        {
            
                QRY = "SELECT Cust_Name FROM tbl9_CustMaster WHERE Cust_ID > 0 AND Cust_Act = 'True'";
                c.LoadDDL(ddl_CustName, QRY);

                QRY = "SELECT Pro_Name FROM tbl4_ProMaster WHERE Pro_ID > 0 AND Pro_Act = 'True'";
                c.LoadDDL(ddl_Product_Name, QRY);

                ddl_pay_type.SelectedIndex = 0;
            
            if (this.Text == "Edit Sales Invoice")
            {
                btn_Action.Text = "Update";
                btn_pro_ADD.Text = "Change";
                btn_Cancel.Visible = false;
                BindMyGrid();

                QRY = "SELECT  CM.Cust_Name, SM.Sales_Date, SM.Sales_InvNo, SM.Sales_PayType, SM.Remarks FROM ";
                QRY += "tbl9_CustMaster CM, tbl10_SalesMaster SM";
                QRY += " WHERE ";
                QRY += "CM.Cust_ID = SM.Cust_ID";
                QRY += " AND SM.Sales_ID=" + lbl_SM.Text + "";
                QRY += " AND SM.Sales_ID > 0";
                QRY += " AND SM.Sales_Act = 'True'";
                FillMaster(QRY);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (this.Text == "New Sales Invoice")
            {
                QRY = "delete tbl11_SalesListMaster Where Sales_ID = " + lbl_SM.Text + "";
                if (c.TransMyData(QRY) > 0)
                    this.Close();
            }

        }

        private void dtg_SL_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillToControls(e.RowIndex);
        }

        private void btn_pro_ADD_Click(object sender, EventArgs e)
        {
            if (ddl_Product_Name.SelectedIndex > 0 && ddl_CustName.SelectedIndex > 0 && btn_pro_ADD.Text == "ADD" )
            {
                QRY = "INSERT INTO tbl11_SalesListMaster VALUES (";
                QRY += "(SELECT MAX(SL_ID) + 1 FROM tbl11_SalesListMaster),";
                QRY += "" + lbl_SM.Text + ",";
                QRY += "(SELECT Pro_ID FROM tbl4_ProMaster WHERE Pro_Name ='" + ddl_Product_Name.Items[ddl_Product_Name.SelectedIndex].ToString() + "') ,";
                QRY += "" + txt_QTY.Text + "," + txt_Rate.Text + ",'TRUE')";

                if (c.TransMyData(QRY) > 0)
                    BindMyGrid();
                else
                    MessageBox.Show("Error : Data Cann't be Added..");

                ClearMyControls();
                ddl_Product_Name.Focus();
            }
            else if (ddl_Product_Name.SelectedIndex > 0 && ddl_CustName.SelectedIndex > 0 && btn_pro_ADD.Text == "Change")
            {
                QRY = "Update tbl11_SalesListMaster SET ";
                QRY += "Pro_ID = (Select Pro_ID from tbl4_ProMaster Where Pro_Name='" + ddl_Product_Name.Items[ddl_Product_Name.SelectedIndex].ToString() + "'), ";
                QRY += "Qty = " + txt_QTY.Text + ",";
                QRY += "SL_Rate = " + txt_Rate.Text + "";
                QRY += " Where";
                QRY += " SL_ID = " + lbl_SL.Text + "";


                if (c.TransMyData(QRY) > 0)
                    BindMyGrid();
                else
                    MessageBox.Show("Error : Data Cann't be Updated..");

                ddl_Product_Name.Focus();
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Save" && ddl_CustName.SelectedIndex > 0 )
            {
                QRY = "INSERT INTO tbl10_SalesMaster VALUES(" + lbl_SM.Text + ",'" + dtp_inv_date.Text + "','" + txt_inv_no.Text.ToString() + "',(SELECT Cust_ID FROM tbl9_CustMaster WHERE Cust_Name ='" + ddl_CustName.Items[ddl_CustName.SelectedIndex].ToString() + "') , " + txt_nos.Text + "," + txt_tot_amt.Text + ",'" + ddl_pay_type.Items[ddl_pay_type.SelectedIndex].ToString() + "','" + txt_Remarks.Text + "','TRUE')";

                if (c.TransMyData(QRY) > 0)
                {
                    DialogResult ans = MessageBox.Show("Do You want to Print This Invoice ??", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == ans)
                        Print++;
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("Sorry! Data Can not be Added..");
            }
            else if (btn_Action.Text == "Update" && ddl_CustName.SelectedIndex > 0)
            {
                QRY = "Update tbl10_SalesMaster SET";
                QRY += " Sales_Date ='" + dtp_inv_date.Text + "',";
                QRY += " Cust_ID = (SELECT Cust_ID FROM tbl9_CustMaster WHERE Cust_Name ='" + ddl_CustName.Items[ddl_CustName.SelectedIndex].ToString() + "'),";
                QRY += " Sales_Qty=" + txt_nos.Text + ",";
                QRY += " Sales_TotAmt = " + txt_tot_amt.Text + ",";
                QRY += " Sales_PayType = '" + ddl_pay_type.Items[ddl_pay_type.SelectedIndex].ToString() + "',";
                QRY += " Remarks='" + txt_Remarks.Text + "'";
                QRY += " Where";
                QRY += " Sales_ID=" + lbl_SM.Text + "";

                if (c.TransMyData(QRY) > 0)
                {
                    DialogResult ans = MessageBox.Show("Do You want to Print This Invoice ??", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == ans)
                        Print++;
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("Sorry! Data Can not be Updated..");

            }

            if (Print == 1)
            {
                QRY = "SELECT SL.Sales_ID, PD.Pro_Name, SL.Qty, SL.SL_Rate, (SL.Qty*SL.SL_Rate) as S_TOTAL, ";
                QRY += " SM.Sales_Date, SM.Sales_InvNo, CM.Cust_Name, SM.Sales_Qty, SM.Sales_TotAmt, SM.Sales_PayType FROM ";
                QRY += "tbl11_SalesListMaster SL, tbl4_ProMaster PD, tbl10_SalesMaster SM, tbl9_CustMaster CM";
                QRY += " WHERE ";
                QRY += "SL.Pro_ID = PD.Pro_ID ";
                QRY += " AND SL.Sales_ID=" + lbl_SM.Text + " ";
                QRY += " AND SM.Sales_ID=" + lbl_SM.Text + " ";
                QRY += " AND CM.Cust_ID=SM.Cust_ID ";
                QRY += " AND SL.SL_ID > 0";
                QRY += " AND SL.SL_Act = 'True'";
                QRY += " ORDER BY SL.SL_ID DESC";

                c.Report_FORM(QRY);
                RPT_InvoiceSales FR = new RPT_InvoiceSales();
                FR.ShowDialog();

                this.Close();
                
            }
        
        }

      

        private void ddl_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Sales_List_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

    }
}
