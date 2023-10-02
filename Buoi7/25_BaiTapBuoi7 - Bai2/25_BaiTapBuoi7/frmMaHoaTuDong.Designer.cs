namespace _25_BaiTapBuoi7
{
    partial class frmMaHoaTuDong
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
            this.txtPwCanTao = new System.Windows.Forms.TextBox();
            this.txtPwDuocGiaiMa = new System.Windows.Forms.TextBox();
            this.txtPwLength = new System.Windows.Forms.TextBox();
            this.lstPwDuocTao = new System.Windows.Forms.ListBox();
            this.lstPwDuocMaHoa = new System.Windows.Forms.ListBox();
            this.chkHidePw = new System.Windows.Forms.CheckBox();
            this.btnTaoPasswords = new System.Windows.Forms.Button();
            this.btnMaHoaPasswords = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(370, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa password tự động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(49, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số password cần tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(277, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password được tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(509, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password được mã hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(767, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password được giải mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(49, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chiều dài password";
            // 
            // txtPwCanTao
            // 
            this.txtPwCanTao.Location = new System.Drawing.Point(53, 202);
            this.txtPwCanTao.Name = "txtPwCanTao";
            this.txtPwCanTao.Size = new System.Drawing.Size(170, 30);
            this.txtPwCanTao.TabIndex = 6;
            // 
            // txtPwDuocGiaiMa
            // 
            this.txtPwDuocGiaiMa.Location = new System.Drawing.Point(771, 202);
            this.txtPwDuocGiaiMa.Name = "txtPwDuocGiaiMa";
            this.txtPwDuocGiaiMa.Size = new System.Drawing.Size(198, 30);
            this.txtPwDuocGiaiMa.TabIndex = 7;
            // 
            // txtPwLength
            // 
            this.txtPwLength.Location = new System.Drawing.Point(53, 335);
            this.txtPwLength.Name = "txtPwLength";
            this.txtPwLength.Size = new System.Drawing.Size(170, 30);
            this.txtPwLength.TabIndex = 8;
            // 
            // lstPwDuocTao
            // 
            this.lstPwDuocTao.FormattingEnabled = true;
            this.lstPwDuocTao.ItemHeight = 23;
            this.lstPwDuocTao.Location = new System.Drawing.Point(281, 202);
            this.lstPwDuocTao.Name = "lstPwDuocTao";
            this.lstPwDuocTao.Size = new System.Drawing.Size(165, 165);
            this.lstPwDuocTao.TabIndex = 9;
            // 
            // lstPwDuocMaHoa
            // 
            this.lstPwDuocMaHoa.FormattingEnabled = true;
            this.lstPwDuocMaHoa.ItemHeight = 23;
            this.lstPwDuocMaHoa.Location = new System.Drawing.Point(513, 202);
            this.lstPwDuocMaHoa.Name = "lstPwDuocMaHoa";
            this.lstPwDuocMaHoa.Size = new System.Drawing.Size(198, 165);
            this.lstPwDuocMaHoa.TabIndex = 10;
            this.lstPwDuocMaHoa.SelectedIndexChanged += new System.EventHandler(this.lstPwDuocMaHoa_SelectedIndexChanged);
            // 
            // chkHidePw
            // 
            this.chkHidePw.AutoSize = true;
            this.chkHidePw.Location = new System.Drawing.Point(771, 273);
            this.chkHidePw.Name = "chkHidePw";
            this.chkHidePw.Size = new System.Drawing.Size(139, 27);
            this.chkHidePw.TabIndex = 11;
            this.chkHidePw.Text = "Ẩn password";
            this.chkHidePw.UseVisualStyleBackColor = true;
            this.chkHidePw.CheckedChanged += new System.EventHandler(this.chkHidePw_CheckedChanged);
            // 
            // btnTaoPasswords
            // 
            this.btnTaoPasswords.ForeColor = System.Drawing.Color.Maroon;
            this.btnTaoPasswords.Location = new System.Drawing.Point(185, 429);
            this.btnTaoPasswords.Name = "btnTaoPasswords";
            this.btnTaoPasswords.Size = new System.Drawing.Size(167, 44);
            this.btnTaoPasswords.TabIndex = 12;
            this.btnTaoPasswords.Text = "Tạo password";
            this.btnTaoPasswords.UseVisualStyleBackColor = true;
            this.btnTaoPasswords.Click += new System.EventHandler(this.btnTaoPasswords_Click);
            // 
            // btnMaHoaPasswords
            // 
            this.btnMaHoaPasswords.ForeColor = System.Drawing.Color.Maroon;
            this.btnMaHoaPasswords.Location = new System.Drawing.Point(375, 429);
            this.btnMaHoaPasswords.Name = "btnMaHoaPasswords";
            this.btnMaHoaPasswords.Size = new System.Drawing.Size(204, 44);
            this.btnMaHoaPasswords.TabIndex = 13;
            this.btnMaHoaPasswords.Text = "Mã hóa password";
            this.btnMaHoaPasswords.UseVisualStyleBackColor = true;
            this.btnMaHoaPasswords.Click += new System.EventHandler(this.btnMaHoaPasswords_Click);
            // 
            // btnDong
            // 
            this.btnDong.ForeColor = System.Drawing.Color.Maroon;
            this.btnDong.Location = new System.Drawing.Point(610, 429);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(167, 44);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng form";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmMaHoaTuDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1004, 528);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnMaHoaPasswords);
            this.Controls.Add(this.btnTaoPasswords);
            this.Controls.Add(this.chkHidePw);
            this.Controls.Add(this.lstPwDuocMaHoa);
            this.Controls.Add(this.lstPwDuocTao);
            this.Controls.Add(this.txtPwLength);
            this.Controls.Add(this.txtPwDuocGiaiMa);
            this.Controls.Add(this.txtPwCanTao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaHoaTuDong";
            this.Text = "Mã hóa password tự động";
            this.Load += new System.EventHandler(this.frmMaHoaTuDong_Load);
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
        private System.Windows.Forms.TextBox txtPwCanTao;
        private System.Windows.Forms.TextBox txtPwDuocGiaiMa;
        private System.Windows.Forms.TextBox txtPwLength;
        private System.Windows.Forms.ListBox lstPwDuocTao;
        private System.Windows.Forms.ListBox lstPwDuocMaHoa;
        private System.Windows.Forms.CheckBox chkHidePw;
        private System.Windows.Forms.Button btnTaoPasswords;
        private System.Windows.Forms.Button btnMaHoaPasswords;
        private System.Windows.Forms.Button btnDong;
    }
}