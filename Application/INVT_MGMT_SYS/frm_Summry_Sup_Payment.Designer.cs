namespace INVT_MGMT_SYS
{
    partial class frm_Summry_Sup_Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_print = new System.Windows.Forms.Button();
            this.ddl_Sup_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_SPS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pur_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot_Paid_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SPS)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.DimGray;
            this.pnl_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(799, 39);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summry - Supplier Payment";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_print);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_Sup_name);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtg_SPS);
            this.splitContainer1.Size = new System.Drawing.Size(799, 442);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(563, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 29);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // ddl_Sup_name
            // 
            this.ddl_Sup_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Sup_name.FormattingEnabled = true;
            this.ddl_Sup_name.Location = new System.Drawing.Point(275, 15);
            this.ddl_Sup_name.Name = "ddl_Sup_name";
            this.ddl_Sup_name.Size = new System.Drawing.Size(121, 33);
            this.ddl_Sup_name.TabIndex = 1;
            this.ddl_Sup_name.SelectedIndexChanged += new System.EventHandler(this.ddl_Sup_name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Supplier Name";
            // 
            // dtg_SPS
            // 
            this.dtg_SPS.AllowUserToAddRows = false;
            this.dtg_SPS.AllowUserToDeleteRows = false;
            this.dtg_SPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sup_Name,
            this.Total_Pur_Amt,
            this.Tot_Paid_Amt,
            this.C_B});
            this.dtg_SPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_SPS.Location = new System.Drawing.Point(0, 0);
            this.dtg_SPS.MultiSelect = false;
            this.dtg_SPS.Name = "dtg_SPS";
            this.dtg_SPS.ReadOnly = true;
            this.dtg_SPS.RowHeadersVisible = false;
            this.dtg_SPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_SPS.Size = new System.Drawing.Size(799, 385);
            this.dtg_SPS.StandardTab = true;
            this.dtg_SPS.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Sup_Name
            // 
            this.Sup_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sup_Name.DataPropertyName = "Sup_Name";
            this.Sup_Name.HeaderText = "Supplier Name";
            this.Sup_Name.Name = "Sup_Name";
            this.Sup_Name.ReadOnly = true;
            // 
            // Total_Pur_Amt
            // 
            this.Total_Pur_Amt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Pur_Amt.DataPropertyName = "Column1";
            this.Total_Pur_Amt.HeaderText = "Total Pur. Amt.";
            this.Total_Pur_Amt.Name = "Total_Pur_Amt";
            this.Total_Pur_Amt.ReadOnly = true;
            // 
            // Tot_Paid_Amt
            // 
            this.Tot_Paid_Amt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tot_Paid_Amt.DataPropertyName = "Column2";
            this.Tot_Paid_Amt.HeaderText = "Total_Paid_Amt";
            this.Tot_Paid_Amt.Name = "Tot_Paid_Amt";
            this.Tot_Paid_Amt.ReadOnly = true;
            // 
            // C_B
            // 
            this.C_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_B.DataPropertyName = "Column3";
            this.C_B.HeaderText = "Closing Balance";
            this.C_B.Name = "C_B";
            this.C_B.ReadOnly = true;
            // 
            // frm_Summry_Sup_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Summry_Sup_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summry - Supplier Payment";
            this.Load += new System.EventHandler(this.frm_Summry_Sup_Payment_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ComboBox ddl_Sup_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_SPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pur_Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tot_Paid_Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_B;
    }
}