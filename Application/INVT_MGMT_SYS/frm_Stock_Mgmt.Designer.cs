namespace INVT_MGMT_SYS
{
    partial class frm_Stock_Mgmt
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_Stock = new System.Windows.Forms.DataGridView();
            this.Pro_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pur_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Top.Controls.Add(this.btn_Print);
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(759, 39);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(633, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 29);
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Text = "PRINT";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK MANAGMENT";
            // 
            // dtg_Stock
            // 
            this.dtg_Stock.AllowUserToAddRows = false;
            this.dtg_Stock.AllowUserToDeleteRows = false;
            this.dtg_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pro_ID,
            this.Pro_Name,
            this.Pur_QTY,
            this.Sales_Qty,
            this.Stock_Qty});
            this.dtg_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Stock.Location = new System.Drawing.Point(0, 39);
            this.dtg_Stock.Name = "dtg_Stock";
            this.dtg_Stock.ReadOnly = true;
            this.dtg_Stock.RowHeadersVisible = false;
            this.dtg_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Stock.Size = new System.Drawing.Size(759, 396);
            this.dtg_Stock.TabIndex = 9;
            // 
            // Pro_ID
            // 
            this.Pro_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pro_ID.HeaderText = "Product ID";
            this.Pro_ID.Name = "Pro_ID";
            this.Pro_ID.ReadOnly = true;
            // 
            // Pro_Name
            // 
            this.Pro_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pro_Name.HeaderText = "Product Name";
            this.Pro_Name.Name = "Pro_Name";
            this.Pro_Name.ReadOnly = true;
            // 
            // Pur_QTY
            // 
            this.Pur_QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pur_QTY.HeaderText = "Purchase Qty.";
            this.Pur_QTY.Name = "Pur_QTY";
            this.Pur_QTY.ReadOnly = true;
            // 
            // Sales_Qty
            // 
            this.Sales_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales_Qty.HeaderText = "Sales Qty";
            this.Sales_Qty.Name = "Sales_Qty";
            this.Sales_Qty.ReadOnly = true;
            // 
            // Stock_Qty
            // 
            this.Stock_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock_Qty.HeaderText = "Stock Qty.";
            this.Stock_Qty.Name = "Stock_Qty";
            this.Stock_Qty.ReadOnly = true;
            // 
            // frm_Stock_Mgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 435);
            this.Controls.Add(this.dtg_Stock);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Stock_Mgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Managment";
            this.Load += new System.EventHandler(this.frm_Stock_Mgmt_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DataGridView dtg_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pur_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Qty;
    }
}