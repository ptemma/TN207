using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe5_Nhom11
{
    public partial class frmTimKiemThanhVien : Form
    {
        DataTable dtThanhVien = new DataTable("ThanhVien");
        DataTable dtMaHo = new DataTable("MaHo");
        DataView dvThanhVien = new DataView();

        DataTable dtMaNgheNghiep = new DataTable("MaNgheNghiep");
        DataTable dtMatrinhDo = new DataTable("MaTrinhDo");
        DataTable dtMaDoiTuong = new DataTable("MaDoiTuong");

        DataTable dtQuyenSD = new DataTable("QuyenSD");
        int viTriNghe, ViTriTrinhDo, ViTriDoiTuong;
        public frmTimKiemThanhVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemThanhVien_Load(object sender, EventArgs e)
        {
            string strHoGD = "select MaHo from HoGiaDinh";
            MyPublics.OpenData(strHoGD, dtMaHo);
            cboMaHo.DataSource = dtMaHo;
            cboMaHo.DisplayMember = "MaHo";
            cboMaHo.ValueMember = "MaHo";
            cboMaHo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaHo.AutoCompleteSource = AutoCompleteSource.ListItems;

            string strNgheNghiep = "select TenNgheNghiep,MaNgheNghiep from NgheNghiep";
            MyPublics.OpenData(strNgheNghiep, dtMaNgheNghiep);
            cboNgheNghiep.DataSource = dtMaNgheNghiep;
            cboNgheNghiep.DisplayMember = "TenNgheNghiep";
            cboNgheNghiep.ValueMember = "MaNgheNghiep";
            cboNgheNghiep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNgheNghiep.AutoCompleteSource = AutoCompleteSource.ListItems;


            string strTrinhDo = "select DienGiai,MaTrinhDo from TrinhDo";
            MyPublics.OpenData(strTrinhDo, dtMatrinhDo);
            cboTrinhDo.DataSource = dtMatrinhDo;
            cboTrinhDo.DisplayMember = "DienGiai";
            cboTrinhDo.ValueMember = "MaTrinhDo";
            cboTrinhDo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTrinhDo.AutoCompleteSource = AutoCompleteSource.ListItems;

            string strDoiTuong = "select TenDoiTuong,MaDoiTuong from DoiTuong";
            MyPublics.OpenData(strDoiTuong, dtMaDoiTuong);
            cboDoiTuong.DataSource = dtMaDoiTuong;
            cboDoiTuong.DisplayMember = "TenDoiTuong";
            cboDoiTuong.ValueMember = "MaDoiTuong";
            cboDoiTuong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoiTuong.AutoCompleteSource = AutoCompleteSource.ListItems;


            dtQuyenSD.Columns.Add("QuyenSD");
            dtQuyenSD.Rows.Add("User");
            dtQuyenSD.Rows.Add("Admin");
            cboQuyenSD.DataSource = dtQuyenSD;
            cboQuyenSD.DisplayMember = "QuyenSD";
            cboQuyenSD.ValueMember = "QuyenSD";

            txtHovaTen.MaxLength = 40;
            txtQuanHeVoiChuHo.MaxLength = 30;


            string strSelect = "select tv.MaHo, tv.SttThanhVien, tv.HoTenThanhVien, tv.Phai, tv.NgaySinh, tv.QuanHeVoiChuHo, tv.MaNgheNghiep, tv.MaTrinhDo, tv.MaDoiTuong, tv.MatKhau, tv.QuyenSD from HoGiaDinh hgd, ThanhVien tv, NgheNghiep nn, TrinhDo td, DoiTuong dt where hgd.MaHo= tv.MaHo and tv.MaNgheNghiep= nn.MaNgheNghiep and tv.MaTrinhDo = td.MaTrinhDo and tv.MaDoiTuong= dt.MaDoiTuong";
            MyPublics.OpenData(strSelect, dtThanhVien);
            dvThanhVien.Table = dtThanhVien;
            dgvThanhVien.DataSource = dtThanhVien;
            dgvThanhVien.Width = 780;
            dgvThanhVien.AllowUserToAddRows = false;
            dgvThanhVien.AllowUserToDeleteRows = false;

            dgvThanhVien.Columns[0].Width = 78;
            dgvThanhVien.Columns[0].HeaderText = "Mã Hộ";

            dgvThanhVien.Columns[1].Width = 50;
            dgvThanhVien.Columns[1].HeaderText = "STT";

            dgvThanhVien.Columns[2].Width = 130;
            dgvThanhVien.Columns[2].HeaderText = "Họ và tên";

            dgvThanhVien.Columns[3].Width = 80;
            dgvThanhVien.Columns[3].HeaderText = "Giới tính";

            dgvThanhVien.Columns[4].Width = 99;
            dgvThanhVien.Columns[4].HeaderText = "Ngày sinh";

            dgvThanhVien.Columns[5].Width = 100;
            dgvThanhVien.Columns[5].HeaderText = "Quan hệ với chủ hộ";

            dgvThanhVien.Columns[6].Visible = false;
            dgvThanhVien.Columns[7].Visible = false;
            dgvThanhVien.Columns[8].Visible = false;

            dgvThanhVien.Columns[9].Width = 95;
            dgvThanhVien.Columns[9].HeaderText = "Mật khẩu";

            dgvThanhVien.Columns[10].Width = 98;
            dgvThanhVien.Columns[10].HeaderText = "Quyền SD";

            dgvThanhVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            ganDuLieu();
            dieuKhienKhiBinhThuong();
        }
        void dieuKhienKhiBinhThuong()
        {
            
            btnDong.Enabled = true;
            txtSTT.ReadOnly = true;
            txtSTT.BackColor = Color.White;
            txtHovaTen.ReadOnly = true;
            txtHovaTen.BackColor = Color.White;
            txtQuanHeVoiChuHo.ReadOnly = true;
            txtQuanHeVoiChuHo.BackColor = Color.White;

            grpGioiTinh.Enabled = false;
            cboMaHo.Enabled = true;
            cboQuyenSD.Enabled = false;
            cboNgheNghiep.Enabled = true;
            cboDoiTuong.Enabled = false;
            cboTrinhDo.Enabled = false;
            dgvThanhVien.Enabled = true;
        }


        private void dgvThanhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*',
                   e.Value.ToString().Length);
                }
            }
        }

        void ganDuLieu()
        {
            if (dvThanhVien.Count > 0)
            {
                cboMaHo.SelectedIndex = cboMaHo.FindString(dgvThanhVien[0, dgvThanhVien.CurrentRow.Index].Value.ToString());

                txtSTT.Text = dgvThanhVien[1, dgvThanhVien.CurrentRow.Index].Value.ToString();
                txtHovaTen.Text = dgvThanhVien[2, dgvThanhVien.CurrentRow.Index].Value.ToString();
                string stringValue = dgvThanhVien[3, dgvThanhVien.CurrentRow.Index].Value.ToString();
                bool bitValue = Convert.ToBoolean(stringValue);
                if (bitValue)
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;

                dtpNgaySinh.Value = DateTime.Parse(dgvThanhVien[4, dgvThanhVien.CurrentRow.Index].Value.ToString());
                txtQuanHeVoiChuHo.Text = dgvThanhVien[5, dgvThanhVien.CurrentRow.Index].Value.ToString();

                string strNghe = (string)dgvThanhVien[6, dgvThanhVien.CurrentRow.Index].Value.ToString();
                int intNghe = int.Parse(strNghe) - 1;
                cboNgheNghiep.SelectedIndex = intNghe;

                string strTrinhDo = (string)dgvThanhVien[7, dgvThanhVien.CurrentRow.Index].Value.ToString();
                int intTrinhDo = int.Parse(strTrinhDo) - 1;
                cboTrinhDo.SelectedIndex = intTrinhDo;

                string strDoiTuong = (string)dgvThanhVien[8, dgvThanhVien.CurrentRow.Index].Value.ToString();
                if (strDoiTuong == "")
                {
                    cboDoiTuong.SelectedIndex = -1;
                    return;
                }
                else
                {
                    int intDoiTuong = int.Parse(strDoiTuong) - 1;
                    if (intDoiTuong != -1)
                        cboDoiTuong.SelectedIndex = intDoiTuong;
                }
                cboQuyenSD.SelectedIndex = cboQuyenSD.FindString(dgvThanhVien[10, dgvThanhVien.CurrentRow.Index].Value.ToString());

            }
            else
            {
                txtHovaTen.Clear();
                txtQuanHeVoiChuHo.Clear();
                dtpNgaySinh.Value = DateTime.Today;

                cboDoiTuong.SelectedIndex = -1;
                cboNgheNghiep.SelectedIndex = -1;
                cboTrinhDo.SelectedIndex = -1;
                cboQuyenSD.SelectedIndex = -1;
                cboMaHo.SelectedIndex = -1;
            }
        }

        private void timKiemTheoMaHo(string MaHo)
        {
            if (cboMaHo.SelectedItem != null && cboMaHo.SelectedIndex != -1)
            {
                dvThanhVien.RowFilter = "MaHo =" + MaHo;
                dgvThanhVien.DataSource = dvThanhVien;
                ganDuLieu();

            }
        }
        private void TimKiemTheoNgheNghiep(string MaNgheNghiep)
        {
            if (cboNgheNghiep.SelectedItem != null && cboNgheNghiep.SelectedIndex != -1)
            {
                dvThanhVien.RowFilter = "MaNgheNghiep =" + MaNgheNghiep;
                dgvThanhVien.DataSource = dvThanhVien;
                ganDuLieu();
            }
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ganDuLieu();
        }


        private void cboMaHo_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if ((cboMaHo.SelectedIndex != -1))
            {
                timKiemTheoMaHo(cboMaHo.SelectedValue.ToString());
            }
        }


        private void cboNgheNghiep_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((cboNgheNghiep.SelectedIndex != -1))
            {
                TimKiemTheoNgheNghiep(cboNgheNghiep.SelectedValue.ToString());
            }
        }


        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
