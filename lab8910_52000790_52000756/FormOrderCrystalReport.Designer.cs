namespace BaiTapLonCNPM
{
    partial class FormOrderCrystalReport
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
            this.crystalReportOrderViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportOrderViewer
            // 
            this.crystalReportOrderViewer.ActiveViewIndex = -1;
            this.crystalReportOrderViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportOrderViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportOrderViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportOrderViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportOrderViewer.Name = "crystalReportOrderViewer";
            this.crystalReportOrderViewer.Size = new System.Drawing.Size(800, 450);
            this.crystalReportOrderViewer.TabIndex = 0;
            this.crystalReportOrderViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormOrderCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportOrderViewer);
            this.Name = "FormOrderCrystalReport";
            this.Text = "OrderCrystalReport";
            this.Load += new System.EventHandler(this.FormOrderCrystalReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportOrderViewer;
    }
}