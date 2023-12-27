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
    public partial class frmSinhVien : Form
    {
        DataTable dtSinhVien = new DataTable("SinhVien");
        DataTable dtLop = new DataTable("Lop");
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        bool blnThem = false;

        private frmMain fMain;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        public frmSinhVien(frmMain frmMain):this()
        {
            frmMain = fMain;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            string strSelect = "Select * From SinhVien";
            MyPublics.OpenData(strSelect, dtSinhVien);

            strSelect = "Select MSLop, TenLop From Lop";
            MyPublics.OpenData(strSelect, dtLop);
            cboLop.DataSource = dtLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MSLop";
            cboLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLop.AutoCompleteSource = AutoCompleteSource.ListItems;

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
            dgvSinhVien.DataSource = dtSinhVien;
            dgvSinhVien.Width = 690;

            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.Columns[0].Width = 85;
            dgvSinhVien.Columns[0].HeaderText = "Mã số";
            dgvSinhVien.Columns[1].Width = 140;
            dgvSinhVien.Columns[1].HeaderText = "Họ lót";
            dgvSinhVien.Columns[2].Width = 60;
            dgvSinhVien.Columns[2].HeaderText = "Tên";
            dgvSinhVien.Columns[3].Width = 50;
            dgvSinhVien.Columns[3].HeaderText = "Phái";
            dgvSinhVien.Columns[4].Width = 100;
            dgvSinhVien.Columns[4].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns[5].Width = 90;
            dgvSinhVien.Columns[5].HeaderText = "Lớp";
            dgvSinhVien.Columns[6].Visible = false;
            dgvSinhVien.Columns[7].Width = 100;
            dgvSinhVien.Columns[7].HeaderText = "Quyền SD";
            dgvSinhVien.EditMode =
            DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();

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
            txtMSSV.ReadOnly = true;
            txtMSSV.BackColor = Color.White;
            txtHoLot.ReadOnly = true;
            txtHoLot.BackColor = Color.White;
            txtTen.ReadOnly = true;
            txtTen.BackColor = Color.White;
            grpPhai.Enabled = false;
            cboLop.Enabled = false;
            cboQuyenSD.Enabled = false;
            dgvSinhVien.Enabled = true;

        }

        void GanDuLieu()
        {
             if (dtSinhVien.Rows.Count > 0)
             {
                 txtMSSV.Text = dgvSinhVien[0,dgvSinhVien.CurrentRow.Index].Value.ToString();
                 txtHoLot.Text = dgvSinhVien[1,dgvSinhVien.CurrentRow.Index].Value.ToString();
                 txtTen.Text = dgvSinhVien[2,dgvSinhVien.CurrentRow.Index].Value.ToString();
                 if (dgvSinhVien[3, dgvSinhVien.CurrentRow.Index].Value.ToString() == "Nam")
                     rdoNam.Checked = true;
                 else
                     rdoNu.Checked = true;
                 dtpNgaySinh.Value = DateTime.Parse(dgvSinhVien[4,dgvSinhVien.CurrentRow.Index].Value.ToString());
                 cboLop.SelectedValue = dgvSinhVien[5,dgvSinhVien.CurrentRow.Index].Value.ToString();
                 cboQuyenSD.SelectedValue = dgvSinhVien[7,dgvSinhVien.CurrentRow.Index].Value.ToString();
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
                 cboLop.SelectedIndex = -1;
                 cboQuyenSD.SelectedIndex = -1;

             }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        void DieuKhienKhiThem()
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
            cboLop.Enabled = true;
            cboLop.SelectedIndex = 0;
            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;
            dgvSinhVien.Enabled = false;
            txtMSSV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            txtMSSV.Focus();
        }
        void DieuKhienKhiChinhSua()
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
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        void ThucThiLuu()
        {
            string strSql, strPhai = "Nam", strLop, strMatKhau = "", strQuyenSD;
            if (blnThem)
                strSql = "insert into SinhVien values(@MSSV, @HoLot, @Ten, @Phai, @NgaySinh, @MSLop, @MatKhau, @QuyenSD)";            else
                strSql = "update SinhVien set HoLot = @HoLot, Ten = @Ten, Phai = @Phai, NgaySinh = @NgaySinh, MSLop = @MSLop, QuyenSD = @QuyenSD Where MSSV = @MSSV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql,
            MyPublics.conMyConnection);

            cmdCommand.Parameters.AddWithValue("@MSSV",txtMSSV.Text);
            cmdCommand.Parameters.AddWithValue("@HoLot",txtHoLot.Text);
            cmdCommand.Parameters.AddWithValue("@Ten", txtTen.Text);
            if (rdoNu.Checked)
                strPhai = "Nữ";
            cmdCommand.Parameters.AddWithValue("@Phai", strPhai);
            cmdCommand.Parameters.AddWithValue("@NgaySinh",dtpNgaySinh.Value);
            strLop = cboLop.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MSLop", strLop);

            if (blnThem)
            {
                strMatKhau = MyPublics.MaHoaPassword(txtMSSV.Text);
                cmdCommand.Parameters.AddWithValue("@MatKhau",strMatKhau);
            }
            strQuyenSD = cboQuyenSD.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QuyenSD", strQuyenSD);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                 dtSinhVien.Rows.Add(txtMSSV.Text, txtHoLot.Text,txtTen.Text, strPhai, dtpNgaySinh.Value,strLop, strMatKhau, strQuyenSD);
                 GanDuLieu();
                 blnThem = false;
                 }
             else
             {
                 int curRow = dgvSinhVien.CurrentRow.Index;
                 dtSinhVien.Rows[curRow][1] = txtHoLot.Text;
                 dtSinhVien.Rows[curRow][2] = txtTen.Text;

                 dtSinhVien.Rows[curRow][3] = strPhai;
                 dtSinhVien.Rows[curRow][4] = dtpNgaySinh.Value;
                 dtSinhVien.Rows[curRow][5] = strLop;
                 dtSinhVien.Rows[curRow][7] = strQuyenSD;
             }
             DieuKhienKhiBinhThuong();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã số sinh viên!");
                txtMSSV.Focus();
                return;
            }
            if (txtHoLot.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập họ lót!");
                txtHoLot.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên!");
                txtTen.Focus();
                return;
            }
            if (cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Lỗi chưa chọn lớp!");
                cboLop.Focus();
                return;
            }

            if (blnThem && MyPublics.tonTaiKhoaChinh(txtMSSV.Text, "MSSV", "SinhVien"))
            {
                MessageBox.Show("Mã số sinh viên này đã có rồi!");
                txtMSSV.Focus();
            }
            else
                ThucThiLuu();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.tonTaiKhoaChinh(txtMSSV.Text, "MSSV", "KetQuaHocTap"))
                MessageBox.Show("Phải xóa kết quả học tập của sinh viên trước !");
            else
            {
                 DialogResult blnDongY;
                 blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?","Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                string strDelete = "Delete SinhVien Where MSSV = @MSSV";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    int curRow = dgvSinhVien.CurrentRow.Index;
                    dtSinhVien.Rows.RemoveAt(curRow);
                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
