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
    public partial class frm_Summry_Sup_Payment : Form
    {
        public frm_Summry_Sup_Payment()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;

        private void frm_Summry_Sup_Payment_Load(object sender, EventArgs e)
        {
            BindMyGrid();           
        }


        void BindMyGrid()
        {
            string qry1, qry2, qry3;

            qry1 = "SELECT PM.Sup_ID, SM.Sup_Name, SUM(PM.Pay_PaidAmt) as 'PAID' ";
            qry1 += "FROM tbl12_PaymentMaster PM, tbl1_SupMaster SM ";
            qry1 += "WHERE PM.Sup_ID = SM.Sup_ID AND ";
            qry1 += "PM.Pay_Act = 'TRUE' ";
            qry1 += "GROUP BY PM.Sup_ID, SM.Sup_Name ";
            qry1 += "ORDER BY PM.Sup_ID";

            qry2 = "SELECT pm.Sup_ID, SM.Sup_Name, SUM(PM.Pur_TotAmt) as 'Purchase' ";
            qry2 += "FROM tbl7_PurchaseMaster PM, tbl1_SupMaster SM ";
            qry2 += "WHERE PM.Sup_ID = SM.Sup_ID AND ";
            qry2 += "PM.Pur_Act = 'TRUE' AND ";
            qry2 += "pm.Sup_ID IN (SELECT DISTINCT(Sup_ID) FROM tbl12_PaymentMaster WHERE Pay_Act = 'TRUE') ";
            qry2 += "GROUP BY PM.Sup_ID, SM.Sup_Name ";
            qry2 += "ORDER BY PM.Sup_ID";

            qry3 = "SELECT pm.Sup_ID, SM.Sup_Name, SUM(PM.Pur_TotAmt) as 'Purchase' ";
            qry3 += "FROM tbl7_PurchaseMaster PM, tbl1_SupMaster SM ";
            qry3 += "WHERE PM.Sup_ID = SM.Sup_ID AND ";
            qry3 += "PM.Pur_Act = 'TRUE' AND ";
            qry3 += "pm.Sup_ID NOT IN (SELECT DISTINCT(Sup_ID) FROM tbl12_PaymentMaster WHERE Pay_Act = 'TRUE') ";
            qry3 += "GROUP BY PM.Sup_ID, SM.Sup_Name ";
            qry3 += "ORDER BY PM.Sup_ID";


            LoadDataTables(qry1, qry2, qry3);
            btn_print.Enabled = true;

            c.LoadSearchDDL(ddl_Sup_name,dtg_SPS);
        }

        

        void LoadDataTables(string q1,string q2, string q3)
        {
            DataTable DT_SupPaid = new DataTable();
            DataTable DT_SupPur_Paid = new DataTable();
            DataTable DT_SupPur_NotPaid = new DataTable();

            ///////// For Payment data table ////////////
            QRY = q1;
            DT_SupPaid = c.BindDataTable(DT_SupPaid, QRY);
            
            ///////// For paid-Pauchase data table ////////////
            QRY = q2;
            DT_SupPur_Paid = c.BindDataTable(DT_SupPur_Paid, QRY);

            ///////// For paid-Pauchase data table ////////////
            QRY = q3;
            DT_SupPur_NotPaid = c.BindDataTable(DT_SupPur_NotPaid, QRY);

            //////// DataTables to DataGrid Transfer /////////
            if (c.DTsToDG_Summry(DT_SupPaid, DT_SupPur_Paid, DT_SupPur_NotPaid, dtg_SPS) > 0)
                dtg_SPS.Visible = true;
            else
            {
                dtg_SPS.Visible = false;
                MessageBox.Show("NO Record Found..");
            }
        }
           

        

        private void ddl_Sup_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_Sup_name.SelectedIndex > 0)
            {
                for (int i = 0; i < dtg_SPS.Rows.Count; i++)
                {
                    if (dtg_SPS.Rows[i].Cells[1].Value.ToString() == ddl_Sup_name.Items[ddl_Sup_name.SelectedIndex].ToString())
                    {
                        dtg_SPS.Rows[i].Selected = true;
                    }
                }
                btn_print.Enabled = false;
            }
            else
            {
                dtg_SPS.Rows[0].Selected = true;
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
            
            foreach (DataGridViewColumn DGC in dtg_SPS.Columns)
                DT.Columns.Add(DGC.HeaderText.ToString());
            
            for (int i = 0; i < dtg_SPS.Rows.Count; i++)
            {
                DT.Rows.Add();
                for (int j = 0; j < dtg_SPS.Columns.Count;j++)
                {
                    DT.Rows[i][j] = dtg_SPS.Rows[i].Cells[j].Value.ToString();
                }
            }            
            DataSet DS = new DataSet();
            DS.Tables.Add(DT);
            DS.WriteXml(@"C:\Sum_Sup_Payments.xml");
            RPT_Summry_Sup rpt = new RPT_Summry_Sup();
            rpt.ShowDialog();
        }

    }
}
