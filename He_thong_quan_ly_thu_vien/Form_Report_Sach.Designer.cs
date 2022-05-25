
namespace He_thong_quan_ly_thu_vien
{
    partial class Form_Report_Sach
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
            this.crystalReportViewer_Sach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_Sach
            // 
            this.crystalReportViewer_Sach.ActiveViewIndex = -1;
            this.crystalReportViewer_Sach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Sach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Sach.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Sach.Name = "crystalReportViewer_Sach";
            this.crystalReportViewer_Sach.Size = new System.Drawing.Size(1061, 562);
            this.crystalReportViewer_Sach.TabIndex = 0;
            // 
            // Form_Report_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 562);
            this.Controls.Add(this.crystalReportViewer_Sach);
            this.Name = "Form_Report_Sach";
            this.Text = "Report Sách";
            this.Load += new System.EventHandler(this.Form_Report_Sach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Sach;
    }
}