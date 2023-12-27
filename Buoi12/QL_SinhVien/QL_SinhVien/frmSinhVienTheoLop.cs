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

namespace QL_SinhVien
{
    public partial class frmSinhVienTheoLop : Form
    {
        DataTable dtSinhVien = new DataTable("SinhVien");
        DataView dvSinhVien = new DataView();
        DataTable dtLop = new DataTable("Lop");
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        int ViTriLop, ThemSua = 0;
        public frmSinhVienTheoLop()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "AdminKhoa")
            {
                btnThem.Enabled = true;
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true;
            }

            else
            {
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            cboLop.Enabled = true;
            txtMSSV.ReadOnly = true;
            txtMSSV.BackColor = Color.White;
            txtHoLot.ReadOnly = true;
            txtHoLot.BackColor = Color.White;
            txtTen.ReadOnly = true;
            txtTen.BackColor = Color.White;
            grpPhai.Enabled = false;
            cboQuyenSD.Enabled = false;
            dgvSinhVien.Enabled = true;
        }

        void nhanDuLieu()
        {
            string strSelect = "Select * From SinhVien";
            MyPublics.OpenData(strSelect, dtSinhVien);
        }
        private void frmSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            string strSelect = "Select MSLop, TenLop From Lop";
            MyPublics.OpenData(strSelect, dtLop);
            cboLop.DataSource = dtLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MSLop";
            cboLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLop.AutoCompleteSource = AutoCompleteSource.ListItems;

            nhanDuLieu();
            dtQuyenSD.Columns.Add("QuyenSD");
            dtQuyenSD.Rows.Add("User");
            dtQuyenSD.Rows.Add("AdminLop");
            dtQuyenSD.Rows.Add("AdminKhoa");
            cboQuyenSD.DataSource = dtQuyenSD;
            cboQuyenSD.DisplayMember = "QuyenSD";
            cboQuyenSD.ValueMember = "QuyenSD";
            txtMSSV.MaxLength = 8;
            txtHoLot.MaxLength = 30;
            txtTen.MaxLength = 12;

            dvSinhVien.Table = dtSinhVien;
            dvSinhVien.RowFilter = "MSLop like '" +cboLop.SelectedValue + "'";
            dgvSinhVien.DataSource = dvSinhVien;
            dgvSinhVien.Width = 790;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.Columns[0].Width = 85;
            dgvSinhVien.Columns[0].HeaderText = "Mã số";
            dgvSinhVien.Columns[1].Width = 140;
            dgvSinhVien.Columns[1].HeaderText = "Họ lót";
            dgvSinhVien.Columns[2].Width = 60;
            dgvSinhVien.Columns[2].HeaderText = "Tên";
            dgvSinhVien.Columns[3].Width = 50;
            dgvSinhVien.Columns[3].HeaderText = "Giới tính";
            dgvSinhVien.Columns[4].Width = 100;
            dgvSinhVien.Columns[4].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns[5].Width = 90;
            dgvSinhVien.Columns[5].HeaderText = "Lớp";
            dgvSinhVien.Columns[6].Width = 100;
            dgvSinhVien.Columns[6].HeaderText = "Mật khẩu";
            dgvSinhVien.Columns[7].Width = 100;
            dgvSinhVien.Columns[7].HeaderText = "Quyền sử dụng";
            dgvSinhVien.EditMode =DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong();
            ganDuLieu();
        }

        void ganDuLieu()
        {
            if (dvSinhVien.Count > 0)
            {
                txtMSSV.Text = dgvSinhVien[0,dgvSinhVien.CurrentRow.Index].Value.ToString();
                txtHoLot.Text = dgvSinhVien[1,dgvSinhVien.CurrentRow.Index].Value.ToString();
                txtTen.Text = dgvSinhVien[2,dgvSinhVien.CurrentRow.Index].Value.ToString();
                if (dgvSinhVien[3, dgvSinhVien.CurrentRow.Index].Value.ToString() == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtpNgaySinh.Value = DateTime.Parse(dgvSinhVien[4,dgvSinhVien.CurrentRow.Index].Value.ToString());
                cboQuyenSD.SelectedIndex = cboQuyenSD.FindString(dgvSinhVien[7, dgvSinhVien.CurrentRow.Index].Value.ToString());
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMSSV.Clear();
                txtHoLot.Clear();
                txtTen.Clear();
                rdoNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Today;
                cboQuyenSD.SelectedIndex = -1;
            }
        }

        void thucThiLuu()
        {
            string strSql, strPhai = "Nam", strLop, strMatKhau = "", strQuyenSD;
            if (ThemSua == 1)
                strSql = "Insert Into SinhVien Values(@MSSV,@HoLot, @Ten, @Phai,"+
                    "@NgaySinh, @MSLop,@MatKhau, @QuyenSD)";
            else
                strSql = "Update SinhVien Set HoLot = @HoLot, Ten = @Ten, Phai "+
                    "= @Phai, NgaySinh = @NgaySinh, MSLop = @MSLop, QuyenSD = @QuyenSD Where MSSV = @MSSV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql,MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@MSSV",txtMSSV.Text);
                cmdCommand.Parameters.AddWithValue("@HoLot",txtHoLot.Text);
                cmdCommand.Parameters.AddWithValue("@Ten",txtTen.Text);
            if (rdoNu.Checked)
                strPhai = "Nữ";
                cmdCommand.Parameters.AddWithValue("@Phai", strPhai);
                cmdCommand.Parameters.AddWithValue("@NgaySinh",dtpNgaySinh.Value);
                strLop = cboLop.SelectedValue.ToString();
                cmdCommand.Parameters.AddWithValue("@MSLop", strLop);
            if (ThemSua == 1)
            {
                strMatKhau = MyPublics.MaHoaPassword(txtMSSV.Text);
                cmdCommand.Parameters.AddWithValue("@MatKhau", strMatKhau);
            }
            strQuyenSD = cboQuyenSD.SelectedValue.ToString();

            cmdCommand.Parameters.AddWithValue("@QuyenSD", strQuyenSD);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            ThemSua = 0;
            dtSinhVien.Clear();
            nhanDuLieu();
            if (cboLop.SelectedIndex == ViTriLop)
            {
                dvSinhVien.Sort = "MSSV";
                int curRow = dvSinhVien.Find(txtMSSV.Text);
                dgvSinhVien.CurrentCell = dgvSinhVien[0, curRow];
            }
            else
            {
                cboLop.SelectedIndex = ViTriLop;
                if (dvSinhVien.Count > 0)
                    dgvSinhVien.CurrentCell = dgvSinhVien[0, 0];
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ganDuLieu();
        }

        private void dgvSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*',
                   e.Value.ToString().Length);
                }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboLop.SelectedIndex != -1) && (ThemSua == 0))
            {
                dvSinhVien.RowFilter = "MSLop like '" + cboLop.SelectedValue + "'";
                dgvSinhVien.DataSource = dvSinhVien;
                ganDuLieu();
                if ((MyPublics.strQuyenSD == "AdminLop") &&
               (MyPublics.strLop == cboLop.SelectedValue.ToString()))
                {
                    btnThem.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
                else if (MyPublics.strQuyenSD != "AdminKhoa")
                    {
                        btnThem.Enabled = false;
                        btnChinhSua.Enabled = false;
                    }
            }
        }

        void dieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtMSSV.ReadOnly = false;
            txtHoLot.ReadOnly = false;
            txtTen.ReadOnly = false;

            dtpNgaySinh.Value = DateTime.Today;

            grpPhai.Enabled = true;
            rdoNam.Checked = true;

            cboLop.Enabled = false;
            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;
            dgvSinhVien.Enabled = false;
            txtMSSV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            txtMSSV.Focus();
        }

        void dieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtHoLot.ReadOnly = false;
            txtTen.ReadOnly = false;

            grpPhai.Enabled = true;

            cboLop.Enabled = true;
            cboQuyenSD.Enabled = true;
            dgvSinhVien.Enabled = false;

            txtHoLot.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSua = 1;
            ViTriLop = cboLop.SelectedIndex;
            dieuKhienKhiThem();

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ThemSua = 2;
            ViTriLop = cboLop.SelectedIndex;
            dieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên!");
                txtMSSV.Focus();
                return;
            }
            if (txtHoLot.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ lót!");
                txtHoLot.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên!");
                txtTen.Focus();
                return;
            }
            if ((ThemSua == 1) && (MyPublics.tonTaiKhoaChinh(
                txtMSSV.Text, "MSSV", "SinhVien")))
            {
                MessageBox.Show("Đã tồn tại sinh viên " + txtMSSV.Text);
                txtMSSV.Focus();
            }
            DateTime current = DateTime.Now;
            if (dtpNgaySinh.Value > current)
            {
                MessageBox.Show("Lỗi chọn ngày sinh! ");
            }

            else
                thucThiLuu();

        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            ThemSua = 0;
            DieuKhienKhiBinhThuong();
            ganDuLieu();
            cboLop.SelectedIndex = ViTriLop;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.tonTaiKhoaChinh(txtMSSV.Text, "MSSV", "KetQuaHocTap"))
                MessageBox.Show("Phải xóa kết quả học tập của sinh viên trước !");
            else
            {

                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (blnDongY == DialogResult.Yes)
                {
                    string strDelete = "Delete SinhVien Where MSSV = @MSSV";
                    if (MyPublics.conMyConnection.State ==
                    ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", txtMSSV.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    int curRow = dgvSinhVien.CurrentRow.Index;
                    dvSinhVien.Delete(curRow);
                    DieuKhienKhiBinhThuong();
                    ganDuLieu();
                }
            }
        }

    }
}
