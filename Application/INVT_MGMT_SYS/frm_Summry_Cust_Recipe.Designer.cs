namespace INVT_MGMT_SYS
{
    partial class frm_Summry_Cust_Recipe
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
            this.ddl_cust_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_SCR = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sales_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Recipe_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SCR)).BeginInit();
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
            this.pnl_top.Size = new System.Drawing.Size(590, 39);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summry - Customer Recipe";
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
            this.splitContainer1.Panel1.Controls.Add(this.ddl_cust_name);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtg_SCR);
            this.splitContainer1.Size = new System.Drawing.Size(590, 396);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(426, 11);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 29);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // ddl_cust_name
            // 
            this.ddl_cust_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_cust_name.FormattingEnabled = true;
            this.ddl_cust_name.Location = new System.Drawing.Point(253, 10);
            this.ddl_cust_name.Name = "ddl_cust_name";
            this.ddl_cust_name.Size = new System.Drawing.Size(121, 33);
            this.ddl_cust_name.TabIndex = 1;
            this.ddl_cust_name.SelectedIndexChanged += new System.EventHandler(this.ddl_cust_name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // dtg_SCR
            // 
            this.dtg_SCR.AllowUserToAddRows = false;
            this.dtg_SCR.AllowUserToDeleteRows = false;
            this.dtg_SCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SCR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cust_Name,
            this.Total_Sales_Amt,
            this.Total_Recipe_Amt,
            this.C_B});
            this.dtg_SCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_SCR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_SCR.Location = new System.Drawing.Point(0, 0);
            this.dtg_SCR.MultiSelect = false;
            this.dtg_SCR.Name = "dtg_SCR";
            this.dtg_SCR.ReadOnly = true;
            this.dtg_SCR.RowHeadersVisible = false;
            this.dtg_SCR.RowTemplate.Height = 28;
            this.dtg_SCR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_SCR.Size = new System.Drawing.Size(590, 344);
            this.dtg_SCR.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Cust_Name
            // 
            this.Cust_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cust_Name.DataPropertyName = "Cust_Name";
            this.Cust_Name.HeaderText = "Customer Name";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.ReadOnly = true;
            // 
            // Total_Sales_Amt
            // 
            this.Total_Sales_Amt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Sales_Amt.HeaderText = "Total Sales Amt.";
            this.Total_Sales_Amt.Name = "Total_Sales_Amt";
            this.Total_Sales_Amt.ReadOnly = true;
            // 
            // Total_Recipe_Amt
            // 
            this.Total_Recipe_Amt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Recipe_Amt.HeaderText = "Total Recipe Amt.";
            this.Total_Recipe_Amt.Name = "Total_Recipe_Amt";
            this.Total_Recipe_Amt.ReadOnly = true;
            // 
            // C_B
            // 
            this.C_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_B.HeaderText = "Closing Balance";
            this.C_B.Name = "C_B";
            this.C_B.ReadOnly = true;
            // 
            // frm_Summry_Cust_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 435);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Summry_Cust_Recipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summry - Customer Recipe";
            this.Load += new System.EventHandler(this.frm_Summry_Cust_Recipe_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SCR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ComboBox ddl_cust_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_SCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sales_Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Recipe_Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_B;
    }
}