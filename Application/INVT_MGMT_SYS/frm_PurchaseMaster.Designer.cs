namespace INVT_MGMT_SYS
{
    partial class frm_PurchaseMaster
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
            this.txt_SupName = new System.Windows.Forms.TextBox();
            this.lbl_PM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_search_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dtg_PM = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trans_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PM)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.SlateGray;
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
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(284, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Transction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_SupName);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_PM);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_search_date);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_inv_no);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_order_id);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_edit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_new);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtg_PM);
            this.splitContainer1.Size = new System.Drawing.Size(749, 423);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 1;
            // 
            // txt_SupName
            // 
            this.txt_SupName.Location = new System.Drawing.Point(365, 83);
            this.txt_SupName.Name = "txt_SupName";
            this.txt_SupName.Size = new System.Drawing.Size(168, 33);
            this.txt_SupName.TabIndex = 13;
            this.txt_SupName.TextChanged += new System.EventHandler(this.txt_SupName_TextChanged);
            // 
            // lbl_PM
            // 
            this.lbl_PM.AutoSize = true;
            this.lbl_PM.Location = new System.Drawing.Point(38, 20);
            this.lbl_PM.Name = "lbl_PM";
            this.lbl_PM.Size = new System.Drawing.Size(40, 25);
            this.lbl_PM.TabIndex = 12;
            this.lbl_PM.Text = "PM";
            this.lbl_PM.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.Location = new System.Drawing.Point(599, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "(mm-dd-yyyy)";
            // 
            // dtp_search_date
            // 
            this.dtp_search_date.CustomFormat = "MM-dd-yyyy";
            this.dtp_search_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_search_date.Location = new System.Drawing.Point(587, 83);
            this.dtp_search_date.Name = "dtp_search_date";
            this.dtp_search_date.Size = new System.Drawing.Size(142, 33);
            this.dtp_search_date.TabIndex = 10;
            this.dtp_search_date.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Invoice Dt.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supplier_Name";
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Location = new System.Drawing.Point(179, 83);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.Size = new System.Drawing.Size(136, 33);
            this.txt_inv_no.TabIndex = 6;
            this.txt_inv_no.TextChanged += new System.EventHandler(this.txt_inv_no_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invoice No.";
            // 
            // txt_order_id
            // 
            this.txt_order_id.Location = new System.Drawing.Point(30, 83);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.Size = new System.Drawing.Size(100, 33);
            this.txt_order_id.TabIndex = 4;
            this.txt_order_id.TextChanged += new System.EventHandler(this.txt_order_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order ID";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(553, 20);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(333, 20);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 33);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(107, 20);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 33);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dtg_PM
            // 
            this.dtg_PM.AllowUserToAddRows = false;
            this.dtg_PM.AllowUserToDeleteRows = false;
            this.dtg_PM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Order_ID,
            this.Date,
            this.Invoice_No,
            this.Supplier_Name,
            this.NOS,
            this.Amout,
            this.Pay_type,
            this.Trans_Name,
            this.Remarks});
            this.dtg_PM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_PM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_PM.Location = new System.Drawing.Point(0, 0);
            this.dtg_PM.Name = "dtg_PM";
            this.dtg_PM.ReadOnly = true;
            this.dtg_PM.RowHeadersVisible = false;
            this.dtg_PM.RowTemplate.Height = 28;
            this.dtg_PM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_PM.Size = new System.Drawing.Size(745, 279);
            this.dtg_PM.StandardTab = true;
            this.dtg_PM.TabIndex = 0;
            this.dtg_PM.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_PM_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Pur_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Order_ID
            // 
            this.Order_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order_ID.DataPropertyName = "OM_ID";
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Pur_Date";
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
            this.Invoice_No.DataPropertyName = "Pur_InvNo";
            this.Invoice_No.HeaderText = "Invoice No";
            this.Invoice_No.Name = "Invoice_No";
            this.Invoice_No.ReadOnly = true;
            // 
            // Supplier_Name
            // 
            this.Supplier_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier_Name.DataPropertyName = "Sup_Name";
            this.Supplier_Name.HeaderText = "Supplier Name";
            this.Supplier_Name.Name = "Supplier_Name";
            this.Supplier_Name.ReadOnly = true;
            // 
            // NOS
            // 
            this.NOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOS.DataPropertyName = "Pur_Qty";
            this.NOS.HeaderText = "NOS";
            this.NOS.Name = "NOS";
            this.NOS.ReadOnly = true;
            // 
            // Amout
            // 
            this.Amout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amout.DataPropertyName = "Pur_TotAmt";
            this.Amout.HeaderText = "Amout";
            this.Amout.Name = "Amout";
            this.Amout.ReadOnly = true;
            // 
            // Pay_type
            // 
            this.Pay_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pay_type.DataPropertyName = "Pur_PayType";
            this.Pay_type.HeaderText = "Payment Type";
            this.Pay_type.Name = "Pay_type";
            this.Pay_type.ReadOnly = true;
            // 
            // Trans_Name
            // 
            this.Trans_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trans_Name.DataPropertyName = "Tm_Name";
            this.Trans_Name.HeaderText = "Transport";
            this.Trans_Name.Name = "Trans_Name";
            this.Trans_Name.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.DataPropertyName = "Pur_Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // frm_PurchaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 460);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_PurchaseMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Transction";
            this.Activated += new System.EventHandler(this.frm_PurchaseMaster_Activated);
            this.Load += new System.EventHandler(this.frm_PurchaseMaster_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_search_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dtg_PM;
        private System.Windows.Forms.Label lbl_PM;
        private System.Windows.Forms.TextBox txt_SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trans_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}