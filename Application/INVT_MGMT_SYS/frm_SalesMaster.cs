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
    public partial class frm_SalesMaster : Form
    {
        public frm_SalesMaster()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;

        void BindMyGrid()
        {
            QRY = "SELECT SM.Sales_ID, SM.Sales_Date, SM.Sales_InvNo, CM.Cust_Name, SM.Sales_Qty, SM.Sales_TotAmt,SM.Sales_PayType, SM.Remarks FROM ";
            QRY += "tbl10_SalesMaster SM,tbl9_CustMaster CM";
            QRY += " WHERE ";
            QRY += "CM.Cust_ID = SM.Cust_ID";
            QRY += " AND SM.Sales_ID > 0";
            QRY += " AND SM.Sales_Act = 'True'";
            QRY += " ORDER BY SM.Sales_Date DESC";

            c.BindMyGrid(QRY, dtg_SM);
            if (dtg_SM.Rows.Count > 0)
            {
                dtg_SM.Visible = true;
                btn_Edit.Enabled = btn_Delete.Enabled = true;
            }
            else
            {
                dtg_SM.Visible = false;
                btn_Edit.Enabled = btn_Delete.Enabled = false;
            }
        }

        void search(string name, string value)
        {
            QRY = "SELECT SM.Sales_ID, SM.Sales_Date, SM.Sales_InvNo, CM.Cust_Name, SM.Sales_Qty, SM.Sales_TotAmt,SM.Sales_PayType, SM.Remarks FROM ";
            QRY += "tbl10_SalesMaster SM,tbl9_CustMaster CM";
            QRY += " WHERE ";
            QRY += "CM.Cust_ID = SM.Cust_ID";
            QRY += " AND (" + name + " like '%" + value + "%')";
            QRY += " AND SM.Sales_ID > 0";
            QRY += " AND SM.Sales_Act = 'True'";
            QRY += " ORDER BY SM.Sales_Date DESC";

            c.BindMyGrid(QRY, dtg_SM);
            if (dtg_SM.Rows.Count > 0)
            {
                dtg_SM.Visible = true;
                btn_Edit.Enabled = btn_Delete.Enabled = true;
            }
            else
            {
                dtg_SM.Visible = false;
                btn_Edit.Enabled = btn_Delete.Enabled = false;
            }
        }

        private void frm_SalesMaster_Load(object sender, EventArgs e)
        {
            BindMyGrid();
        }

        private void frm_SalesMaster_Activated(object sender, EventArgs e)
        {
            BindMyGrid();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form f = new frm_Sales_List();
            f.Text = "New Sales Invoice";
            f.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form f = new frm_Sales_List(lbl_SM.Text.ToString());
            f.Text = "Edit Sales Invoice";
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
                QRY = "Delete tbl10_SalesMaster Where Sales_ID=" + lbl_SM.Text + "";
                c.TransMyData(QRY);

                QRY = "Delete tbl11_SalesListMaster Where Sales_ID = " + lbl_SM.Text + "";
                c.TransMyData(QRY);
            }
            lbl_SM.Text = "";
            BindMyGrid();
        }

        private void txt_inv_no_TextChanged(object sender, EventArgs e)
        {
            string s = "SM.Sales_InvNo";
            search(s, txt_inv_no.Text);
        }

        private void txt_CustName_TextChanged(object sender, EventArgs e)
        {
            string s = "CM.Cust_Name";
            search(s, txt_CustName.Text.ToString());
        }

        private void dtp_search_date_CloseUp(object sender, EventArgs e)
        {
            QRY = "SELECT SM.Sales_ID, SM.Sales_Date, SM.Sales_InvNo, CM.Cust_Name, SM.Sales_Qty, SM.Sales_TotAmt,SM.Sales_PayType, SM.Remarks FROM ";
            QRY += "tbl10_SalesMaster SM,tbl9_CustMaster CM";
            QRY += " WHERE ";
            QRY += "CM.Cust_ID = SM.Cust_ID";
            QRY += " AND SM.Sales_Date = '" + dtp_search_date.Text.ToString() + "'";
            QRY += " AND SM.Sales_ID > 0";
            QRY += " AND SM.Sales_Act = 'True'";
            QRY += " ORDER BY SM.Sales_Date DESC";

            c.BindMyGrid(QRY, dtg_SM);
            if (dtg_SM.Rows.Count > 0)
            {
                dtg_SM.Visible = true;
                btn_Edit.Enabled = btn_Delete.Enabled = true;
            }
            else
            {
                dtg_SM.Visible = false;
                btn_Edit.Enabled = btn_Delete.Enabled = false;
            }
        }

        private void dtg_SM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lbl_SM.Text = dtg_SM.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            QRY = "SELECT SL.Sales_ID, PD.Pro_Name, SL.Qty, SL.SL_Rate, (SL.Qty*SL.SL_Rate) as S_TOTAL, ";
            QRY += " convert(nchar,SM.Sales_Date,103) as Sales_Date, SM.Sales_InvNo, CM.Cust_Name, SM.Sales_Qty, SM.Sales_TotAmt, SM.Sales_PayType FROM ";
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

        }


    }
}
