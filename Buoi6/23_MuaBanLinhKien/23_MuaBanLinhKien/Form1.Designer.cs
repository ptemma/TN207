namespace _23_MuaBanLinhKien
{
    partial class frmMuaBanLinhKien
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
            this.grpQuanLy = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstDSLK = new System.Windows.Forms.ListBox();
            this.txtLK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMua = new System.Windows.Forms.GroupBox();
            this.btnChonMua = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.lstLKDC = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpQuanLy.SuspendLayout();
            this.grpMua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQuanLy
            // 
            this.grpQuanLy.Controls.Add(this.btnXoa);
            this.grpQuanLy.Controls.Add(this.btnThem);
            this.grpQuanLy.Controls.Add(this.lstDSLK);
            this.grpQuanLy.Controls.Add(this.txtLK);
            this.grpQuanLy.Controls.Add(this.label3);
            this.grpQuanLy.Controls.Add(this.label2);
            this.grpQuanLy.ForeColor = System.Drawing.Color.Blue;
            this.grpQuanLy.Location = new System.Drawing.Point(69, 95);
            this.grpQuanLy.Name = "grpQuanLy";
            this.grpQuanLy.Size = new System.Drawing.Size(370, 286);
            this.grpQuanLy.TabIndex = 0;
            this.grpQuanLy.TabStop = false;
            this.grpQuanLy.Text = "Quản lý";
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(39, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(39, 153);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 35);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstDSLK
            // 
            this.lstDSLK.FormattingEnabled = true;
            this.lstDSLK.ItemHeight = 22;
            this.lstDSLK.Items.AddRange(new object[] {
            "Chip",
            "Hard Disk",
            "Keyboard",
            "Monitor",
            "Mainboard",
            "Mouse",
            "RAM"});
            this.lstDSLK.Location = new System.Drawing.Point(191, 96);
            this.lstDSLK.Name = "lstDSLK";
            this.lstDSLK.Size = new System.Drawing.Size(155, 158);
            this.lstDSLK.TabIndex = 6;
            this.lstDSLK.SelectedIndexChanged += new System.EventHandler(this.lstDSLK_SelectedIndexChanged);
            // 
            // txtLK
            // 
            this.txtLK.Location = new System.Drawing.Point(43, 96);
            this.txtLK.Name = "txtLK";
            this.txtLK.Size = new System.Drawing.Size(100, 30);
            this.txtLK.TabIndex = 5;
            this.txtLK.TextChanged += new System.EventHandler(this.txtLK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(187, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách linh kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linh kiện mới";
            // 
            // grpMua
            // 
            this.grpMua.Controls.Add(this.btnChonMua);
            this.grpMua.Controls.Add(this.btnBoChon);
            this.grpMua.Controls.Add(this.lstLKDC);
            this.grpMua.Controls.Add(this.label4);
            this.grpMua.ForeColor = System.Drawing.Color.Blue;
            this.grpMua.Location = new System.Drawing.Point(456, 95);
            this.grpMua.Name = "grpMua";
            this.grpMua.Size = new System.Drawing.Size(370, 286);
            this.grpMua.TabIndex = 1;
            this.grpMua.TabStop = false;
            this.grpMua.Text = "Mua linh kiện";
            // 
            // btnChonMua
            // 
            this.btnChonMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChonMua.Location = new System.Drawing.Point(22, 153);
            this.btnChonMua.Name = "btnChonMua";
            this.btnChonMua.Size = new System.Drawing.Size(110, 35);
            this.btnChonMua.TabIndex = 9;
            this.btnChonMua.Text = "Chọn mua";
            this.btnChonMua.UseVisualStyleBackColor = true;
            this.btnChonMua.Click += new System.EventHandler(this.btnChonMua_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBoChon.Location = new System.Drawing.Point(22, 193);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(110, 35);
            this.btnBoChon.TabIndex = 10;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // lstLKDC
            // 
            this.lstLKDC.FormattingEnabled = true;
            this.lstLKDC.ItemHeight = 22;
            this.lstLKDC.Location = new System.Drawing.Point(171, 96);
            this.lstLKDC.Name = "lstLKDC";
            this.lstLKDC.Size = new System.Drawing.Size(155, 158);
            this.lstLKDC.TabIndex = 7;
            this.lstLKDC.SelectedIndexChanged += new System.EventHandler(this.lstLKDC_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(177, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Linh kiện đã chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(298, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cửa hàng linh kiện máy tính";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(384, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 41);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMuaBanLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(883, 466);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMua);
            this.Controls.Add(this.grpQuanLy);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMuaBanLinhKien";
            this.Text = "Mua bán linh kiện";
            this.Load += new System.EventHandler(this.frmMuaBanLinhKien_Load);
            this.grpQuanLy.ResumeLayout(false);
            this.grpQuanLy.PerformLayout();
            this.grpMua.ResumeLayout(false);
            this.grpMua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQuanLy;
        private System.Windows.Forms.GroupBox grpMua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstDSLK;
        private System.Windows.Forms.TextBox txtLK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChonMua;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.ListBox lstLKDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}

