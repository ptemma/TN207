
namespace ChuDe5_Nhom11
{
    partial class frmNgheNghiep
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNgheNghiep = new System.Windows.Forms.DataGridView();
            this.txtMaNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtTenNgheNghiep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgheNghiep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(313, 433);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 41);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng form";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(173, 433);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 41);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(27, 433);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(118, 41);
            this.btnKhongLuu.TabIndex = 32;
            this.btnKhongLuu.Text = "Bỏ lưu";
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(313, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 41);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa nghề";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(173, 365);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(118, 41);
            this.btnChinhSua.TabIndex = 30;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 41);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNgheNghiep
            // 
            this.dgvNgheNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgheNghiep.Location = new System.Drawing.Point(471, 37);
            this.dgvNgheNghiep.Name = "dgvNgheNghiep";
            this.dgvNgheNghiep.RowHeadersWidth = 51;
            this.dgvNgheNghiep.RowTemplate.Height = 24;
            this.dgvNgheNghiep.Size = new System.Drawing.Size(412, 437);
            this.dgvNgheNghiep.TabIndex = 28;
            this.dgvNgheNghiep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgheNghiep_CellClick);
            // 
            // txtMaNgheNghiep
            // 
            this.txtMaNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNgheNghiep.Location = new System.Drawing.Point(29, 193);
            this.txtMaNgheNghiep.Name = "txtMaNgheNghiep";
            this.txtMaNgheNghiep.Size = new System.Drawing.Size(218, 35);
            this.txtMaNgheNghiep.TabIndex = 27;
            // 
            // txtTenNgheNghiep
            // 
            this.txtTenNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNgheNghiep.Location = new System.Drawing.Point(28, 292);
            this.txtTenNgheNghiep.Name = "txtTenNgheNghiep";
            this.txtTenNgheNghiep.Size = new System.Drawing.Size(286, 35);
            this.txtTenNgheNghiep.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên nghề nghiệp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã nghề nghiệp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 52);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nghề Nghiệp";
            // 
            // frmNgheNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 524);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNgheNghiep);
            this.Controls.Add(this.txtMaNgheNghiep);
            this.Controls.Add(this.txtTenNgheNghiep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNgheNghiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNgheNghiep";
            this.Load += new System.EventHandler(this.frmNgheNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgheNghiep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNgheNghiep;
        private System.Windows.Forms.TextBox txtMaNgheNghiep;
        private System.Windows.Forms.TextBox txtTenNgheNghiep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}