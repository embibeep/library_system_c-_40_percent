
namespace He_thong_quan_ly_thu_vien
{
    partial class Form_Report
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
            this.rptReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptReportViewer
            // 
            this.rptReportViewer.ActiveViewIndex = -1;
            this.rptReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReportViewer.Location = new System.Drawing.Point(0, 0);
            this.rptReportViewer.Name = "rptReportViewer";
            this.rptReportViewer.Size = new System.Drawing.Size(1226, 692);
            this.rptReportViewer.TabIndex = 0;
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 692);
            this.Controls.Add(this.rptReportViewer);
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReportViewer;
    }
}