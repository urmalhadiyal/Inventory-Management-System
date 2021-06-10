namespace INVT_MGMT_SYS
{
    partial class frm_SalesMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_SM = new System.Windows.Forms.Label();
            this.dtp_search_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_SM = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SM)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(749, 37);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Transctions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_print);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_SM);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_search_date);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_CustName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Edit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_new);
            this.splitContainer1.Panel1.Controls.Add(this.txt_inv_no);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtg_SM);
            this.splitContainer1.Size = new System.Drawing.Size(749, 423);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(567, 18);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(88, 33);
            this.btn_print.TabIndex = 10;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_SM
            // 
            this.lbl_SM.AutoSize = true;
            this.lbl_SM.Location = new System.Drawing.Point(4, 52);
            this.lbl_SM.Name = "lbl_SM";
            this.lbl_SM.Size = new System.Drawing.Size(39, 25);
            this.lbl_SM.TabIndex = 9;
            this.lbl_SM.Text = "SM";
            this.lbl_SM.Visible = false;
            // 
            // dtp_search_date
            // 
            this.dtp_search_date.CustomFormat = "MM-dd-yyyy";
            this.dtp_search_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_search_date.Location = new System.Drawing.Point(516, 89);
            this.dtp_search_date.Name = "dtp_search_date";
            this.dtp_search_date.Size = new System.Drawing.Size(146, 33);
            this.dtp_search_date.TabIndex = 8;
            this.dtp_search_date.CloseUp += new System.EventHandler(this.dtp_search_date_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inv Date(mm-dd-yyyy)";
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(262, 89);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Size = new System.Drawing.Size(177, 33);
            this.txt_CustName.TabIndex = 6;
            this.txt_CustName.TextChanged += new System.EventHandler(this.txt_CustName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers Name";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(398, 18);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 33);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(229, 18);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(88, 33);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(60, 18);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(88, 33);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Location = new System.Drawing.Point(51, 89);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.Size = new System.Drawing.Size(115, 33);
            this.txt_inv_no.TabIndex = 1;
            this.txt_inv_no.TextChanged += new System.EventHandler(this.txt_inv_no_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice No.";
            // 
            // dtg_SM
            // 
            this.dtg_SM.AllowUserToAddRows = false;
            this.dtg_SM.AllowUserToDeleteRows = false;
            this.dtg_SM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Invoice_No,
            this.Cust_Name,
            this.Qty,
            this.Amount,
            this.Pay_type,
            this.Remarks});
            this.dtg_SM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_SM.Location = new System.Drawing.Point(0, 0);
            this.dtg_SM.Name = "dtg_SM";
            this.dtg_SM.ReadOnly = true;
            this.dtg_SM.RowHeadersVisible = false;
            this.dtg_SM.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dtg_SM.RowTemplate.Height = 28;
            this.dtg_SM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_SM.Size = new System.Drawing.Size(749, 296);
            this.dtg_SM.StandardTab = true;
            this.dtg_SM.TabIndex = 0;
            this.dtg_SM.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SM_CellEnter);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "Sales_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Sales_Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Invoice_No
            // 
            this.Invoice_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Invoice_No.DataPropertyName = "Sales_InvNo";
            this.Invoice_No.HeaderText = "Invoice No";
            this.Invoice_No.Name = "Invoice_No";
            this.Invoice_No.ReadOnly = true;
            // 
            // Cust_Name
            // 
            this.Cust_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cust_Name.DataPropertyName = "Cust_Name";
            this.Cust_Name.HeaderText = "Customer Name";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Sales_Qty";
            this.Qty.HeaderText = "NOS";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Sales_TotAmt";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Pay_type
            // 
            this.Pay_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pay_type.DataPropertyName = "Sales_PayType";
            this.Pay_type.HeaderText = "Pay Type";
            this.Pay_type.Name = "Pay_type";
            this.Pay_type.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // frm_SalesMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 460);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SalesMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Transction";
            this.Activated += new System.EventHandler(this.frm_SalesMaster_Activated);
            this.Load += new System.EventHandler(this.frm_SalesMaster_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CustName;
        private System.Windows.Forms.DateTimePicker dtp_search_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtg_SM;
        private System.Windows.Forms.Label lbl_SM;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}