
namespace He_thong_quan_ly_thu_vien
{
    partial class Form_XemDS
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
            this.btn_XemDS_Exit = new System.Windows.Forms.Button();
            this.btn_XemDS_Enter = new System.Windows.Forms.Button();
            this.cbo_TheLoai_Choose = new System.Windows.Forms.ComboBox();
            this.txt_MaTL_Watch = new System.Windows.Forms.TextBox();
            this.txt_MoTa_Watch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_XemDS_Enter = new System.Windows.Forms.DataGridView();
            this.txt_NgayLap_Watch = new System.Windows.Forms.TextBox();
            this.txt_Gia_Watch = new System.Windows.Forms.TextBox();
            this.txt_TenSach_Watch = new System.Windows.Forms.TextBox();
            this.txt__MaSach_Watch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDS_Enter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XemDS_Exit
            // 
            this.btn_XemDS_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDS_Exit.Location = new System.Drawing.Point(619, 649);
            this.btn_XemDS_Exit.Name = "btn_XemDS_Exit";
            this.btn_XemDS_Exit.Size = new System.Drawing.Size(543, 44);
            this.btn_XemDS_Exit.TabIndex = 43;
            this.btn_XemDS_Exit.Text = "Thoát";
            this.btn_XemDS_Exit.UseVisualStyleBackColor = true;
            this.btn_XemDS_Exit.Click += new System.EventHandler(this.btn_XemDS_Exit_Click);
            // 
            // btn_XemDS_Enter
            // 
            this.btn_XemDS_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDS_Enter.Location = new System.Drawing.Point(44, 649);
            this.btn_XemDS_Enter.Name = "btn_XemDS_Enter";
            this.btn_XemDS_Enter.Size = new System.Drawing.Size(533, 44);
            this.btn_XemDS_Enter.TabIndex = 41;
            this.btn_XemDS_Enter.Text = "Nhập";
            this.btn_XemDS_Enter.UseVisualStyleBackColor = true;
            this.btn_XemDS_Enter.Click += new System.EventHandler(this.btn_XemDS_Enter_Click);
            // 
            // cbo_TheLoai_Choose
            // 
            this.cbo_TheLoai_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TheLoai_Choose.FormattingEnabled = true;
            this.cbo_TheLoai_Choose.Location = new System.Drawing.Point(619, 161);
            this.cbo_TheLoai_Choose.Name = "cbo_TheLoai_Choose";
            this.cbo_TheLoai_Choose.Size = new System.Drawing.Size(543, 39);
            this.cbo_TheLoai_Choose.TabIndex = 51;
            // 
            // txt_MaTL_Watch
            // 
            this.txt_MaTL_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTL_Watch.Location = new System.Drawing.Point(799, 112);
            this.txt_MaTL_Watch.Name = "txt_MaTL_Watch";
            this.txt_MaTL_Watch.Size = new System.Drawing.Size(363, 38);
            this.txt_MaTL_Watch.TabIndex = 37;
            // 
            // txt_MoTa_Watch
            // 
            this.txt_MoTa_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa_Watch.Location = new System.Drawing.Point(214, 112);
            this.txt_MoTa_Watch.Name = "txt_MoTa_Watch";
            this.txt_MoTa_Watch.Size = new System.Drawing.Size(363, 38);
            this.txt_MoTa_Watch.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã Thể Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mô Tả";
            // 
            // dgv_XemDS_Enter
            // 
            this.dgv_XemDS_Enter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemDS_Enter.Location = new System.Drawing.Point(44, 215);
            this.dgv_XemDS_Enter.Name = "dgv_XemDS_Enter";
            this.dgv_XemDS_Enter.RowHeadersWidth = 51;
            this.dgv_XemDS_Enter.RowTemplate.Height = 24;
            this.dgv_XemDS_Enter.Size = new System.Drawing.Size(1119, 420);
            this.dgv_XemDS_Enter.TabIndex = 48;
            this.dgv_XemDS_Enter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_XemDS_Enter_CellClick);
            // 
            // txt_NgayLap_Watch
            // 
            this.txt_NgayLap_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayLap_Watch.Location = new System.Drawing.Point(799, 57);
            this.txt_NgayLap_Watch.Name = "txt_NgayLap_Watch";
            this.txt_NgayLap_Watch.Size = new System.Drawing.Size(363, 38);
            this.txt_NgayLap_Watch.TabIndex = 36;
            // 
            // txt_Gia_Watch
            // 
            this.txt_Gia_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia_Watch.Location = new System.Drawing.Point(799, 8);
            this.txt_Gia_Watch.Name = "txt_Gia_Watch";
            this.txt_Gia_Watch.Size = new System.Drawing.Size(363, 38);
            this.txt_Gia_Watch.TabIndex = 35;
            // 
            // txt_TenSach_Watch
            // 
            this.txt_TenSach_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSach_Watch.Location = new System.Drawing.Point(214, 57);
            this.txt_TenSach_Watch.Name = "txt_TenSach_Watch";
            this.txt_TenSach_Watch.Size = new System.Drawing.Size(363, 38);
            this.txt_TenSach_Watch.TabIndex = 33;
            // 
            // txt__MaSach_Watch
            // 
            this.txt__MaSach_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__MaSach_Watch.Location = new System.Drawing.Point(214, 8);
            this.txt__MaSach_Watch.Name = "txt__MaSach_Watch";
            this.txt__MaSach_Watch.Size = new System.Drawing.Size(363, 38);
            this.txt__MaSach_Watch.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ngày Lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(613, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 32);
            this.label6.TabIndex = 46;
            this.label6.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 32);
            this.label7.TabIndex = 54;
            this.label7.Text = "Chọn Thể Loại";
            // 
            // Form_XemDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_XemDS_Exit);
            this.Controls.Add(this.btn_XemDS_Enter);
            this.Controls.Add(this.cbo_TheLoai_Choose);
            this.Controls.Add(this.txt_MaTL_Watch);
            this.Controls.Add(this.txt_MoTa_Watch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_XemDS_Enter);
            this.Controls.Add(this.txt_NgayLap_Watch);
            this.Controls.Add(this.txt_Gia_Watch);
            this.Controls.Add(this.txt_TenSach_Watch);
            this.Controls.Add(this.txt__MaSach_Watch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_XemDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM DANH SÁCH";
            this.Load += new System.EventHandler(this.Form_XemDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDS_Enter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XemDS_Exit;
        private System.Windows.Forms.Button btn_XemDS_Enter;
        private System.Windows.Forms.ComboBox cbo_TheLoai_Choose;
        private System.Windows.Forms.TextBox txt_MaTL_Watch;
        private System.Windows.Forms.TextBox txt_MoTa_Watch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_XemDS_Enter;
        private System.Windows.Forms.TextBox txt_NgayLap_Watch;
        private System.Windows.Forms.TextBox txt_Gia_Watch;
        private System.Windows.Forms.TextBox txt_TenSach_Watch;
        private System.Windows.Forms.TextBox txt__MaSach_Watch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}