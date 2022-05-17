
namespace He_thong_quan_ly_thu_vien
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Login_Account = new System.Windows.Forms.TextBox();
            this.txt_Login_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login_Access = new System.Windows.Forms.Button();
            this.btn_Login_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu: ";
            // 
            // txt_Login_Account
            // 
            this.txt_Login_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_Account.Location = new System.Drawing.Point(284, 141);
            this.txt_Login_Account.Name = "txt_Login_Account";
            this.txt_Login_Account.Size = new System.Drawing.Size(483, 38);
            this.txt_Login_Account.TabIndex = 2;
            // 
            // txt_Login_Password
            // 
            this.txt_Login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_Password.Location = new System.Drawing.Point(284, 202);
            this.txt_Login_Password.Name = "txt_Login_Password";
            this.txt_Login_Password.Size = new System.Drawing.Size(483, 38);
            this.txt_Login_Password.TabIndex = 4;
            // 
            // Btn_Login_Access
            // 
            this.Btn_Login_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_Access.Location = new System.Drawing.Point(178, 336);
            this.Btn_Login_Access.Name = "Btn_Login_Access";
            this.Btn_Login_Access.Size = new System.Drawing.Size(172, 46);
            this.Btn_Login_Access.TabIndex = 5;
            this.Btn_Login_Access.Text = "Đăng nhập";
            this.Btn_Login_Access.UseVisualStyleBackColor = true;
            this.Btn_Login_Access.Click += new System.EventHandler(this.Btn_Login_Access_Click);
            // 
            // btn_Login_Exit
            // 
            this.btn_Login_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_Exit.Location = new System.Drawing.Point(429, 336);
            this.btn_Login_Exit.Name = "btn_Login_Exit";
            this.btn_Login_Exit.Size = new System.Drawing.Size(172, 46);
            this.btn_Login_Exit.TabIndex = 6;
            this.btn_Login_Exit.Text = "Thoát";
            this.btn_Login_Exit.UseVisualStyleBackColor = true;
            this.btn_Login_Exit.Click += new System.EventHandler(this.btn_Login_Exit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Login_Exit);
            this.Controls.Add(this.Btn_Login_Access);
            this.Controls.Add(this.txt_Login_Password);
            this.Controls.Add(this.txt_Login_Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Login_Account;
        private System.Windows.Forms.TextBox txt_Login_Password;
        private System.Windows.Forms.Button Btn_Login_Access;
        private System.Windows.Forms.Button btn_Login_Exit;
    }
}

