namespace OnTapTN207
{
    partial class frmCanBo
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
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.cboMaDV = new System.Windows.Forms.ComboBox();
            this.cboQuyenSD = new System.Windows.Forms.ComboBox();
            this.dgvCanBo = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanBo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(369, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách cán bộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(89, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã cán bộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(89, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(89, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(89, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quyền sử dụng";
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(280, 114);
            this.txtMaCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(246, 27);
            this.txtMaCB.TabIndex = 5;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(280, 182);
            this.txtHovaten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(246, 27);
            this.txtHovaten.TabIndex = 6;
            // 
            // cboMaDV
            // 
            this.cboMaDV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaDV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaDV.FormattingEnabled = true;
            this.cboMaDV.Location = new System.Drawing.Point(280, 258);
            this.cboMaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaDV.Name = "cboMaDV";
            this.cboMaDV.Size = new System.Drawing.Size(246, 28);
            this.cboMaDV.TabIndex = 7;
            // 
            // cboQuyenSD
            // 
            this.cboQuyenSD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboQuyenSD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboQuyenSD.FormattingEnabled = true;
            this.cboQuyenSD.Location = new System.Drawing.Point(280, 336);
            this.cboQuyenSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboQuyenSD.Name = "cboQuyenSD";
            this.cboQuyenSD.Size = new System.Drawing.Size(246, 28);
            this.cboQuyenSD.TabIndex = 8;
            // 
            // dgvCanBo
            // 
            this.dgvCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanBo.Location = new System.Drawing.Point(560, 114);
            this.dgvCanBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCanBo.Name = "dgvCanBo";
            this.dgvCanBo.RowHeadersWidth = 51;
            this.dgvCanBo.RowTemplate.Height = 24;
            this.dgvCanBo.Size = new System.Drawing.Size(669, 425);
            this.dgvCanBo.TabIndex = 9;
            this.dgvCanBo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanBo_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Brown;
            this.btnThem.Location = new System.Drawing.Point(92, 399);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 47);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Brown;
            this.btnSua.Location = new System.Drawing.Point(246, 399);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 47);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnnXoa
            // 
            this.btnnXoa.ForeColor = System.Drawing.Color.Brown;
            this.btnnXoa.Location = new System.Drawing.Point(389, 399);
            this.btnnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnXoa.Name = "btnnXoa";
            this.btnnXoa.Size = new System.Drawing.Size(118, 47);
            this.btnnXoa.TabIndex = 12;
            this.btnnXoa.Text = "Xóa";
            this.btnnXoa.UseVisualStyleBackColor = true;
            this.btnnXoa.Click += new System.EventHandler(this.btnnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Brown;
            this.btnLuu.Location = new System.Drawing.Point(92, 492);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 47);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.ForeColor = System.Drawing.Color.Brown;
            this.btnKhongLuu.Location = new System.Drawing.Point(246, 492);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(118, 47);
            this.btnKhongLuu.TabIndex = 14;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.ForeColor = System.Drawing.Color.Brown;
            this.btnDong.Location = new System.Drawing.Point(389, 492);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 47);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCanBo);
            this.Controls.Add(this.cboQuyenSD);
            this.Controls.Add(this.cboMaDV);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cán bộ";
            this.Load += new System.EventHandler(this.frmCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanBo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.ComboBox cboMaDV;
        private System.Windows.Forms.ComboBox cboQuyenSD;
        private System.Windows.Forms.DataGridView dgvCanBo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnDong;
    }
}