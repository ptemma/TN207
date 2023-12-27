using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình quản lý sinh viên Version 1.0 \n "+
                "Bộ môn Tin học ứng dụng", "Giới thiệu");
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap fDangNhap = new frmDangNhap(this);
            fDangNhap.ShowDialog();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop_03 fLop = new frmLop_03(this);
            fLop.ShowDialog();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap fDangNhap = new frmDangNhap(this);
            fDangNhap.ShowDialog();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien fSV = new frmSinhVien(this);
            fSV.ShowDialog();
        }
    }
}
