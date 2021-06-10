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
    public partial class frm_Summry_Cust_Recipe : Form
    {
        public frm_Summry_Cust_Recipe()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;

        private void frm_Summry_Cust_Recipe_Load(object sender, EventArgs e)
        {
            BindMyGrid();
        }

        void BindMyGrid()
        {
            string qry1, qry2, qry3;

            qry1 = "SELECT RM.Cust_ID, CM.Cust_Name, SUM(RM.Recp_PaidAmt) as 'PAID' ";
            qry1 += "FROM tbl13_RecieptMaster RM, tbl9_CustMaster CM ";
            qry1 += "WHERE ";
            qry1 += "RM.Cust_ID = CM.Cust_ID AND ";
            qry1 += "RM.Recp_Act = 'TRUE' ";
            qry1 += "GROUP BY RM.Cust_ID, CM.Cust_Name ";
            qry1 += "ORDER BY RM.Cust_ID";
            
            qry2 = "SELECT  SM.Cust_ID, CM.Cust_Name, SUM(SM.Sales_TotAmt) as 'TotAmt' ";
            qry2 += "FROM tbl10_SalesMaster SM, tbl9_CustMaster CM ";
            qry2 += "WHERE ";
            qry2 += "SM.Cust_ID = CM.Cust_ID AND ";
            qry2 += "SM.Sales_Act = 'TRUE' AND ";
            qry2 += "SM.Cust_ID IN (SELECT DISTINCT(Cust_ID) FROM tbl13_RecieptMaster WHERE Recp_Act = 'TRUE') ";
            qry2 += "GROUP BY SM.Cust_ID, CM.Cust_Name ";
            qry2 += "ORDER BY SM.Cust_ID";

            qry3 = "SELECT  SM.Cust_ID, CM.Cust_Name, SUM(SM.Sales_TotAmt) as 'TotAmt' ";
            qry3 += "FROM tbl10_SalesMaster SM, tbl9_CustMaster CM ";
            qry3 += "WHERE ";
            qry3 += "SM.Cust_ID = CM.Cust_ID AND ";
            qry3 += "SM.Sales_Act = 'TRUE' AND ";
            qry3 += "SM.Cust_ID NOT IN (SELECT DISTINCT(Cust_ID) FROM tbl13_RecieptMaster WHERE Recp_Act = 'TRUE') ";
            qry3 += "GROUP BY SM.Cust_ID, CM.Cust_Name ";
            qry3 += "ORDER BY SM.Cust_ID";

            LoadDataTables(qry1, qry2, qry3);
            btn_print.Enabled = true;

            c.LoadSearchDDL(ddl_cust_name, dtg_SCR);


        }

        void LoadDataTables(string q1, string q2, string q3)
        {
            DataTable DT_CustPaid = new DataTable();
            DataTable DT_CustSales_Paid = new DataTable();
            DataTable DT_CustSales_NotPaid = new DataTable();

            ///////// For Payment data table ////////////
            QRY = q1;
            DT_CustPaid = c.BindDataTable(DT_CustPaid, QRY);

            ///////// For paid-Pauchase data table ////////////
            QRY = q2;
            DT_CustSales_Paid = c.BindDataTable(DT_CustSales_Paid, QRY);

            ///////// For paid-Pauchase data table ////////////
            QRY = q3;
            DT_CustSales_NotPaid = c.BindDataTable(DT_CustSales_NotPaid, QRY);

            //////// DataTables to DataGrid Transfer /////////
            if (c.DTsToDG_Summry(DT_CustPaid, DT_CustSales_Paid, DT_CustSales_NotPaid, dtg_SCR) > 0)
                dtg_SCR.Visible = true;
            else
            {
                dtg_SCR.Visible = false;
                MessageBox.Show("NO Record Found..");
            }
        }

        
        private void ddl_cust_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_cust_name.SelectedIndex > 0)
            {
                for (int i = 0; i < dtg_SCR.Rows.Count; i++)
                {
                    if (dtg_SCR.Rows[i].Cells[1].Value.ToString() == ddl_cust_name.Items[ddl_cust_name.SelectedIndex].ToString())
                    {
                        dtg_SCR.Rows[i].Selected = true;
                    }
                }
                btn_print.Enabled = false;
            }
            else
            {
                dtg_SCR.Rows[0].Selected = true;
                btn_print.Enabled = true;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            GenerateDataTableForPrint();
        }

        void GenerateDataTableForPrint()
        {
            DataTable DT = new DataTable();

            foreach (DataGridViewColumn DGC in dtg_SCR.Columns)
                DT.Columns.Add(DGC.HeaderText.ToString());

            for (int i = 0; i < dtg_SCR.Rows.Count; i++)
            {
                DT.Rows.Add();
                for (int j = 0; j < dtg_SCR.Columns.Count; j++)
                {
                    DT.Rows[i][j] = dtg_SCR.Rows[i].Cells[j].Value.ToString();
                }
            }
            DataSet DS = new DataSet();
            DS.Tables.Add(DT);
            DS.WriteXml(@"C:\Sum_Cust_Payments.xml");
            RPT_Summry_Cust rpt = new RPT_Summry_Cust();
            rpt.ShowDialog();
        }

    }
}
