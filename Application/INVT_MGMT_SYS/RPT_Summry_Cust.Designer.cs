namespace INVT_MGMT_SYS
{
    partial class RPT_Summry_Cust
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
            this.CR_Sum_Cust_Recipe1 = new INVT_MGMT_SYS.CR_Sum_Cust_Recipe();
            this.CR_Sum_Sup_payments1 = new INVT_MGMT_SYS.CR_Sum_Sup_payments();
            this.CRV1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CR_Stock2 = new INVT_MGMT_SYS.CR_Stock();
            this.CR_Stock1 = new INVT_MGMT_SYS.CR_Stock();
            this.CR_Sum_Cust_Recipe2 = new INVT_MGMT_SYS.CR_Sum_Cust_Recipe();
            this.SuspendLayout();
            // 
            // CRV1
            // 
            this.CRV1.ActiveViewIndex = 0;
            this.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV1.Location = new System.Drawing.Point(0, 0);
            this.CRV1.Margin = new System.Windows.Forms.Padding(2);
            this.CRV1.Name = "CRV1";
            this.CRV1.ReportSource = this.CR_Sum_Cust_Recipe2;
            this.CRV1.Size = new System.Drawing.Size(866, 426);
            this.CRV1.TabIndex = 0;
            this.CRV1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RPT_Summry_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 426);
            this.Controls.Add(this.CRV1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RPT_Summry_Cust";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV1;
        private CR_Sum_Sup_payments CR_Sum_Sup_payments1;
        private CR_Sum_Cust_Recipe CR_Sum_Cust_Recipe1;
        private CR_Stock CR_Stock1;
        private CR_Stock CR_Stock2;
        private CR_Sum_Cust_Recipe CR_Sum_Cust_Recipe2;
    }
}