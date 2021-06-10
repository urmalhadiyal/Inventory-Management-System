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
    public partial class frm_Master : Form
    {
        public frm_Master()
        {
            InitializeComponent();
        }

        private void frm_Master_Load(object sender, EventArgs e)
        {
            //this.MaximumSize = new Size(1551, 823);
            this.CenterToScreen();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            //frm_Order_Master OM = new frm_Order_Master();
            //OM.MdiParent = this;
            //// OM.ShowDialog();
            //OM.Show();

            frm_Order_Master OM = new frm_Order_Master();
            OM.ShowInTaskbar = false;
            OM.ShowDialog();
            
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            frm_PurchaseMaster PM = new frm_PurchaseMaster();
            PM.ShowInTaskbar = false;
            PM.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            frm_SalesMaster SM = new frm_SalesMaster();
            SM.ShowInTaskbar = false;
            SM.ShowDialog();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            frm_supmast Sup = new frm_supmast();
            Sup.ShowInTaskbar = false;
            Sup.ShowDialog();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            frm_Customers cust = new frm_Customers();
            cust.ShowInTaskbar = false;
            cust.ShowDialog();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            frm_Product_master Product = new frm_Product_master();
            Product.ShowInTaskbar = false;
            Product.ShowDialog();
        }

        private void btn_Pro_Cat_Click(object sender, EventArgs e)
        {
            frm_Product_Types cat = new frm_Product_Types();
            cat.ShowInTaskbar = false;
            cat.ShowDialog();
        }

        private void btn_Transport_Click(object sender, EventArgs e)
        {
            frm_transport TR = new frm_transport();
            TR.ShowInTaskbar = false;
            TR.ShowDialog();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            frm_Payment payment = new frm_Payment();
            payment.ShowInTaskbar = false;
            payment.ShowDialog();
        }

        private void btn_Receipe_Click(object sender, EventArgs e)
        {
            frm_recipes recipe = new frm_recipes();
            recipe.ShowInTaskbar = false;
            recipe.ShowDialog();
        }

        private void btn_Payable_Click(object sender, EventArgs e)
        {
            frm_Summry_Sup_Payment payable = new frm_Summry_Sup_Payment();
            payable.ShowInTaskbar = false;
            payable.ShowDialog();
        }

        private void btn_receivable_Click(object sender, EventArgs e)
        {
            frm_Summry_Cust_Recipe receivable = new frm_Summry_Cust_Recipe();
            receivable.ShowInTaskbar = false;
            receivable.ShowDialog();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            frm_Stock_Mgmt stock = new frm_Stock_Mgmt();
            stock.ShowInTaskbar = false;
            stock.ShowDialog();
        }

        private void frm_Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FormCollection fc = Application.OpenForms;

            //foreach (Form frm in fc)
            //{
            //    e.Cancel = false;
            //}
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


    }
}
