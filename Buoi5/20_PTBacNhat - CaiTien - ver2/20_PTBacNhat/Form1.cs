﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_PTBacNhat
{
    public partial class frmGiaiPTBacNhat : Form
    {
        public frmGiaiPTBacNhat()
        {
            InitializeComponent();
        }
        private void frmGiaiPTBacNhat_Load(object sender, EventArgs e)
        {
            txtA.Focus();
            txtKQ.Enabled = false;
            txtKQ.BackColor = Color.White;
        }
        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            float a, b;
            if(!float.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập lại a", "Lỗi nhập a");
                txtA.Clear();
                txtA.Focus(); 
                return;
            }
            if (!float.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập lại b", "Lỗi nhập b");
                txtB.Clear();
                txtB.Focus();
                return;
            }
            if (a == 0)
            {
                if (b == 0)
                    txtKQ.Text = "phương trình vô số nghiệm";
                else
                    txtKQ.Text = "Phương trình vô nghiệm";
            }
            else
                txtKQ.Text = "PT có nghiệm : " + (-b / a).ToString("#,##0.00");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
            txtA.Focus();

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
