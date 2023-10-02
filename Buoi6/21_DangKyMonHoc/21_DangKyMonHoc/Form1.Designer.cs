namespace _21_DangKyMonHoc
{
    partial class frmDKMonHoc
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
            this.btnDong = new System.Windows.Forms.Button();
            this.grboxDSMonHoc = new System.Windows.Forms.GroupBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkHDH = new System.Windows.Forms.CheckBox();
            this.chkCSDL = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.txtTongSoTC = new System.Windows.Forms.TextBox();
            this.grboxDSMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(76, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số tín chỉ";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(134, 482);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(183, 32);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng From";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grboxDSMonHoc
            // 
            this.grboxDSMonHoc.Controls.Add(this.chkC);
            this.grboxDSMonHoc.Controls.Add(this.chkHDH);
            this.grboxDSMonHoc.Controls.Add(this.chkCSDL);
            this.grboxDSMonHoc.Controls.Add(this.chkJava);
            this.grboxDSMonHoc.ForeColor = System.Drawing.Color.Blue;
            this.grboxDSMonHoc.Location = new System.Drawing.Point(80, 136);
            this.grboxDSMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.grboxDSMonHoc.Name = "grboxDSMonHoc";
            this.grboxDSMonHoc.Padding = new System.Windows.Forms.Padding(4);
            this.grboxDSMonHoc.Size = new System.Drawing.Size(288, 271);
            this.grboxDSMonHoc.TabIndex = 3;
            this.grboxDSMonHoc.TabStop = false;
            this.grboxDSMonHoc.Text = "Chọn môn học";
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.ForeColor = System.Drawing.Color.Black;
            this.chkC.Location = new System.Drawing.Point(34, 193);
            this.chkC.Margin = new System.Windows.Forms.Padding(4);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(184, 26);
            this.chkC.TabIndex = 3;
            this.chkC.Text = "Visual C#_3 tín chỉ";
            this.chkC.UseVisualStyleBackColor = true;
            this.chkC.CheckedChanged += new System.EventHandler(this.chkC_CheckedChanged);
            // 
            // chkHDH
            // 
            this.chkHDH.AutoSize = true;
            this.chkHDH.ForeColor = System.Drawing.Color.Black;
            this.chkHDH.Location = new System.Drawing.Point(34, 156);
            this.chkHDH.Margin = new System.Windows.Forms.Padding(4);
            this.chkHDH.Name = "chkHDH";
            this.chkHDH.Size = new System.Drawing.Size(214, 26);
            this.chkHDH.TabIndex = 2;
            this.chkHDH.Text = "Hệ điều hành_ 2 tín chỉ";
            this.chkHDH.UseVisualStyleBackColor = true;
            this.chkHDH.CheckedChanged += new System.EventHandler(this.chkHDH_CheckedChanged);
            // 
            // chkCSDL
            // 
            this.chkCSDL.AutoSize = true;
            this.chkCSDL.ForeColor = System.Drawing.Color.Black;
            this.chkCSDL.Location = new System.Drawing.Point(34, 119);
            this.chkCSDL.Margin = new System.Windows.Forms.Padding(4);
            this.chkCSDL.Name = "chkCSDL";
            this.chkCSDL.Size = new System.Drawing.Size(220, 26);
            this.chkCSDL.TabIndex = 1;
            this.chkCSDL.Text = "Cơ sở dữ liệu_ 3 tín chỉ";
            this.chkCSDL.UseVisualStyleBackColor = true;
            this.chkCSDL.CheckedChanged += new System.EventHandler(this.chkCSDL_CheckedChanged);
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.ForeColor = System.Drawing.Color.Black;
            this.chkJava.Location = new System.Drawing.Point(34, 82);
            this.chkJava.Margin = new System.Windows.Forms.Padding(4);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(216, 26);
            this.chkJava.TabIndex = 0;
            this.chkJava.Text = "Lập trình java_3 tín chỉ";
            this.chkJava.UseVisualStyleBackColor = true;
            this.chkJava.CheckedChanged += new System.EventHandler(this.chkJava_CheckedChanged);
            // 
            // txtTongSoTC
            // 
            this.txtTongSoTC.Location = new System.Drawing.Point(232, 429);
            this.txtTongSoTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongSoTC.Name = "txtTongSoTC";
            this.txtTongSoTC.Size = new System.Drawing.Size(136, 30);
            this.txtTongSoTC.TabIndex = 4;
            this.txtTongSoTC.Text = "0";
            this.txtTongSoTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmDKMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(460, 596);
            this.Controls.Add(this.txtTongSoTC);
            this.Controls.Add(this.grboxDSMonHoc);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDKMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký môn học";
            this.Load += new System.EventHandler(this.frmDKMonHoc_Load);
            this.grboxDSMonHoc.ResumeLayout(false);
            this.grboxDSMonHoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grboxDSMonHoc;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkHDH;
        private System.Windows.Forms.CheckBox chkCSDL;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.TextBox txtTongSoTC;
    }
}

