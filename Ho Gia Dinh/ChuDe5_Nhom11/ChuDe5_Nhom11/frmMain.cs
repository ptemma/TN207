using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe5_Nhom11
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
        }
        
        private void customizeDesing()
        {
            pnlSubMenuDuLieu.Visible = false;
            pnlSubMenuTienIch.Visible = false;
            pnlSubMenuCapNhat.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubMenuDuLieu.Visible == true)
                pnlSubMenuDuLieu.Visible = false;
            if (pnlSubMenuTienIch.Visible == true)
                pnlSubMenuTienIch.Visible = false;
            if (pnlSubMenuCapNhat.Visible == true)
                pnlSubMenuCapNhat.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMenuDuLieu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuDuLieu);
        }

        private Form activeForm = null;
        private void openChildFrom(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            openChildFrom(new frmDangNhap(this));
        }

        private void btnMunuCapNhat_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuCapNhat);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmDangNhap(this));
            hideSubMenu();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmDoiMatKhau());
            hideSubMenu();
        }

        

      

      

    

        private void btnMenuTienIch_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuTienIch);
        }

      

     

        private void btnHuongDanSD_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmHuongDanSuDung());
            hideSubMenu();
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmLienHe());
            hideSubMenu();
        }

        private void btnTTUngDung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng quản lý bài thi do nhóm 2 thực hiện!", "Giới thiệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu đang trong quá trình phát triển vui lòng quay lại sau!", "Giới thiệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            hideSubMenu();
        }

       

        private void btnKhomAp_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmKhomAp());
            hideSubMenu();
        }

        private void btnHoGiaDinh_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmHoGiaDinh());
            hideSubMenu();
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmThanhViencs());
            hideSubMenu();
        }

        private void btnNgheNghiep_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmNgheNghiep());
            hideSubMenu();
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmTrinhDo());
            hideSubMenu();
        }

        private void btnDoiTuong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmDoiTuong());
            hideSubMenu();
        }

        private void btnHoGiaDinhTheoAp_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmHoGiaDinhTheoKhomAp());
            hideSubMenu();
        }

        private void btnTimKiemThanhVien_Click(object sender, EventArgs e)
        {
            openChildFrom(new frmTimKiemThanhVien());
            hideSubMenu();
        }
    }
}
