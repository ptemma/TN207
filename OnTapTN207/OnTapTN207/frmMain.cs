using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapTN207
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình quản lý Version 1.0 \n Khoa Truyền thông đa phương tiện", "Giới thiệu");
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

        private void mnuCanBo_Click(object sender, EventArgs e)
        {
            frmCanBo fCanBo = new frmCanBo();
            fCanBo.ShowDialog();
        }
    }
}
