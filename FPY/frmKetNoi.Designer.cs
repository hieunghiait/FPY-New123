namespace FPY
{
    partial class frmKetNoi
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
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.cboKieuXacThuc = new System.Windows.Forms.ComboBox();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.txtTenServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuThongTin.BackColor = System.Drawing.Color.Silver;
            this.btnLuuThongTin.Enabled = false;
            this.btnLuuThongTin.FlatAppearance.BorderSize = 0;
            this.btnLuuThongTin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLuuThongTin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLuuThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuThongTin.Location = new System.Drawing.Point(189, 10);
            this.btnLuuThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(116, 30);
            this.btnLuuThongTin.TabIndex = 2;
            this.btnLuuThongTin.Text = "Lưu thông tin";
            this.btnLuuThongTin.UseVisualStyleBackColor = false;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(105, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Chọn sai Database có thể khiến phần mềm hoạt động sai!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(346, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "(*)";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKiemTra.BackColor = System.Drawing.Color.Silver;
            this.btnKiemTra.FlatAppearance.BorderSize = 0;
            this.btnKiemTra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKiemTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKiemTra.Location = new System.Drawing.Point(273, 226);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 28);
            this.btnKiemTra.TabIndex = 4;
            this.btnKiemTra.Text = "Kết nối";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(176, 197);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(166, 25);
            this.txtMatKhau.TabIndex = 30;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(176, 160);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(166, 25);
            this.txtTenDangNhap.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Database:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnLuuThongTin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyBo.BackColor = System.Drawing.Color.Silver;
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHuyBo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHuyBo.Location = new System.Drawing.Point(325, 10);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(80, 30);
            this.btnHuyBo.TabIndex = 3;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // cboKieuXacThuc
            // 
            this.cboKieuXacThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKieuXacThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKieuXacThuc.FormattingEnabled = true;
            this.cboKieuXacThuc.Location = new System.Drawing.Point(108, 125);
            this.cboKieuXacThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboKieuXacThuc.Name = "cboKieuXacThuc";
            this.cboKieuXacThuc.Size = new System.Drawing.Size(234, 25);
            this.cboKieuXacThuc.TabIndex = 23;
            this.cboKieuXacThuc.SelectedIndexChanged += new System.EventHandler(this.cboKieuXacThuc_SelectedIndexChanged);
            // 
            // cboDatabase
            // 
            this.cboDatabase.Enabled = false;
            this.cboDatabase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(108, 273);
            this.cboDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(234, 25);
            this.cboDatabase.TabIndex = 21;
            // 
            // txtTenServer
            // 
            this.txtTenServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenServer.Location = new System.Drawing.Point(108, 90);
            this.txtTenServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenServer.Name = "txtTenServer";
            this.txtTenServer.Size = new System.Drawing.Size(234, 25);
            this.txtTenServer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhập Tên server và Kiểu xác thực rồi bấm Kết nối.\r\nSau đó chọn database rồi Lưu t" +
    "hông tin.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(81, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chỉnh sửa kết nối cơ sở dữ liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kiểu xác thực:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnKiemTra);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTenDangNhap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cboKieuXacThuc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboDatabase);
            this.panel2.Controls.Add(this.txtTenServer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 384);
            this.panel2.TabIndex = 5;
            // 
            // frmKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKetNoi";
            this.Text = "frmKetNoi";
            this.Load += new System.EventHandler(this.frmKetNoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.ComboBox cboKieuXacThuc;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.TextBox txtTenServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}