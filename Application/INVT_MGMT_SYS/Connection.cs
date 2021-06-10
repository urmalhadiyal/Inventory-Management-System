using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;


namespace INVT_MGMT_SYS
{
    public class Connection
    {
        SqlConnection CNN;
        SqlCommand CMD;
        SqlDataAdapter DA;
        static string QRY = string.Empty;
 //      static string cnStr = "Data Source=PC178;Initial Catalog=DB_IMS;Integrated Security=True";
        //static string cnStr = "Data Source=STAFF2;Initial Catalog=DB_IMS;Integrated Security=True";
        static string cnStr = "Data Source=DESKTOP-OTO79BH;Initial Catalog=DB_IMS;Integrated Security=True";
        System.Data.DataSet DS;

        public string cnstr()
        { return cnStr; }

        public void LoadDDL(ComboBox ddl_Name, string QRY)
        {
            ddl_Name.Items.Clear();
            ddl_Name.Items.Add("-- SELECT --");

            SqlConnection cnn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
                ddl_Name.Items.Add(DR.GetValue(0).ToString());
            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
            ddl_Name.SelectedIndex = 0;

            //return ddl_Name;
        }

        public void LoadSearchDDL(ComboBox ddl_Name, System.Windows.Forms.DataGridView myDtGrd)
        {
            ddl_Name.Items.Clear();
            ddl_Name.Items.Add("-- Select --");
            foreach (DataGridViewRow DGR in myDtGrd.Rows)
                ddl_Name.Items.Add(DGR.Cells[1].Value.ToString());
            ddl_Name.SelectedIndex = 0;
        }


        public int TransMyData(string myQRY)
        {
            int i = 0;
            try
            {
                CNN = new SqlConnection(cnStr);
                CMD = new SqlCommand(myQRY, CNN);
                CNN.Open();
                CMD.ExecuteNonQuery();
                CNN.Close();
                CNN.Dispose();
                CMD.Dispose();
                i++;
            }
            catch { }
            return i;
        }

        public void BindMyGrid(string QRY, System.Windows.Forms.DataGridView myDtGrd)
        {
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            DA = new SqlDataAdapter(CMD);
            DS = new DataSet();
            DA.Fill(DS);
            myDtGrd.DataSource = DS.Tables[0];
            //myDtGrd.Visible = false;
        }

        public DataTable BindDataTable(DataTable dt, string QRY)
        {
            DataTable DT_A = dt;

            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            DA = new SqlDataAdapter(CMD);
            DA.Fill(DT_A);
            CNN.Close();
            CMD.Dispose();
            
            DA.Dispose();
            CNN.Dispose();

            return DT_A;
        }

        public int DTsToDG_Summry(DataTable dt_Payment, DataTable dt_paidPur, DataTable dt_Not_paidPur, System.Windows.Forms.DataGridView myDtGrd)
        {
            myDtGrd.Rows.Clear();
            int myRow = 0;
            for (int i = 0; i < dt_Payment.Rows.Count; i++)
            {
                double diff = (double.Parse(dt_paidPur.Rows[i][2].ToString()) - double.Parse(dt_Payment.Rows[i][2].ToString()));
                myDtGrd.Rows.Add();
                myDtGrd.Rows[i].Cells[0].Value = dt_paidPur.Rows[i][0].ToString();
                myDtGrd.Rows[i].Cells[1].Value = dt_paidPur.Rows[i][1].ToString();
                myDtGrd.Rows[i].Cells[2].Value = dt_paidPur.Rows[i][2].ToString();
                myDtGrd.Rows[i].Cells[3].Value = dt_Payment.Rows[i][2].ToString();
                myDtGrd.Rows[i].Cells[4].Value = diff.ToString();
                myRow++;
            }

            for (int i = 0; i < dt_Not_paidPur.Rows.Count; i++)
            {
                myDtGrd.Rows.Add();
                myDtGrd.Rows[myRow].Cells[0].Value = dt_Not_paidPur.Rows[i][0].ToString();
                myDtGrd.Rows[myRow].Cells[1].Value = dt_Not_paidPur.Rows[i][1].ToString();
                myDtGrd.Rows[myRow].Cells[2].Value = dt_Not_paidPur.Rows[i][2].ToString();
                myDtGrd.Rows[myRow].Cells[3].Value = "0";
                myDtGrd.Rows[myRow].Cells[4].Value = dt_Not_paidPur.Rows[i][2].ToString();
                myRow++;
            }

            return myDtGrd.Rows.Count;
        }


        public void Report_FORM(string QRY)
        {
            CNN = new SqlConnection(cnStr);
            CMD = new SqlCommand(QRY, CNN);
            DA = new SqlDataAdapter(CMD);
            DS = new DataSet();
            DA.Fill(DS);
            DS.WriteXml(@"C:\Sales_Invoice.xml");

        }


    }
}
