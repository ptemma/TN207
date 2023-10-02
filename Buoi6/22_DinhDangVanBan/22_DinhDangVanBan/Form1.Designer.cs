namespace _22_DinhDangVanBan
{
    partial class frmDDVB
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
            this.txtVB = new System.Windows.Forms.TextBox();
            this.grpDinhDang = new System.Windows.Forms.GroupBox();
            this.rdioLeft = new System.Windows.Forms.RadioButton();
            this.rdioCenter = new System.Windows.Forms.RadioButton();
            this.rdioRight = new System.Windows.Forms.RadioButton();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpDinhDang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(185, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Định dạng văn bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Văn bản";
            // 
            // txtVB
            // 
            this.txtVB.Location = new System.Drawing.Point(132, 113);
            this.txtVB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVB.Multiline = true;
            this.txtVB.Name = "txtVB";
            this.txtVB.Size = new System.Drawing.Size(370, 31);
            this.txtVB.TabIndex = 2;
            this.txtVB.Text = "Visual studio .NET 2012";
            this.txtVB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpDinhDang
            // 
            this.grpDinhDang.Controls.Add(this.rdioRight);
            this.grpDinhDang.Controls.Add(this.rdioCenter);
            this.grpDinhDang.Controls.Add(this.rdioLeft);
            this.grpDinhDang.ForeColor = System.Drawing.Color.Blue;
            this.grpDinhDang.Location = new System.Drawing.Point(76, 223);
            this.grpDinhDang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDinhDang.Name = "grpDinhDang";
            this.grpDinhDang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDinhDang.Size = new System.Drawing.Size(412, 138);
            this.grpDinhDang.TabIndex = 3;
            this.grpDinhDang.TabStop = false;
            this.grpDinhDang.Text = "Định dạng văn bản";
            // 
            // rdioLeft
            // 
            this.rdioLeft.AutoSize = true;
            this.rdioLeft.ForeColor = System.Drawing.Color.Black;
            this.rdioLeft.Location = new System.Drawing.Point(39, 59);
            this.rdioLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdioLeft.Name = "rdioLeft";
            this.rdioLeft.Size = new System.Drawing.Size(64, 26);
            this.rdioLeft.TabIndex = 0;
            this.rdioLeft.TabStop = true;
            this.rdioLeft.Text = "Trái";
            this.rdioLeft.UseVisualStyleBackColor = true;
            this.rdioLeft.CheckedChanged += new System.EventHandler(this.rdioLeft_CheckedChanged);
            // 
            // rdioCenter
            // 
            this.rdioCenter.AutoSize = true;
            this.rdioCenter.ForeColor = System.Drawing.Color.Black;
            this.rdioCenter.Location = new System.Drawing.Point(170, 59);
            this.rdioCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdioCenter.Name = "rdioCenter";
            this.rdioCenter.Size = new System.Drawing.Size(71, 26);
            this.rdioCenter.TabIndex = 1;
            this.rdioCenter.TabStop = true;
            this.rdioCenter.Text = "Giữa";
            this.rdioCenter.UseVisualStyleBackColor = true;
            this.rdioCenter.CheckedChanged += new System.EventHandler(this.rdioCenter_CheckedChanged);
            // 
            // rdioRight
            // 
            this.rdioRight.AutoSize = true;
            this.rdioRight.ForeColor = System.Drawing.Color.Black;
            this.rdioRight.Location = new System.Drawing.Point(292, 59);
            this.rdioRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdioRight.Name = "rdioRight";
            this.rdioRight.Size = new System.Drawing.Size(66, 26);
            this.rdioRight.TabIndex = 2;
            this.rdioRight.TabStop = true;
            this.rdioRight.Text = "Phải";
            this.rdioRight.UseVisualStyleBackColor = true;
            this.rdioRight.CheckedChanged += new System.EventHandler(this.rdioRight_CheckedChanged);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(199, 400);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(139, 47);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDDVB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(537, 486);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpDinhDang);
            this.Controls.Add(this.txtVB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDDVB";
            this.Text = "Định dạng văn bản";
            this.Load += new System.EventHandler(this.frmDDVB_Load);
            this.grpDinhDang.ResumeLayout(false);
            this.grpDinhDang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVB;
        private System.Windows.Forms.GroupBox grpDinhDang;
        private System.Windows.Forms.RadioButton rdioRight;
        private System.Windows.Forms.RadioButton rdioCenter;
        private System.Windows.Forms.RadioButton rdioLeft;
        private System.Windows.Forms.Button btnDong;
    }
}

