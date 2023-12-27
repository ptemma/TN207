namespace QL_SinhVien
{
    partial class frmMain
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
            this.mnuQLSinhVien = new System.Windows.Forms.MenuStrip();
            this.mnuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSVTheoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChonHKNK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetQuaHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQLSinhVien
            // 
            this.mnuQLSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDuLieu,
            this.mnuCapNhat,
            this.mnuTienIch});
            this.mnuQLSinhVien.Location = new System.Drawing.Point(0, 0);
            this.mnuQLSinhVien.Name = "mnuQLSinhVien";
            this.mnuQLSinhVien.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuQLSinhVien.Size = new System.Drawing.Size(883, 28);
            this.mnuQLSinhVien.TabIndex = 0;
            this.mnuQLSinhVien.Text = "menuStrip1";
            // 
            // mnuDuLieu
            // 
            this.mnuDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLop,
            this.mnuSinhVien,
            this.mnuMonHoc,
            this.mnuSVTheoLop});
            this.mnuDuLieu.Name = "mnuDuLieu";
            this.mnuDuLieu.Size = new System.Drawing.Size(69, 24);
            this.mnuDuLieu.Text = "Dữ liệu";
            this.mnuDuLieu.Click += new System.EventHandler(this.mnuDuLieu_Click);
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(197, 24);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.Size = new System.Drawing.Size(197, 24);
            this.mnuSinhVien.Text = "Sinh viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(197, 24);
            this.mnuMonHoc.Text = "Môn học";
            // 
            // mnuSVTheoLop
            // 
            this.mnuSVTheoLop.Name = "mnuSVTheoLop";
            this.mnuSVTheoLop.Size = new System.Drawing.Size(197, 24);
            this.mnuSVTheoLop.Text = "Sinh viên theo lớp";
            this.mnuSVTheoLop.Click += new System.EventHandler(this.mnuSVTheoLop_Click);
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChonHKNK,
            this.mnuKetQuaHT});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(80, 24);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuChonHKNK
            // 
            this.mnuChonHKNK.Name = "mnuChonHKNK";
            this.mnuChonHKNK.Size = new System.Drawing.Size(183, 24);
            this.mnuChonHKNK.Text = "Chọn học ký";
            // 
            // mnuKetQuaHT
            // 
            this.mnuKetQuaHT.Name = "mnuKetQuaHT";
            this.mnuKetQuaHT.Size = new System.Drawing.Size(183, 24);
            this.mnuKetQuaHT.Text = "Kết quả học tập";
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuThoatDangNhap,
            this.mnuDoiMK,
            this.mnuGioiThieu,
            this.mnuThoat});
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(72, 24);
            this.mnuTienIch.Text = "Tiện ích";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(191, 24);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuThoatDangNhap
            // 
            this.mnuThoatDangNhap.Name = "mnuThoatDangNhap";
            this.mnuThoatDangNhap.Size = new System.Drawing.Size(191, 24);
            this.mnuThoatDangNhap.Text = "Thoát đăng nhập";
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(191, 24);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(191, 24);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(191, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_SinhVien.Properties.Resources._800w_suIEDLE1tio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 534);
            this.Controls.Add(this.mnuQLSinhVien);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuQLSinhVien;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuQLSinhVien.ResumeLayout(false);
            this.mnuQLSinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuSVTheoLop;
        private System.Windows.Forms.ToolStripMenuItem mnuChonHKNK;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQuaHT;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.MenuStrip mnuQLSinhVien;
        public System.Windows.Forms.ToolStripMenuItem mnuDuLieu;
        public System.Windows.Forms.ToolStripMenuItem mnuLop;
        public System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        public System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuThoatDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
    }
}

