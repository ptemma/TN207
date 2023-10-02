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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuTienThuePhong_Click(object sender, EventArgs e)
        {
            frmTinhTienThuePhong fTinhTienTP = new frmTinhTienThuePhong();
            fTinhTienTP.ShowDialog();
        }
        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương tình tính tiền thuê phòng", "Giới thiệu");
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMaHoaTuDong_Click(object sender, EventArgs e)
        {
            frmMaHoaTuDong fMaHoaTD = new frmMaHoaTuDong();
            fMaHoaTD.ShowDialog();
        }

        private void mnuChonUD_Click(object sender, EventArgs e)
        {

        }

        
    }
}
