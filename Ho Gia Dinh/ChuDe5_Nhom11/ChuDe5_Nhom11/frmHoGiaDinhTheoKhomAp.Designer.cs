﻿
namespace ChuDe5_Nhom11
{
    partial class frmHoGiaDinhTheoKhomAp
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaAp = new System.Windows.Forms.ComboBox();
            this.cbbTenAp = new System.Windows.Forms.ComboBox();
            this.txtMaHo = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dgvHoGiaDinh = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dtkNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoGiaDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hộ Gia Đình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Ấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Hộ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ nhà";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày lập hộ";
            // 
            // cbbMaAp
            // 
            this.cbbMaAp.FormattingEnabled = true;
            this.cbbMaAp.Location = new System.Drawing.Point(33, 348);
            this.cbbMaAp.Name = "cbbMaAp";
            this.cbbMaAp.Size = new System.Drawing.Size(330, 24);
            this.cbbMaAp.TabIndex = 6;
            this.cbbMaAp.SelectedIndexChanged += new System.EventHandler(this.cbbMaAp_SelectedIndexChanged);
            // 
            // cbbTenAp
            // 
            this.cbbTenAp.FormattingEnabled = true;
            this.cbbTenAp.Location = new System.Drawing.Point(33, 417);
            this.cbbTenAp.Name = "cbbTenAp";
            this.cbbTenAp.Size = new System.Drawing.Size(330, 24);
            this.cbbTenAp.TabIndex = 7;
            // 
            // txtMaHo
            // 
            this.txtMaHo.Location = new System.Drawing.Point(33, 146);
            this.txtMaHo.Name = "txtMaHo";
            this.txtMaHo.Size = new System.Drawing.Size(330, 22);
            this.txtMaHo.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(33, 212);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(330, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // dgvHoGiaDinh
            // 
            this.dgvHoGiaDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoGiaDinh.Location = new System.Drawing.Point(406, 59);
            this.dgvHoGiaDinh.Name = "dgvHoGiaDinh";
            this.dgvHoGiaDinh.RowHeadersWidth = 51;
            this.dgvHoGiaDinh.Size = new System.Drawing.Size(559, 522);
            this.dgvHoGiaDinh.TabIndex = 11;
            this.dgvHoGiaDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoGiaDinh_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(33, 472);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 46);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(167, 472);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(87, 46);
            this.btnChinhSua.TabIndex = 13;
            this.btnChinhSua.Text = "Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(278, 472);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 46);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(33, 535);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 46);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.Location = new System.Drawing.Point(155, 535);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(108, 46);
            this.btnKhongLuu.TabIndex = 16;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(278, 535);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 46);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dtkNgayLap
            // 
            this.dtkNgayLap.Location = new System.Drawing.Point(33, 278);
            this.dtkNgayLap.Name = "dtkNgayLap";
            this.dtkNgayLap.Size = new System.Drawing.Size(330, 22);
            this.dtkNgayLap.TabIndex = 18;
            // 
            // frmHoGiaDinhTheoKhomAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 602);
            this.Controls.Add(this.dtkNgayLap);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHoGiaDinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaHo);
            this.Controls.Add(this.cbbTenAp);
            this.Controls.Add(this.cbbMaAp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoGiaDinhTheoKhomAp";
            this.Text = "Thông tin hộ gia đình theo ấp";
            this.Load += new System.EventHandler(this.frmHoGiaDinhTheoKhomAp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoGiaDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaAp;
        private System.Windows.Forms.ComboBox cbbTenAp;
        private System.Windows.Forms.TextBox txtMaHo;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvHoGiaDinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DateTimePicker dtkNgayLap;
    }
}