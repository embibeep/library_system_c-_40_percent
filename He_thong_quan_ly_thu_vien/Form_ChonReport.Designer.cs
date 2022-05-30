
namespace He_thong_quan_ly_thu_vien
{
    partial class Form_ChonReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaPM = new System.Windows.Forms.TextBox();
            this.btn_InReport = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Phiếu Mượn";
            // 
            // txt_MaPM
            // 
            this.txt_MaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPM.Location = new System.Drawing.Point(336, 41);
            this.txt_MaPM.Name = "txt_MaPM";
            this.txt_MaPM.Size = new System.Drawing.Size(363, 38);
            this.txt_MaPM.TabIndex = 46;
            // 
            // btn_InReport
            // 
            this.btn_InReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InReport.Location = new System.Drawing.Point(136, 133);
            this.btn_InReport.Name = "btn_InReport";
            this.btn_InReport.Size = new System.Drawing.Size(231, 44);
            this.btn_InReport.TabIndex = 47;
            this.btn_InReport.Text = "In Report";
            this.btn_InReport.UseVisualStyleBackColor = true;
            this.btn_InReport.Click += new System.EventHandler(this.btn_InReport_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(396, 133);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(231, 44);
            this.btn_Exit.TabIndex = 48;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form_ChonReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 258);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_InReport);
            this.Controls.Add(this.txt_MaPM);
            this.Controls.Add(this.label2);
            this.Name = "Form_ChonReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaPM;
        private System.Windows.Forms.Button btn_InReport;
        private System.Windows.Forms.Button btn_Exit;
    }
}