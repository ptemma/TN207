using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_CuocPhiInternet
{
    public partial class frmQLCuocPhiInternet : Form
    {
        public frmQLCuocPhiInternet()
        {
            InitializeComponent();
        }
        private void frmQLCuocPhiInternet_Load(object sender, EventArgs e)
        {
            rdioYes.Checked = true;
            txtTienPhaiTra.ReadOnly = true;
            txtTienPhaiTra.BackColor = Color.White;
            txtMaKH.Focus();

        }
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int intGioBT, intGioTD;
            float fTinhTien;
            if (txtMaKH.Text == "")
            {
                txtMaKH.Focus();
                MessageBox.Show("Nhập mã khách hàng!");
                return;
            }
            if (!int.TryParse(txtGioBT.Text, out intGioBT) || intGioBT <= 0)
            {
                MessageBox.Show("Nhập sai giờ bình thường!");
                txtGioBT.Focus();
                return;
            }
            if (!int.TryParse(txtGioTD.Text, out intGioTD) || intGioTD <= 0)
            {
                MessageBox.Show("Nhập sai giờ thấp điểm!");
                txtGioTD.Focus();
                return;
            }
            fTinhTien = intGioBT * 2000 + intGioTD * 1200;
            if (chkHSSV.Checked)
                fTinhTien *= 0.85f;
            if (rdioYes.Checked)
                fTinhTien *= 0.8f;
            txtTienPhaiTra.Text = fTinhTien.ToString("$ #,##0.00");

        }

        private void btnKHMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Focus();
            txtMaKH.Clear();
            txtGioTD.Clear();
            txtGioBT.Clear();
            chkHSSV.Checked = false;
            rdioYes.Checked = true;
            txtTienPhaiTra.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
