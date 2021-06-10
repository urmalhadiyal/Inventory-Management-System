namespace INVT_MGMT_SYS
{
    partial class frm_Sales_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_inv_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.ddl_Product_Name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QTY = new System.Windows.Forms.TextBox();
            this.ddl_CustName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pro_ADD = new System.Windows.Forms.Button();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.lbl_SM = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Action = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.ddl_pay_type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tot_amt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nos = new System.Windows.Forms.TextBox();
            this.dtg_SL = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 31);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(305, 8);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(98, 20);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Sales Invoice";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Stock);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_inv_date);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Rate);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_Product_Name);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_SL);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txt_QTY);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_CustName);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_pro_ADD);
            this.splitContainer1.Panel1.Controls.Add(this.txt_inv_no);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_SM);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Action);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Remarks);
            this.splitContainer1.Panel2.Controls.Add(this.ddl_pay_type);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txt_tot_amt);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txt_nos);
            this.splitContainer1.Panel2.Controls.Add(this.dtg_SL);
            this.splitContainer1.Size = new System.Drawing.Size(716, 422);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Stock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_Stock.ForeColor = System.Drawing.Color.Red;
            this.lbl_Stock.Location = new System.Drawing.Point(341, 94);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(43, 19);
            this.lbl_Stock.TabIndex = 16;
            this.lbl_Stock.Text = "Stock";
            this.lbl_Stock.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.Location = new System.Drawing.Point(499, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "(mm-dd-yyyy)";
            // 
            // dtp_inv_date
            // 
            this.dtp_inv_date.CustomFormat = "MM-dd-yyyy";
            this.dtp_inv_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inv_date.Location = new System.Drawing.Point(504, 36);
            this.dtp_inv_date.Name = "dtp_inv_date";
            this.dtp_inv_date.Size = new System.Drawing.Size(178, 24);
            this.dtp_inv_date.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rate";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(432, 94);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(100, 24);
            this.txt_Rate.TabIndex = 3;
            // 
            // ddl_Product_Name
            // 
            this.ddl_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Product_Name.FormattingEnabled = true;
            this.ddl_Product_Name.Location = new System.Drawing.Point(23, 94);
            this.ddl_Product_Name.Name = "ddl_Product_Name";
            this.ddl_Product_Name.Size = new System.Drawing.Size(168, 25);
            this.ddl_Product_Name.TabIndex = 1;
            this.ddl_Product_Name.SelectedIndexChanged += new System.EventHandler(this.ddl_Product_Name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product Name";
            // 
            // lbl_SL
            // 
            this.lbl_SL.AutoSize = true;
            this.lbl_SL.Location = new System.Drawing.Point(389, 36);
            this.lbl_SL.Name = "lbl_SL";
            this.lbl_SL.Size = new System.Drawing.Size(21, 17);
            this.lbl_SL.TabIndex = 9;
            this.lbl_SL.Text = "SL";
            this.lbl_SL.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "QTY";
            // 
            // txt_QTY
            // 
            this.txt_QTY.Location = new System.Drawing.Point(221, 94);
            this.txt_QTY.Name = "txt_QTY";
            this.txt_QTY.Size = new System.Drawing.Size(100, 24);
            this.txt_QTY.TabIndex = 2;
            // 
            // ddl_CustName
            // 
            this.ddl_CustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_CustName.FormattingEnabled = true;
            this.ddl_CustName.Location = new System.Drawing.Point(170, 36);
            this.ddl_CustName.Name = "ddl_CustName";
            this.ddl_CustName.Size = new System.Drawing.Size(168, 25);
            this.ddl_CustName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Invoice No";
            // 
            // btn_pro_ADD
            // 
            this.btn_pro_ADD.Location = new System.Drawing.Point(584, 94);
            this.btn_pro_ADD.Name = "btn_pro_ADD";
            this.btn_pro_ADD.Size = new System.Drawing.Size(75, 32);
            this.btn_pro_ADD.TabIndex = 4;
            this.btn_pro_ADD.Text = "ADD";
            this.btn_pro_ADD.UseVisualStyleBackColor = true;
            this.btn_pro_ADD.Click += new System.EventHandler(this.btn_pro_ADD_Click);
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Location = new System.Drawing.Point(23, 36);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.ReadOnly = true;
            this.txt_inv_no.Size = new System.Drawing.Size(100, 24);
            this.txt_inv_no.TabIndex = 0;
            this.txt_inv_no.Text = "IMS_SI_";
            // 
            // lbl_SM
            // 
            this.lbl_SM.AutoSize = true;
            this.lbl_SM.Location = new System.Drawing.Point(389, 11);
            this.lbl_SM.Name = "lbl_SM";
            this.lbl_SM.Size = new System.Drawing.Size(27, 17);
            this.lbl_SM.TabIndex = 0;
            this.lbl_SM.Text = "SM";
            this.lbl_SM.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(595, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 33);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Action
            // 
            this.btn_Action.Location = new System.Drawing.Point(491, 225);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(78, 33);
            this.btn_Action.TabIndex = 7;
            this.btn_Action.Text = "Action";
            this.btn_Action.UseVisualStyleBackColor = true;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Remarks";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(574, 152);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(133, 59);
            this.txt_Remarks.TabIndex = 6;
            // 
            // ddl_pay_type
            // 
            this.ddl_pay_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_pay_type.FormattingEnabled = true;
            this.ddl_pay_type.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.ddl_pay_type.Location = new System.Drawing.Point(574, 114);
            this.ddl_pay_type.Name = "ddl_pay_type";
            this.ddl_pay_type.Size = new System.Drawing.Size(133, 25);
            this.ddl_pay_type.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Payment_Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Amout";
            // 
            // txt_tot_amt
            // 
            this.txt_tot_amt.Location = new System.Drawing.Point(574, 51);
            this.txt_tot_amt.Name = "txt_tot_amt";
            this.txt_tot_amt.ReadOnly = true;
            this.txt_tot_amt.Size = new System.Drawing.Size(133, 24);
            this.txt_tot_amt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total QTY";
            // 
            // txt_nos
            // 
            this.txt_nos.Location = new System.Drawing.Point(574, 13);
            this.txt_nos.Name = "txt_nos";
            this.txt_nos.ReadOnly = true;
            this.txt_nos.Size = new System.Drawing.Size(133, 24);
            this.txt_nos.TabIndex = 14;
            // 
            // dtg_SL
            // 
            this.dtg_SL.AllowUserToAddRows = false;
            this.dtg_SL.AllowUserToDeleteRows = false;
            this.dtg_SL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product_Name,
            this.QTY,
            this.SL_Rate,
            this.Sub_Tot});
            this.dtg_SL.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtg_SL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_SL.Location = new System.Drawing.Point(0, 0);
            this.dtg_SL.Name = "dtg_SL";
            this.dtg_SL.ReadOnly = true;
            this.dtg_SL.RowHeadersVisible = false;
            this.dtg_SL.RowTemplate.Height = 28;
            this.dtg_SL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_SL.Size = new System.Drawing.Size(468, 282);
            this.dtg_SL.StandardTab = true;
            this.dtg_SL.TabIndex = 0;
            this.dtg_SL.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SL_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SL_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.DataPropertyName = "Pro_Name";
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QTY.DataPropertyName = "Qty";
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // SL_Rate
            // 
            this.SL_Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL_Rate.DataPropertyName = "SL_Rate";
            this.SL_Rate.HeaderText = "Rate";
            this.SL_Rate.Name = "SL_Rate";
            this.SL_Rate.ReadOnly = true;
            // 
            // Sub_Tot
            // 
            this.Sub_Tot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sub_Tot.DataPropertyName = "Column1";
            this.Sub_Tot.HeaderText = "Sub Total";
            this.Sub_Tot.Name = "Sub_Tot";
            this.Sub_Tot.ReadOnly = true;
            // 
            // frm_Sales_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Sales_List";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Sales_List_FormClosing);
            this.Load += new System.EventHandler(this.frm_Sales_List_Load);
            this.TextChanged += new System.EventHandler(this.frm_Sales_List_TextChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_pro_ADD;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.Label lbl_SM;
        private System.Windows.Forms.DataGridView dtg_SL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddl_CustName;
        private System.Windows.Forms.Label lbl_SL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_QTY;
        private System.Windows.Forms.ComboBox ddl_Product_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.DateTimePicker dtp_inv_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tot_amt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddl_pay_type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Tot;
    }
}