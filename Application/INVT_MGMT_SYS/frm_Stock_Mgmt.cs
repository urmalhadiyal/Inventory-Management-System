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
    public partial class frm_Stock_Mgmt : Form
    {
        public frm_Stock_Mgmt()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        String QRY = String.Empty;

        private void frm_Stock_Mgmt_Load(object sender, EventArgs e)
        {
            BindMyGrid();
        }

        void BindMyGrid()
        {
            string qry1, qry2, qry3;

            

            qry1 = "Select ";
            qry1 += "SL.Pro_ID, PM.Pro_Name, SUM(SL.Qty) as 'Sales' ";
            qry1 += "From tbl11_SalesListMaster SL, tbl4_ProMaster PM ";
            qry1 += "Where SL.Pro_ID=PM.Pro_ID AND ";
            qry1 += "SL.SL_Act = 'True' ";
            qry1 += "Group By SL.Pro_ID, PM.Pro_Name ";
            qry1 += "Order by SL.Pro_ID";

            qry2 = "Select ";
            qry2 += "PL.Pro_ID, PM.Pro_Name, SUM(PL.Qty) as 'Purchase' ";
            qry2 += "From tbl8_PurListMaster PL, tbl4_ProMaster PM ";
            qry2 += "Where PL.Pro_ID=PM.Pro_ID AND ";
            qry2 += "PL.PL_Act = 'True' AND ";
            qry2 += "PL.Pro_ID  IN (SELECT DISTINCT(Pro_ID) FROM tbl11_SalesListMaster WHERE SL_Act = 'TRUE') ";
            qry2 += "Group By PL.Pro_ID, PM.Pro_Name ";
            qry2 += "Order by PL.Pro_ID";

            qry3 = "Select ";
            qry3 += "PL.Pro_ID, PM.Pro_Name, SUM(PL.Qty) as 'Purchase' ";
            qry3 += "From tbl8_PurListMaster PL, tbl4_ProMaster PM ";
            qry3 += "Where PL.Pro_ID=PM.Pro_ID AND ";
            qry3 += "PL.PL_Act = 'True' AND ";
            qry3 += "PL.Pro_ID NOT IN (SELECT DISTINCT(Pro_ID) FROM tbl11_SalesListMaster WHERE SL_Act = 'TRUE') ";
            qry3 += "Group By PL.Pro_ID, PM.Pro_Name ";
            qry3 += "Order by PL.Pro_ID";

            LoadDataTables(qry1, qry2, qry3);
        }

        void LoadDataTables(string q1, string q2, string q3)
        {
        
            DataTable DT_SalesQty = new DataTable();
            DataTable DT_PurSold_Qty = new DataTable();
            DataTable DT_PurExist_Qty = new DataTable();


            ///////// For Payment data table ////////////
            QRY = q1;
            DT_SalesQty = c.BindDataTable(DT_SalesQty, QRY);

            ///////// For paid-Pauchase data table ////////////
            QRY = q2;
            DT_PurSold_Qty = c.BindDataTable(DT_PurSold_Qty, QRY);

            ///////// For paid-Pauchase data table ////////////
            QRY = q3;
            DT_PurExist_Qty = c.BindDataTable(DT_PurExist_Qty, QRY);

            //////// DataTables to DataGrid Transfer /////////
            if (c.DTsToDG_Summry(DT_SalesQty, DT_PurSold_Qty, DT_PurExist_Qty, dtg_Stock) > 0)
                dtg_Stock.Visible = true;
            else
            {
                dtg_Stock.Visible = false;
                MessageBox.Show("NO Record Found..");
            }
        }

        

        
        private void btn_Print_Click(object sender, EventArgs e)
        {
            GenerateDataTableForPrint();
        }

        void GenerateDataTableForPrint()
        {
            DataTable DT = new DataTable();

            foreach (DataGridViewColumn DGC in dtg_Stock.Columns)
                DT.Columns.Add(DGC.HeaderText.ToString());

            for (int i = 0; i < dtg_Stock.Rows.Count; i++)
            {
                DT.Rows.Add();
                for (int j = 0; j < dtg_Stock.Columns.Count; j++)
                {
                    DT.Rows[i][j] = dtg_Stock.Rows[i].Cells[j].Value.ToString();
                }
            }
            DataSet DS = new DataSet();
            DS.Tables.Add(DT);
            DS.WriteXml(@"C:\Stock.xml");
            RPT_Stock rpt = new RPT_Stock();
            rpt.ShowDialog();
        }


    }
}
