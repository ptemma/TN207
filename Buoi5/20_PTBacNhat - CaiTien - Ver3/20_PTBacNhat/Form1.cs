using System;
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
            btnLamMoi.Enabled = false;
            btnGiaiPT.Enabled = false;
            txtKQ.ReadOnly = true;
            txtKQ.BackColor = Color.White;
        }
        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            float a, b;
            if(!float.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập lại a", "Lỗi nhập a");
                btnGiaiPT.Enabled = false;
                txtA.Clear();
                txtA.Focus(); 
                return;
            }
            if (!float.TryParse(txtB.Text, out b))
            {
                btnGiaiPT.Enabled = false;
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
            btnGiaiPT.Enabled = false;
            btnLamMoi.Enabled = true;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
            txtA.Focus();
            btnLamMoi.Enabled = false;
        }
        
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text.Length > 0 && txtB.Text.Length > 0)
                btnGiaiPT.Enabled = true;
            else
                btnGiaiPT.Enabled = false;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text.Length > 0 && txtB.Text.Length > 0)
                btnGiaiPT.Enabled = true;
            else
                btnGiaiPT.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
