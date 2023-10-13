namespace QL_VuiCungHugo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDulieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSTroChoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChonVongChoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDulieu,
            this.mnuCapNhat,
            this.mnuTienIch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDulieu
            // 
            this.mnuDulieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuDSTroChoi,
            this.mnuKetQua});
            this.mnuDulieu.Name = "mnuDulieu";
            this.mnuDulieu.Size = new System.Drawing.Size(69, 24);
            this.mnuDulieu.Text = "Dữ liệu";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(201, 24);
            this.mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuDSTroChoi
            // 
            this.mnuDSTroChoi.Name = "mnuDSTroChoi";
            this.mnuDSTroChoi.Size = new System.Drawing.Size(201, 24);
            this.mnuDSTroChoi.Text = "Danh sách trò chơi";
            // 
            // mnuKetQua
            // 
            this.mnuKetQua.Name = "mnuKetQua";
            this.mnuKetQua.Size = new System.Drawing.Size(201, 24);
            this.mnuKetQua.Text = "Kết quả trò chơi";
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChonVongChoi});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(80, 24);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuChonVongChoi
            // 
            this.mnuChonVongChoi.Name = "mnuChonVongChoi";
            this.mnuChonVongChoi.Size = new System.Drawing.Size(181, 24);
            this.mnuChonVongChoi.Text = "Chọn vòng chơi";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_VuiCungHugo.Properties.Resources.OIP__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 520);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vui cùng Hugo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDSTroChoi;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQua;
        private System.Windows.Forms.ToolStripMenuItem mnuChonVongChoi;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.ToolStripMenuItem mnuDulieu;
        public System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        public System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        public System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuThoatDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
    }
}

