namespace INVT_MGMT_SYS
{
    partial class frm_Order_List
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
            this.lbl_OL = new System.Windows.Forms.Label();
            this.lbl_OM = new System.Windows.Forms.Label();
            this.btn_pro_ADD = new System.Windows.Forms.Button();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_QTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddl_Product_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddl_sup_name = new System.Windows.Forms.ComboBox();
            this.dtp_OL = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Action = new System.Windows.Forms.Button();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tot_amt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nos = new System.Windows.Forms.TextBox();
            this.dtg_OL = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OL)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Azure;
            this.pnl_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_top.Controls.Add(this.lbl_Title);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pnl_top.ForeColor = System.Drawing.Color.Black;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(738, 31);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(332, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(93, 20);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ORDER LIST";
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
            this.splitContainer1.Panel1.Controls.Add(this.lbl_OL);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_OM);
            this.splitContainer1.Panel1.Controls.Add(this.btn_pro_ADD);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Rate);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txt_QTY);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_Product_Name);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ddl_sup_name);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_OL);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Action);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Remarks);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txt_tot_amt);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txt_nos);
            this.splitContainer1.Panel2.Controls.Add(this.dtg_OL);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(738, 439);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.Location = new System.Drawing.Point(586, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "(mm-dd-yyyy)";
            // 
            // lbl_OL
            // 
            this.lbl_OL.AutoSize = true;
            this.lbl_OL.Location = new System.Drawing.Point(394, 24);
            this.lbl_OL.Name = "lbl_OL";
            this.lbl_OL.Size = new System.Drawing.Size(24, 17);
            this.lbl_OL.TabIndex = 11;
            this.lbl_OL.Text = "OL";
            this.lbl_OL.Visible = false;
            // 
            // lbl_OM
            // 
            this.lbl_OM.AutoSize = true;
            this.lbl_OM.Location = new System.Drawing.Point(310, 24);
            this.lbl_OM.Name = "lbl_OM";
            this.lbl_OM.Size = new System.Drawing.Size(30, 17);
            this.lbl_OM.TabIndex = 2;
            this.lbl_OM.Text = "OM";
            this.lbl_OM.Visible = false;
            // 
            // btn_pro_ADD
            // 
            this.btn_pro_ADD.Location = new System.Drawing.Point(634, 72);
            this.btn_pro_ADD.Name = "btn_pro_ADD";
            this.btn_pro_ADD.Size = new System.Drawing.Size(75, 28);
            this.btn_pro_ADD.TabIndex = 4;
            this.btn_pro_ADD.Text = "ADD";
            this.btn_pro_ADD.UseVisualStyleBackColor = true;
            this.btn_pro_ADD.Click += new System.EventHandler(this.btn_pro_ADD_Click);
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(472, 80);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(78, 24);
            this.txt_Rate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rate";
            // 
            // txt_QTY
            // 
            this.txt_QTY.Location = new System.Drawing.Point(260, 80);
            this.txt_QTY.Name = "txt_QTY";
            this.txt_QTY.Size = new System.Drawing.Size(55, 24);
            this.txt_QTY.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "QTY";
            // 
            // ddl_Product_Name
            // 
            this.ddl_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Product_Name.FormattingEnabled = true;
            this.ddl_Product_Name.Location = new System.Drawing.Point(27, 79);
            this.ddl_Product_Name.Name = "ddl_Product_Name";
            this.ddl_Product_Name.Size = new System.Drawing.Size(132, 25);
            this.ddl_Product_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // ddl_sup_name
            // 
            this.ddl_sup_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_sup_name.FormattingEnabled = true;
            this.ddl_sup_name.Location = new System.Drawing.Point(135, 21);
            this.ddl_sup_name.Name = "ddl_sup_name";
            this.ddl_sup_name.Size = new System.Drawing.Size(132, 25);
            this.ddl_sup_name.TabIndex = 0;
            // 
            // dtp_OL
            // 
            this.dtp_OL.CustomFormat = "MM-dd-yyyy";
            this.dtp_OL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_OL.Location = new System.Drawing.Point(588, 22);
            this.dtp_OL.Name = "dtp_OL";
            this.dtp_OL.Size = new System.Drawing.Size(121, 24);
            this.dtp_OL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier\'s Name";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(618, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Action
            // 
            this.btn_Action.Location = new System.Drawing.Point(506, 226);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(75, 28);
            this.btn_Action.TabIndex = 6;
            this.btn_Action.Text = "Action";
            this.btn_Action.UseVisualStyleBackColor = true;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(582, 132);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(127, 52);
            this.txt_Remarks.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Remarks";
            // 
            // txt_tot_amt
            // 
            this.txt_tot_amt.Location = new System.Drawing.Point(582, 82);
            this.txt_tot_amt.Name = "txt_tot_amt";
            this.txt_tot_amt.ReadOnly = true;
            this.txt_tot_amt.Size = new System.Drawing.Size(99, 24);
            this.txt_tot_amt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Amout";
            // 
            // txt_nos
            // 
            this.txt_nos.Location = new System.Drawing.Point(582, 30);
            this.txt_nos.Name = "txt_nos";
            this.txt_nos.ReadOnly = true;
            this.txt_nos.Size = new System.Drawing.Size(99, 24);
            this.txt_nos.TabIndex = 12;
            // 
            // dtg_OL
            // 
            this.dtg_OL.AllowUserToAddRows = false;
            this.dtg_OL.AllowUserToDeleteRows = false;
            this.dtg_OL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_OL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.Qty,
            this.Rate,
            this.S_total});
            this.dtg_OL.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtg_OL.Location = new System.Drawing.Point(0, 0);
            this.dtg_OL.Name = "dtg_OL";
            this.dtg_OL.ReadOnly = true;
            this.dtg_OL.RowHeadersVisible = false;
            this.dtg_OL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_OL.Size = new System.Drawing.Size(484, 316);
            this.dtg_OL.TabIndex = 11;
            this.dtg_OL.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_OL_CellEnter);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "OL_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Pro_Name";
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 53;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Rate.DataPropertyName = "OL_Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 59;
            // 
            // S_total
            // 
            this.S_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_total.DataPropertyName = "Column1";
            this.S_total.HeaderText = "Sub Total";
            this.S_total.Name = "S_total";
            this.S_total.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total QTY";
            // 
            // frm_Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 470);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Order_List";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order List";
            this.Load += new System.EventHandler(this.frm_Order_List_Load);
            this.TextChanged += new System.EventHandler(this.frm_Order_List_TextChanged);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_pro_ADD;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_QTY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddl_Product_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddl_sup_name;
        private System.Windows.Forms.DateTimePicker dtp_OL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tot_amt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nos;
        private System.Windows.Forms.DataGridView dtg_OL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_OL;
        private System.Windows.Forms.Label lbl_OM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_total;
        private System.Windows.Forms.Label label1;
    }
}