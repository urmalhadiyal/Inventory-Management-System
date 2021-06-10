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
    public partial class frm_Order_List : Form
    {
        public frm_Order_List()
        {
            InitializeComponent();
        }

        public frm_Order_List(string om_id)
        {
            InitializeComponent();
            lbl_OM.Text = om_id;
        }



        Connection c = new Connection();
        String QRY = String.Empty;
//        string cnstr = "Data Source=PC179;Initial Catalog=DB_IMS;Integrated Security=True";


        void SET_ID(Label lbl, string QRY)
        {
            SqlConnection cnn = new SqlConnection(c.cnstr());
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
                lbl.Text = DR.GetValue(0).ToString();
            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
        }

        void BindMyGrid()
        {
            QRY = "SELECT OL.OL_ID, PM.Pro_Name, OL.Qty, Ol.OL_Rate, (OL.Qty*OL.OL_Rate) FROM ";
            QRY += "tbl6_OrderListMaster OL,tbl4_ProMaster PM";
            QRY += " WHERE ";
            QRY += "OL.Pro_ID = PM.Pro_ID AND OL.OM_ID=" + lbl_OM.Text.ToString() + "";
            QRY += " AND OL.OL_ID > 0";
            QRY += " AND OL.OL_Act = 'True'";
            QRY += " ORDER BY OL.OL_ID DESC";


            c.BindMyGrid(QRY, dtg_OL);
            if (dtg_OL.Rows.Count > 0)
            {
                dtg_OL.Visible = true;
                txt_nos.Text = dtg_OL.Rows.Count.ToString();
                int tot = 0;
                for (int x = 0; x < dtg_OL.Rows.Count; x++)
                    tot += int.Parse(dtg_OL.Rows[x].Cells[4].Value.ToString());
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
            lbl_OL.Text = dtg_OL.Rows[RID].Cells[0].Value.ToString();
            ddl_Product_Name.SelectedItem = dtg_OL.Rows[RID].Cells[1].Value.ToString();
            txt_QTY.Text = dtg_OL.Rows[RID].Cells[2].Value.ToString();
            txt_Rate.Text = dtg_OL.Rows[RID].Cells[3].Value.ToString();
        }

        void Fill(string qry)
        {
            SqlConnection cnn = new SqlConnection(c.cnstr());
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                dtp_OL.Text = DR.GetValue(0).ToString();
                ddl_sup_name.SelectedItem = DR.GetValue(1).ToString();
                txt_Remarks.Text = DR.GetValue(2).ToString();
            }
            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
        }

        private void frm_Order_List_TextChanged(object sender, EventArgs e)
        {
            lbl_Title.Text = this.Text;
            if (this.Text == "NEW ORDER")
            {
                btn_Action.Text = "Save";

                QRY = "SELECT MAX(OM_ID) + 1 FROM tbl5_OrderMaster";
                SET_ID(lbl_OM, QRY);
            }
            else if (this.Text == "EDIT ORDER")
            {
                btn_Action.Text = "Update";
                btn_pro_ADD.Text = "Change";
                btn_cancel.Visible = false;
                BindMyGrid();

                QRY = "SELECT OM.OM_Date, SM.Sup_Name, OM.OM_Remarks FROM ";
                QRY += "tbl5_OrderMaster OM,tbl1_SupMaster SM";
                QRY += " WHERE ";
                QRY += "OM.Sup_ID = SM.Sup_ID AND OM.OM_ID=" + lbl_OM.Text + "";
                QRY += " AND OM.OM_ID > 0";
                QRY += " AND OM.OM_Act = 'True'";
                Fill(QRY);
            }

        }


        private void frm_Order_List_Load(object sender, EventArgs e)
        {
            QRY = "SELECT Sup_Name FROM tbl1_SupMaster WHERE Sup_ID > 0 AND Sup_Act = 'True'";
            c.LoadDDL(ddl_sup_name, QRY);

            QRY = "SELECT Pro_Name FROM tbl4_ProMaster WHERE Pro_ID > 0 AND Pro_Act = 'True'";
            c.LoadDDL(ddl_Product_Name, QRY);

            if (this.Text == "EDIT ORDER")
            {
                btn_Action.Text = "Update";
                btn_pro_ADD.Text = "Change";
                btn_cancel.Visible = false;
                BindMyGrid();

                QRY = "SELECT OM.OM_Date, SM.Sup_Name, OM.OM_Remarks FROM ";
                QRY += "tbl5_OrderMaster OM,tbl1_SupMaster SM";
                QRY += " WHERE ";
                QRY += "OM.Sup_ID = SM.Sup_ID AND OM.OM_ID=" + lbl_OM.Text + "";
                QRY += " AND OM.OM_ID > 0";
                QRY += " AND OM.OM_Act = 'True'";
                Fill(QRY);
            }


        }

        private void btn_pro_ADD_Click(object sender, EventArgs e)
        {
            if (ddl_Product_Name.SelectedIndex > 0 && ddl_sup_name.SelectedIndex > 0 && btn_pro_ADD.Text == "ADD")
            {
                QRY = "INSERT INTO tbl6_OrderListMaster VALUES((SELECT MAX(OL_ID) + 1 FROM tbl6_OrderListMaster)," + lbl_OM.Text + ",(SELECT Pro_ID FROM tbl4_ProMaster WHERE Pro_Name ='" + ddl_Product_Name.Items[ddl_Product_Name.SelectedIndex].ToString() + "') , '" + txt_QTY.Text + "','" + txt_Rate.Text + "','TRUE')";

                if (c.TransMyData(QRY) > 0)
                    BindMyGrid();
                else
                    MessageBox.Show("Error : Data Cann't be Added..");

                ClearMyControls();
                ddl_Product_Name.Focus();
            }
            else if (ddl_Product_Name.SelectedIndex > 0 && ddl_sup_name.SelectedIndex > 0 && btn_pro_ADD.Text == "Change")
            {
                QRY = "Update tbl6_OrderListMaster SET ";
                QRY += "Pro_ID=(Select Pro_ID from tbl4_ProMaster Where Pro_Name='" + ddl_Product_Name.Items[ddl_Product_Name.SelectedIndex].ToString() + "'), ";
                QRY += "Qty=" + txt_QTY.Text + ",";
                QRY += " OL_Rate=" + txt_Rate.Text + "";
                QRY += " Where";
                QRY += " OL_ID=" + lbl_OL.Text + "";


                if (c.TransMyData(QRY) > 0)
                    BindMyGrid();
                else
                    MessageBox.Show("Error : Data Cann't be Updated..");

                ddl_Product_Name.Focus();
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Save" && ddl_sup_name.SelectedIndex > 0)
            {
                QRY = "INSERT INTO tbl5_OrderMaster VALUES(" + lbl_OM.Text + ",'" + dtp_OL.Text + "',(SELECT Sup_ID FROM tbl1_SupMaster WHERE Sup_Name ='" + ddl_sup_name.Items[ddl_sup_name.SelectedIndex].ToString() + "') , " + txt_nos.Text + "," + txt_tot_amt.Text + ",'" + txt_Remarks.Text + "','TRUE')";

                if (c.TransMyData(QRY) > 0)
                    this.Close();
                else
                    MessageBox.Show("Sorry! Data Can not be Added..");
            }
            else if (btn_Action.Text == "Update" && ddl_sup_name.SelectedIndex > 0)
            {
                QRY = "Update tbl5_OrderMaster SET";
                QRY += " OM_Date ='" + dtp_OL.Text + "',";
                QRY += " Sup_ID=(SELECT Sup_ID FROM tbl1_SupMaster WHERE Sup_Name ='" + ddl_sup_name.Items[ddl_sup_name.SelectedIndex].ToString() + "'),";
                QRY += " OM_Qty=" + txt_nos.Text + ",";
                QRY += " OM_TOT_AMT=" + txt_tot_amt.Text + ",";
                QRY += " OM_Remarks='" + txt_Remarks.Text + "'";
                QRY += " Where";
                QRY += " OM_ID=" + lbl_OM.Text + "";

                if (c.TransMyData(QRY) > 0)
                    this.Close();
                else
                    MessageBox.Show("Sorry! Data Can not be Updated..");

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (this.Text == "NEW ORDER")
            {
                QRY = "delete tbl6_OrderListMaster Where OM_ID=" + lbl_OM.Text + "";
                if (c.TransMyData(QRY) > 0)
                    this.Close();
            }
            
        }

        private void dtg_OL_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillToControls(e.RowIndex);
        }


    }
}
