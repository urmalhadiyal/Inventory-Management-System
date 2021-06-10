namespace INVT_MGMT_SYS
{
    partial class frm_Payment
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_new = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Action = new System.Windows.Forms.Button();
            this.txt_paid_amt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tot_amt = new System.Windows.Forms.Label();
            this.lbl_totAMT = new System.Windows.Forms.Label();
            this.ddl_Name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dtg_PayMaster = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYABLE_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAID_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.dtp_Search = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PayMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_top.Controls.Add(this.btn_delete);
            this.pnl_top.Controls.Add(this.btn_edit);
            this.pnl_top.Controls.Add(this.dtp_Date);
            this.pnl_top.Controls.Add(this.btn_new);
            this.pnl_top.Controls.Add(this.label5);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(722, 52);
            this.pnl_top.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.Location = new System.Drawing.Point(424, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(67, 25);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.Location = new System.Drawing.Point(314, 10);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(67, 25);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "MM-dd-yyy";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(589, 10);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(101, 34);
            this.dtp_Date.TabIndex = 2;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_new.Location = new System.Drawing.Point(204, 10);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(67, 25);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "PAYMENT";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 99);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Cancel);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Action);
            this.splitContainer1.Panel1.Controls.Add(this.txt_paid_amt);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_tot_amt);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_totAMT);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_Name);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtg_PayMaster);
            this.splitContainer1.Size = new System.Drawing.Size(722, 339);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.Location = new System.Drawing.Point(590, 48);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 25);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Action
            // 
            this.btn_Action.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Action.Location = new System.Drawing.Point(590, 10);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(67, 25);
            this.btn_Action.TabIndex = 8;
            this.btn_Action.Text = "Action";
            this.btn_Action.UseVisualStyleBackColor = true;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // txt_paid_amt
            // 
            this.txt_paid_amt.Location = new System.Drawing.Point(386, 41);
            this.txt_paid_amt.Name = "txt_paid_amt";
            this.txt_paid_amt.Size = new System.Drawing.Size(123, 33);
            this.txt_paid_amt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paid Amt. (Rs)";
            // 
            // lbl_tot_amt
            // 
            this.lbl_tot_amt.AutoSize = true;
            this.lbl_tot_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_tot_amt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_tot_amt.ForeColor = System.Drawing.Color.Red;
            this.lbl_tot_amt.Location = new System.Drawing.Point(240, 40);
            this.lbl_tot_amt.Name = "lbl_tot_amt";
            this.lbl_tot_amt.Size = new System.Drawing.Size(104, 30);
            this.lbl_tot_amt.TabIndex = 5;
            this.lbl_tot_amt.Text = "--NONE--";
            // 
            // lbl_totAMT
            // 
            this.lbl_totAMT.AutoSize = true;
            this.lbl_totAMT.Location = new System.Drawing.Point(237, 21);
            this.lbl_totAMT.Name = "lbl_totAMT";
            this.lbl_totAMT.Size = new System.Drawing.Size(131, 25);
            this.lbl_totAMT.TabIndex = 4;
            this.lbl_totAMT.Text = "Total Amt. (Rs)";
            // 
            // ddl_Name
            // 
            this.ddl_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Name.FormattingEnabled = true;
            this.ddl_Name.Location = new System.Drawing.Point(55, 37);
            this.ddl_Name.Name = "ddl_Name";
            this.ddl_Name.Size = new System.Drawing.Size(121, 33);
            this.ddl_Name.TabIndex = 3;
            this.ddl_Name.SelectedIndexChanged += new System.EventHandler(this.ddl_Name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 2);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(30, 25);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // dtg_PayMaster
            // 
            this.dtg_PayMaster.AllowUserToAddRows = false;
            this.dtg_PayMaster.AllowUserToDeleteRows = false;
            this.dtg_PayMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PayMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SUPPLIER,
            this.DATE,
            this.PAYABLE_AMT,
            this.PAID_AMT});
            this.dtg_PayMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_PayMaster.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_PayMaster.Location = new System.Drawing.Point(0, 0);
            this.dtg_PayMaster.Name = "dtg_PayMaster";
            this.dtg_PayMaster.ReadOnly = true;
            this.dtg_PayMaster.RowHeadersVisible = false;
            this.dtg_PayMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_PayMaster.Size = new System.Drawing.Size(720, 254);
            this.dtg_PayMaster.StandardTab = true;
            this.dtg_PayMaster.TabIndex = 0;
            this.dtg_PayMaster.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_PayMaster_CellEnter);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "Pay_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 55;
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SUPPLIER.DataPropertyName = "Sup_Name";
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.ReadOnly = true;
            this.SUPPLIER.Width = 117;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "Pay_PaidDate";
            dataGridViewCellStyle1.Format = "d";
            this.DATE.DefaultCellStyle = dataGridViewCellStyle1;
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // PAYABLE_AMT
            // 
            this.PAYABLE_AMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PAYABLE_AMT.DataPropertyName = "Pay_Amt";
            this.PAYABLE_AMT.HeaderText = "PAYABLE_AMT";
            this.PAYABLE_AMT.Name = "PAYABLE_AMT";
            this.PAYABLE_AMT.ReadOnly = true;
            this.PAYABLE_AMT.Visible = false;
            // 
            // PAID_AMT
            // 
            this.PAID_AMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PAID_AMT.DataPropertyName = "Pay_PaidAmt";
            this.PAID_AMT.HeaderText = "PAID_AMT";
            this.PAID_AMT.Name = "PAID_AMT";
            this.PAID_AMT.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Supplier";
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(219, 64);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(133, 33);
            this.txt_SearchName.TabIndex = 5;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtp_Search
            // 
            this.dtp_Search.CustomFormat = "MM-dd-yyyy";
            this.dtp_Search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Search.Location = new System.Drawing.Point(450, 64);
            this.dtp_Search.Name = "dtp_Search";
            this.dtp_Search.Size = new System.Drawing.Size(101, 33);
            this.dtp_Search.TabIndex = 5;
            this.dtp_Search.CloseUp += new System.EventHandler(this.dtp_Search_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Search);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frm_Payment_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PayMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtg_PayMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddl_Name;
        private System.Windows.Forms.Label lbl_tot_amt;
        private System.Windows.Forms.Label lbl_totAMT;
        private System.Windows.Forms.TextBox txt_paid_amt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.DateTimePicker dtp_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYABLE_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAID_AMT;
    }
}