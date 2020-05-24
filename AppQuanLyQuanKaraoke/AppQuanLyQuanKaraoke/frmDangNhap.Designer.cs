namespace AppQuanLyQuanKaraoke
{
    partial class frmDangNhap
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
            this.lblTitleDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblTitleTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.lblTitleMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.ckbGhiNhoDangNhap = new DevExpress.XtraEditors.CheckEdit();
            this.btnThoatDangNhap = new NewControl.ButtonStyleHot();
            this.btnDangNhap = new NewControl.ButtonStyleHot();
            this.txtMatKhauDangNhap = new NewControl.TextBoxPassword();
            this.txtTaiKhoanDangNhap = new NewControl.TextBoxNumChar();
            ((System.ComponentModel.ISupportInitialize)(this.ckbGhiNhoDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleDangNhap
            // 
            this.lblTitleDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleDangNhap.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTitleDangNhap.Appearance.Options.UseFont = true;
            this.lblTitleDangNhap.Appearance.Options.UseForeColor = true;
            this.lblTitleDangNhap.Location = new System.Drawing.Point(187, 26);
            this.lblTitleDangNhap.Name = "lblTitleDangNhap";
            this.lblTitleDangNhap.Size = new System.Drawing.Size(381, 26);
            this.lblTitleDangNhap.TabIndex = 0;
            this.lblTitleDangNhap.Text = "ĐĂNG NHẬP VÀO KARAOKE H-N";
            // 
            // lblTitleTaiKhoan
            // 
            this.lblTitleTaiKhoan.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleTaiKhoan.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitleTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTitleTaiKhoan.Appearance.Options.UseForeColor = true;
            this.lblTitleTaiKhoan.Location = new System.Drawing.Point(44, 93);
            this.lblTitleTaiKhoan.Name = "lblTitleTaiKhoan";
            this.lblTitleTaiKhoan.Size = new System.Drawing.Size(123, 25);
            this.lblTitleTaiKhoan.TabIndex = 1;
            this.lblTitleTaiKhoan.Text = "Tài khoản : ";
            // 
            // lblTitleMatKhau
            // 
            this.lblTitleMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleMatKhau.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitleMatKhau.Appearance.Options.UseFont = true;
            this.lblTitleMatKhau.Appearance.Options.UseForeColor = true;
            this.lblTitleMatKhau.Location = new System.Drawing.Point(44, 152);
            this.lblTitleMatKhau.Name = "lblTitleMatKhau";
            this.lblTitleMatKhau.Size = new System.Drawing.Size(119, 25);
            this.lblTitleMatKhau.TabIndex = 2;
            this.lblTitleMatKhau.Text = "Mật khẩu : ";
            // 
            // ckbGhiNhoDangNhap
            // 
            this.ckbGhiNhoDangNhap.Location = new System.Drawing.Point(205, 225);
            this.ckbGhiNhoDangNhap.Name = "ckbGhiNhoDangNhap";
            this.ckbGhiNhoDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbGhiNhoDangNhap.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ckbGhiNhoDangNhap.Properties.Appearance.Options.UseFont = true;
            this.ckbGhiNhoDangNhap.Properties.Appearance.Options.UseForeColor = true;
            this.ckbGhiNhoDangNhap.Properties.Caption = "Ghi nhớ thông tin đăng nhập";
            this.ckbGhiNhoDangNhap.Size = new System.Drawing.Size(254, 23);
            this.ckbGhiNhoDangNhap.TabIndex = 7;
            // 
            // btnThoatDangNhap
            // 
            this.btnThoatDangNhap.BackColor = System.Drawing.Color.Azure;
            this.btnThoatDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatDangNhap.ForeColor = System.Drawing.Color.Red;
            this.btnThoatDangNhap.Location = new System.Drawing.Point(501, 152);
            this.btnThoatDangNhap.Name = "btnThoatDangNhap";
            this.btnThoatDangNhap.Size = new System.Drawing.Size(131, 31);
            this.btnThoatDangNhap.TabIndex = 6;
            this.btnThoatDangNhap.Text = "Thoát";
            this.btnThoatDangNhap.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Azure;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(501, 89);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(131, 31);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhauDangNhap
            // 
            this.txtMatKhauDangNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauDangNhap.Location = new System.Drawing.Point(205, 156);
            this.txtMatKhauDangNhap.Name = "txtMatKhauDangNhap";
            this.txtMatKhauDangNhap.Size = new System.Drawing.Size(254, 23);
            this.txtMatKhauDangNhap.TabIndex = 4;
            this.txtMatKhauDangNhap.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoanDangNhap
            // 
            this.txtTaiKhoanDangNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoanDangNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTaiKhoanDangNhap.Location = new System.Drawing.Point(205, 93);
            this.txtTaiKhoanDangNhap.Name = "txtTaiKhoanDangNhap";
            this.txtTaiKhoanDangNhap.Size = new System.Drawing.Size(254, 23);
            this.txtTaiKhoanDangNhap.TabIndex = 3;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 295);
            this.Controls.Add(this.ckbGhiNhoDangNhap);
            this.Controls.Add(this.btnThoatDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhauDangNhap);
            this.Controls.Add(this.txtTaiKhoanDangNhap);
            this.Controls.Add(this.lblTitleMatKhau);
            this.Controls.Add(this.lblTitleTaiKhoan);
            this.Controls.Add(this.lblTitleDangNhap);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ckbGhiNhoDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitleDangNhap;
        private DevExpress.XtraEditors.LabelControl lblTitleTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lblTitleMatKhau;
        private NewControl.TextBoxNumChar txtTaiKhoanDangNhap;
        private NewControl.TextBoxPassword txtMatKhauDangNhap;
        private NewControl.ButtonStyleHot btnDangNhap;
        private NewControl.ButtonStyleHot btnThoatDangNhap;
        private DevExpress.XtraEditors.CheckEdit ckbGhiNhoDangNhap;

    }
}

