namespace INVT_MGMT_SYS
{
    partial class frm_Purchase_List
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PL = new System.Windows.Forms.Label();
            this.lbl_PM = new System.Windows.Forms.Label();
            this.btn_pro_ADD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.ddl_Product_Name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QTY = new System.Windows.Forms.TextBox();
            this.dtp_inv_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ddl_sup_name = new System.Windows.Forms.ComboBox();
            this.txt_om_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Action = new System.Windows.Forms.Button();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddl_trans = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ddl_pay_type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tot_amt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtg_Pur_list = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Pur_list)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_top.Controls.Add(this.lbl_Title);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(738, 31);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(304, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(126, 20);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Purchase Invoice";
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_PL);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_PM);
            this.splitContainer1.Panel1.Controls.Add(this.btn_pro_ADD);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Rate);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_Product_Name);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txt_QTY);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_inv_date);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_sup_name);
            this.splitContainer1.Panel1.Controls.Add(this.txt_om_id);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_inv_no);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Action);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Remarks);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.ddl_trans);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.ddl_pay_type);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txt_tot_amt);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txt_nos);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.dtg_Pur_list);
            this.splitContainer1.Size = new System.Drawing.Size(738, 478);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.Location = new System.Drawing.Point(572, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "(mm-dd-yyyy)";
            // 
            // lbl_PL
            // 
            this.lbl_PL.AutoSize = true;
            this.lbl_PL.Location = new System.Drawing.Point(495, 71);
            this.lbl_PL.Name = "lbl_PL";
            this.lbl_PL.Size = new System.Drawing.Size(21, 17);
            this.lbl_PL.TabIndex = 15;
            this.lbl_PL.Text = "PL";
            this.lbl_PL.Visible = false;
            // 
            // lbl_PM
            // 
            this.lbl_PM.AutoSize = true;
            this.lbl_PM.Location = new System.Drawing.Point(489, 36);
            this.lbl_PM.Name = "lbl_PM";
            this.lbl_PM.Size = new System.Drawing.Size(27, 17);
            this.lbl_PM.TabIndex = 14;
            this.lbl_PM.Text = "PM";
            this.lbl_PM.Visible = false;
            // 
            // btn_pro_ADD
            // 
            this.btn_pro_ADD.Location = new System.Drawing.Point(612, 97);
            this.btn_pro_ADD.Name = "btn_pro_ADD";
            this.btn_pro_ADD.Size = new System.Drawing.Size(75, 32);
            this.btn_pro_ADD.TabIndex = 6;
            this.btn_pro_ADD.Text = "ADD";
            this.btn_pro_ADD.UseVisualStyleBackColor = true;
            this.btn_pro_ADD.Click += new System.EventHandler(this.btn_pro_ADD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rate";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(357, 98);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(79, 24);
            this.txt_Rate.TabIndex = 5;
            // 
            // ddl_Product_Name
            // 
            this.ddl_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Product_Name.FormattingEnabled = true;
            this.ddl_Product_Name.Location = new System.Drawing.Point(16, 99);
            this.ddl_Product_Name.Name = "ddl_Product_Name";
            this.ddl_Product_Name.Size = new System.Drawing.Size(184, 25);
            this.ddl_Product_Name.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "QTY";
            // 
            // txt_QTY
            // 
            this.txt_QTY.Location = new System.Drawing.Point(233, 99);
            this.txt_QTY.Name = "txt_QTY";
            this.txt_QTY.Size = new System.Drawing.Size(79, 24);
            this.txt_QTY.TabIndex = 4;
            // 
            // dtp_inv_date
            // 
            this.dtp_inv_date.CustomFormat = "MM-dd-yyyy";
            this.dtp_inv_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inv_date.Location = new System.Drawing.Point(574, 32);
            this.dtp_inv_date.Name = "dtp_inv_date";
            this.dtp_inv_date.Size = new System.Drawing.Size(151, 24);
            this.dtp_inv_date.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Order ID";
            // 
            // ddl_sup_name
            // 
            this.ddl_sup_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_sup_name.FormattingEnabled = true;
            this.ddl_sup_name.Location = new System.Drawing.Point(304, 36);
            this.ddl_sup_name.Name = "ddl_sup_name";
            this.ddl_sup_name.Size = new System.Drawing.Size(162, 25);
            this.ddl_sup_name.TabIndex = 2;
            // 
            // txt_om_id
            // 
            this.txt_om_id.Location = new System.Drawing.Point(183, 35);
            this.txt_om_id.Name = "txt_om_id";
            this.txt_om_id.Size = new System.Drawing.Size(79, 24);
            this.txt_om_id.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Name";
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Location = new System.Drawing.Point(17, 34);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.Size = new System.Drawing.Size(127, 24);
            this.txt_inv_no.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice No";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(612, 270);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Action
            // 
            this.btn_Action.Location = new System.Drawing.Point(507, 270);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(75, 32);
            this.btn_Action.TabIndex = 10;
            this.btn_Action.Text = "Action";
            this.btn_Action.UseVisualStyleBackColor = true;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(592, 195);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(133, 59);
            this.txt_Remarks.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(480, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Remarks";
            // 
            // ddl_trans
            // 
            this.ddl_trans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_trans.FormattingEnabled = true;
            this.ddl_trans.Location = new System.Drawing.Point(592, 156);
            this.ddl_trans.Name = "ddl_trans";
            this.ddl_trans.Size = new System.Drawing.Size(133, 25);
            this.ddl_trans.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Transport Name";
            // 
            // ddl_pay_type
            // 
            this.ddl_pay_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_pay_type.FormattingEnabled = true;
            this.ddl_pay_type.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.ddl_pay_type.Location = new System.Drawing.Point(592, 117);
            this.ddl_pay_type.Name = "ddl_pay_type";
            this.ddl_pay_type.Size = new System.Drawing.Size(133, 25);
            this.ddl_pay_type.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Payment_Type";
            // 
            // txt_tot_amt
            // 
            this.txt_tot_amt.Location = new System.Drawing.Point(592, 60);
            this.txt_tot_amt.Name = "txt_tot_amt";
            this.txt_tot_amt.ReadOnly = true;
            this.txt_tot_amt.Size = new System.Drawing.Size(133, 24);
            this.txt_tot_amt.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Amout";
            // 
            // txt_nos
            // 
            this.txt_nos.Location = new System.Drawing.Point(592, 18);
            this.txt_nos.Name = "txt_nos";
            this.txt_nos.ReadOnly = true;
            this.txt_nos.Size = new System.Drawing.Size(133, 24);
            this.txt_nos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total QTY";
            // 
            // dtg_Pur_list
            // 
            this.dtg_Pur_list.AllowUserToAddRows = false;
            this.dtg_Pur_list.AllowUserToDeleteRows = false;
            this.dtg_Pur_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Pur_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product_Name,
            this.QTY,
            this.Rate,
            this.Sub_Total});
            this.dtg_Pur_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtg_Pur_list.Location = new System.Drawing.Point(0, 0);
            this.dtg_Pur_list.Name = "dtg_Pur_list";
            this.dtg_Pur_list.ReadOnly = true;
            this.dtg_Pur_list.RowHeadersVisible = false;
            this.dtg_Pur_list.RowTemplate.Height = 28;
            this.dtg_Pur_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Pur_list.Size = new System.Drawing.Size(468, 322);
            this.dtg_Pur_list.StandardTab = true;
            this.dtg_Pur_list.TabIndex = 0;
            this.dtg_Pur_list.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Pur_list_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PL_ID";
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
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.DataPropertyName = "Qty";
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 57;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rate.DataPropertyName = "PL_Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Sub_Total
            // 
            this.Sub_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sub_Total.DataPropertyName = "Column1";
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            // 
            // frm_Purchase_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 509);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Purchase_List";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Invoice";
            this.Load += new System.EventHandler(this.frm_Purchase_List_Load);
            this.TextChanged += new System.EventHandler(this.frm_Purchase_List_TextChanged);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Pur_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_om_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddl_sup_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_inv_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_QTY;
        private System.Windows.Forms.ComboBox ddl_Product_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Button btn_pro_ADD;
        private System.Windows.Forms.DataGridView dtg_Pur_list;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nos;
        private System.Windows.Forms.TextBox txt_tot_amt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddl_pay_type;
        private System.Windows.Forms.ComboBox ddl_trans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_PM;
        private System.Windows.Forms.Label lbl_PL;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.Label label1;
    }
}