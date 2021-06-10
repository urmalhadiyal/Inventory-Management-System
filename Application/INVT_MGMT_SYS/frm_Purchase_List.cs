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
    public partial class frm_Purchase_List : Form
    {
        public frm_Purchase_List()
        {
            InitializeComponent();
        }

        public frm_Purchase_List(string pm_id)
        {
            InitializeComponent();
            lbl_PM.Text = pm_id;
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
            {
                lbl.Text = DR.GetValue(0).ToString();
            }

            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
        }

        void BindMyGrid()
        {
            QRY = "SELECT PL.PL_ID, PRM.Pro_Name, PL.Qty, PL.PL_Rate, (PL.Qty*PL.PL_Rate) FROM ";
            QRY += "tbl8_PurListMaster PL, tbl4_ProMaster PRM";
            QRY += " WHERE ";
            QRY += "PL.Pro_ID = PRM.Pro_ID ";
            QRY += " AND PL.Pur_ID=" + lbl_PM.Text.ToString() + "";
            QRY += " AND PL.PL_ID > 0";
            QRY += " AND PL.PL_Act = 'True'";
            QRY += " ORDER BY PL.PL_ID DESC";


            c.BindMyGrid(QRY, dtg_Pur_list);
            if (dtg_Pur_list.Rows.Count > 0)
            {
                dtg_Pur_list.Visible = true;
                txt_nos.Text = dtg_Pur_list.Rows.Count.ToString();
                int tot = 0;
                for (int x = 0; x < dtg_Pur_list.Rows.Count; x++)
                    tot += int.Parse(dtg_Pur_list.Rows[x].Cells[4].Value.ToString());
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
            lbl_PL.Text = dtg_Pur_list.Rows[RID].Cells[0].Value.ToString();
            ddl_Product_Name.SelectedItem = dtg_Pur_list.Rows[RID].Cells[1].Value.ToString();
            txt_QTY.Text = dtg_Pur_list.Rows[RID].Cells[2].Value.ToString();
            txt_Rate.Text = dtg_Pur_list.Rows[RID].Cells[3].Value.ToString();
        }

        void FillMaster(string qry)
        {
            SqlConnection cnn = new SqlConnection(c.cnstr());
            SqlCommand cmd = new SqlCommand(QRY, cnn);
            cnn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
               
                ddl_sup_name.SelectedItem = DR.GetValue(0).ToString();
                txt_om_id.Text = DR.GetValue(1).ToString();
                dtp_inv_date.Text = DR.GetValue(2).ToString();
                txt_inv_no.Text = DR.GetValue(3).ToString();
                ddl_pay_type.SelectedItem = DR.GetValue(4).ToString();
                ddl_trans.SelectedItem = DR.GetValue(5).ToString();
                txt_Remarks.Text = DR.GetValue(6).ToString();                
            }
            DR.Close();
            cnn.Close();
            cnn.Dispose();
            cmd.Dispose();
        }


        private void frm_Purchase_List_Load(object sender, EventArgs e)
        {
            QRY = "SELECT Sup_Name FROM tbl1_SupMaster WHERE Sup_ID > 0 AND Sup_Act = 'True'";
            c.LoadDDL(ddl_sup_name, QRY);

            QRY = "SELECT Pro_Name FROM tbl4_ProMaster WHERE Pro_ID > 0 AND Pro_Act = 'True'";
            c.LoadDDL(ddl_Product_Name, QRY);

            QRY = "SELECT Tm_Name FROM tbl2_TransMaster WHERE Tm_ID > 0 AND Tm_Act = 'True'";
            c.LoadDDL(ddl_trans, QRY);

            ddl_pay_type.SelectedIndex = 0;
          
            if (this.Text == "Edit Purchase Invoice")
            {
                btn_Action.Text = "Update";
                btn_pro_ADD.Text = "Change";
                btn_Cancel.Visible = false;
                BindMyGrid();

                QRY = "SELECT  SM.Sup_Name, PM.OM_ID, PM.Pur_Date, PM.Pur_InvNo, PM.Pur_PayType, TM.Tm_Name, PM.Pur_Remarks FROM ";
                QRY += "tbl5_OrderMaster OM, tbl1_SupMaster SM, tbl2_TransMaster TM, tbl7_PurchaseMaster PM";
                QRY += " WHERE ";
                QRY += "PM.Sup_ID = SM.Sup_ID";
                QRY += " AND PM.Pur_ID=" + lbl_PM.Text + "";
                QRY += " AND PM.Pur_ID > 0";
                QRY += " AND PM.Pur_Act = 'True'";
                FillMaster(QRY);
            }

        }

        private void frm_Purchase_List_TextChanged(object sender, EventArgs e)
        {
            lbl_Title.Text = this.Text;
            if (this.Text == "New Purchase Invoice")
            {
                btn_Action.Text = "Save";

                QRY = "SELECT MAX(Pur_ID) + 1 FROM tbl7_PurchaseMaster";
                SET_ID(lbl_PM, QRY);
            }
            else if (this.Text == "Edit Purchase Invoice")
            {
                btn_Action.Text = "Update";
                btn_pro_ADD.Text = "Change";
                btn_Cancel.Visible = false;
                BindMyGrid();

                QRY = "SELECT  SM.Sup_Name, PM.OM_ID, PM.Pur_Date, PM.Pur_InvNo, PM.Pur_PayType, TM.Tm_Name, PM.Pur_Remarks FROM ";
                QRY += "tbl5_OrderMaster OM, tbl1_SupMaster SM, tbl2_TransMaster TM, tbl7_PurchaseMaster PM";
                QRY += " WHERE ";
                QRY += "PM.Sup_ID = SM.Sup_ID";
                QRY += " AND PM.Pur_ID=" + lbl_PM.Text + "";
                QRY += " AND PM.Pur_ID > 0";
                QRY += " AND PM.Pur_Act = 'True'";
                FillMaster(QRY);
            }
        }

        private void btn_pro_ADD_Click(object sender, EventArgs e)
        {
            if (ddl_Product_Name.SelectedIndex > 0 && ddl_sup_name.SelectedIndex > 0 && btn_pro_ADD.Text == "ADD" && txt_om_id.Text != "" && txt_inv_no.Text!="")
            {
                QRY = "INSERT INTO tbl8_PurListMaster VALUES (";
                QRY += "(SELECT MAX(PL_ID) + 1 FROM tbl8_PurListMaster),";
                QRY += ""+lbl_PM.Text + ",";
                QRY += "(SELECT Pro_ID FROM tbl4_ProMaster WHERE Pro_Name ='" + ddl_Product_Name.Items[ddl_Product_Name.SelectedIndex].ToString() + "') ,";
                QRY += "" + txt_QTY.Text + "," + txt_Rate.Text + ",'TRUE')";

                if (c.TransMyData(QRY) > 0)
                    BindMyGrid();
                else
                    MessageBox.Show("Error : Data Cann't be Added..");

                ClearMyControls();
                ddl_Product_Name.Focus();
            }
            else if (ddl_Product_Name.SelectedIndex > 0 && ddl_sup_name.SelectedIndex > 0 && btn_pro_ADD.Text == "Change" && txt_om_id.Text != "")
            {
                QRY = "Update tbl8_PurListMaster SET ";
                QRY += "Pro_ID = (Select Pro_ID from tbl4_ProMaster Where Pro_Name='" + ddl_Product_Name.Items[ddl_Product_Name.SelectedIndex].ToString() + "'), ";
                QRY += "Qty = " + txt_QTY.Text + ",";
                QRY += "PL_Rate = " + txt_Rate.Text + "";
                QRY += " Where";
                QRY += " PL_ID = " + lbl_PL.Text + "";


                if (c.TransMyData(QRY) > 0)
                    BindMyGrid();
                else
                    MessageBox.Show("Error : Data Cann't be Updated..");

                ddl_Product_Name.Focus();
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Save" && ddl_sup_name.SelectedIndex > 0 && txt_om_id.Text != "" && txt_inv_no.Text != "" && ddl_trans.SelectedIndex > 0)
            {
                QRY = "INSERT INTO tbl7_PurchaseMaster VALUES(" + lbl_PM.Text + ",(SELECT Sup_ID FROM tbl1_SupMaster WHERE Sup_Name ='" + ddl_sup_name.Items[ddl_sup_name.SelectedIndex].ToString() + "') ,"+txt_om_id.Text+",'" + dtp_inv_date.Text + "','"+txt_inv_no.Text.ToString()+"', " + txt_nos.Text + "," + txt_tot_amt.Text + ",'"+ ddl_pay_type.Items[ddl_pay_type.SelectedIndex].ToString()+"',(SELECT Tm_ID FROM tbl2_TransMaster WHERE Tm_Name ='"+ ddl_trans.Items[ddl_trans.SelectedIndex].ToString() +"'),'" + txt_Remarks.Text + "','TRUE')";
                
                if (c.TransMyData(QRY) > 0)
                    this.Close();
                else
                    MessageBox.Show("Sorry! Data Can not be Added..");
            }
            else if (btn_Action.Text == "Update" && ddl_sup_name.SelectedIndex > 0 && txt_om_id.Text != "" && txt_inv_no.Text != "" && ddl_trans.SelectedIndex > 0)
            {
                QRY = "Update tbl7_PurchaseMaster SET";
                QRY += " Pur_Date ='" + dtp_inv_date.Text + "',";
                QRY += " OM_ID = "+txt_om_id.Text+",";
                QRY += " Pur_InvNo = '" + txt_inv_no.Text + "',";
                QRY += " Sup_ID = (SELECT Sup_ID FROM tbl1_SupMaster WHERE Sup_Name ='" + ddl_sup_name.Items[ddl_sup_name.SelectedIndex].ToString() + "'),";
                QRY += " Pur_Qty=" + txt_nos.Text + ",";
                QRY += " Pur_TotAmt = " + txt_tot_amt.Text + ",";
                QRY += " Pur_Remarks='" + txt_Remarks.Text + "'";
                QRY += " Where";
                QRY += " Pur_ID=" + lbl_PM.Text + "";

                if (c.TransMyData(QRY) > 0)
                    this.Close();
                else
                    MessageBox.Show("Sorry! Data Can not be Updated..");

            }
        
        
        }

        private void dtg_Pur_list_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillToControls(e.RowIndex);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (this.Text == "New Purchase Invoice")
            {
                QRY = "delete tbl8_PurListMaster Where Pur_ID = " + lbl_PM.Text + "";
                if (c.TransMyData(QRY) > 0)
                    this.Close();
            }

        }

    }
}
