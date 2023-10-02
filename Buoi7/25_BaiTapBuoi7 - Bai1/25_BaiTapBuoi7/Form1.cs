using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_BaiTapBuoi7
{
    public partial class frmTinhTienThuePhong : Form
    {
        static float DonGia = 250000;
        public frmTinhTienThuePhong()
        {
            InitializeComponent();
        }

        private void frmTinhTienThuePhong_Load(object sender, EventArgs e)
        {
            txtKH.Focus();
        }
        private void ThucThi()
        {
            if (dtpNgayDi.Value < dtpNgayDen.Value)
            {
                MessageBox.Show("Lỗi chọn ngày");
                dtpNgayDi.Value = dtpNgayDen.Value;
            }
            else
            {
                txtSoNgayO.Text = ((dtpNgayDi.Value - dtpNgayDen.Value).Days + 1).ToString();
                txtThanhTien.Text = (int.Parse(txtSoNgayO.Text) * DonGia).ToString("#,### vnđ");
            }
        }
        

        private void dtpNgayDen_ValueChanged(object sender, EventArgs e)
        {
            ThucThi();
        }

        private void dtpNgayDi_ValueChanged(object sender, EventArgs e)
        {
            ThucThi();
        }

        private void btnKHMoi_Click(object sender, EventArgs e)
        {
            txtKH.Clear();
            txtKH.Focus();
            txtPhong.Clear();
            txtSoNgayO.Clear();
            txtThanhTien.Clear();
            dtpNgayDen.Value = DateTime.Today;
            dtpNgayDi.Value = DateTime.Today;

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
