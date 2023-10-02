namespace _25_BaiTapBuoi7
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
            this.mnuChonUD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaHoaTuDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLTienLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChonUD,
            this.mnuTienIch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuChonUD
            // 
            this.mnuChonUD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTienThuePhong,
            this.mnuMaHoaTuDong,
            this.mnuQLTienLuong});
            this.mnuChonUD.Name = "mnuChonUD";
            this.mnuChonUD.Size = new System.Drawing.Size(123, 24);
            this.mnuChonUD.Text = "Chọn ứng dụng";
            this.mnuChonUD.Click += new System.EventHandler(this.mnuChonUD_Click);
            // 
            // mnuTienThuePhong
            // 
            this.mnuTienThuePhong.Name = "mnuTienThuePhong";
            this.mnuTienThuePhong.Size = new System.Drawing.Size(215, 24);
            this.mnuTienThuePhong.Text = "Tính tiền thuê phòng";
            this.mnuTienThuePhong.Click += new System.EventHandler(this.mnuTienThuePhong_Click);
            // 
            // mnuMaHoaTuDong
            // 
            this.mnuMaHoaTuDong.Name = "mnuMaHoaTuDong";
            this.mnuMaHoaTuDong.Size = new System.Drawing.Size(215, 24);
            this.mnuMaHoaTuDong.Text = "Mã hóa tự động";
            this.mnuMaHoaTuDong.Click += new System.EventHandler(this.mnuMaHoaTuDong_Click);
            // 
            // mnuQLTienLuong
            // 
            this.mnuQLTienLuong.Name = "mnuQLTienLuong";
            this.mnuQLTienLuong.Size = new System.Drawing.Size(215, 24);
            this.mnuQLTienLuong.Text = "Quản lý tiền lương";
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGioiThieu,
            this.mnuThoat});
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(72, 24);
            this.mnuTienIch.Text = "Tiện ích";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(142, 24);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(142, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_25_BaiTapBuoi7.Properties.Resources.Blue_Coming_Soon_Banner_Landscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 765);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuChonUD;
        private System.Windows.Forms.ToolStripMenuItem mnuTienThuePhong;
        private System.Windows.Forms.ToolStripMenuItem mnuMaHoaTuDong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTienLuong;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}