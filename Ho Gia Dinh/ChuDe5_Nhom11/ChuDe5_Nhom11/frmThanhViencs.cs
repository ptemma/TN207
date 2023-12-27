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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChuDe5_Nhom11
{
    public partial class frmThanhViencs : Form
    {
        DataTable dtThanhVien = new DataTable("ThanhVien");
        DataTable dtMaHo = new DataTable("MaHo");
        DataView dvThanhVien = new DataView();

        DataTable dtMaNgheNghiep = new DataTable("MaNgheNghiep");
        DataTable dtMatrinhDo = new DataTable("MaTrinhDo");
        DataTable dtMaDoiTuong = new DataTable("MaDoiTuong");
        
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        int ThemSua = 0,viTriHo, viTriNghe, ViTriTrinhDo, ViTriDoiTuong;
        public frmThanhViencs()
        {
            InitializeComponent();
        }
        private void frmThanhViencs_Load(object sender, EventArgs e)
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
            if (MyPublics.strQuyenSD == "Admin")
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
            txtSTT.ReadOnly = true;
            txtSTT.BackColor = Color.White;
            txtHovaTen.ReadOnly = true;
            txtHovaTen.BackColor = Color.White;
            txtQuanHeVoiChuHo.ReadOnly = true;
            txtQuanHeVoiChuHo.BackColor = Color.White;

            grpGioiTinh.Enabled = false;
            cboMaHo.Enabled = true;
            cboQuyenSD.Enabled = false;
            cboNgheNghiep.Enabled = false;
            cboDoiTuong.Enabled = false;
            cboTrinhDo.Enabled = false;
            dgvThanhVien.Enabled = true;
        }

        void dieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtSTT.ReadOnly = false;
            txtHovaTen.ReadOnly = false;
            txtQuanHeVoiChuHo.ReadOnly = false;
            dtpNgaySinh.Value = DateTime.Today;
            grpGioiTinh.Enabled = true;
            rdoNam.Checked = true;
            cboMaHo.Enabled = false;

            cboNgheNghiep.Enabled = true;
            cboDoiTuong.Enabled = true;
            cboQuyenSD.Enabled = true;
            cboTrinhDo.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;
            dgvThanhVien.Enabled = false;
            txtSTT.Clear();
            txtHovaTen.Clear();
            txtQuanHeVoiChuHo.Clear();
        }

        void dieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtSTT.ReadOnly = true;
            txtHovaTen.ReadOnly = false;
            txtQuanHeVoiChuHo.ReadOnly = false;
            grpGioiTinh.Enabled = true;

            cboNgheNghiep.Enabled = true;
            cboDoiTuong.Enabled = true;
            cboTrinhDo.Enabled = true;
            cboQuyenSD.Enabled = true;
            dgvThanhVien.Enabled = false;
            txtSTT.Focus();


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

        private void cboMaHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboMaHo.SelectedIndex != -1) && (ThemSua == 0))
            {
                timKiemTheoMaHo(cboMaHo.SelectedValue.ToString());
                if (MyPublics.strQuyenSD != "Admin")
                {
                    btnChinhSua.Enabled = false;
                    btnThem.Enabled = false;
                }

            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ThemSua = 2;
            ViTriDoiTuong = cboDoiTuong.SelectedIndex;
            ViTriTrinhDo = cboTrinhDo.SelectedIndex;
            viTriNghe = cboNgheNghiep.SelectedIndex;
            viTriHo = cboMaHo.SelectedIndex;
            dieuKhienKhiChinhSua();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSua = 1;
            ViTriDoiTuong=cboDoiTuong.SelectedIndex;
            ViTriTrinhDo =cboTrinhDo.SelectedIndex;
            viTriNghe = cboNgheNghiep.SelectedIndex;
            viTriHo = cboMaHo.SelectedIndex;
            dieuKhienKhiThem();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHovaTen.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập họ và tên!");
                txtHovaTen.Focus();
                return;
            }
            if (txtQuanHeVoiChuHo.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập quan hệ với chủ hộ!");
                txtQuanHeVoiChuHo.Focus();
                return;
            }
            if (txtSTT.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập STT!");
                txtSTT.Focus();
                return;
            }
            
            if ((ThemSua == 1) && MyPublics.TonTaiKhoaChinh2(cboMaHo.Text, "MaHo", txtSTT.Text, "SttThanhVien", "ThanhVien"))
            {
                MessageBox.Show("Thành viên đã được thêm trước đó!");
                txtSTT.Focus();
            }
            else
                thucThiLuu();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            ThemSua = 0;
            dieuKhienKhiBinhThuong();
            ganDuLieu();
            ViTriDoiTuong = cboDoiTuong.SelectedIndex;
            ViTriTrinhDo = cboTrinhDo.SelectedIndex;
            viTriNghe = cboNgheNghiep.SelectedIndex;
            viTriHo = cboMaHo.SelectedIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                string strDelete = "Delete ThanhVien Where MaHo = @MaHo and SttThanhVien=@SttThanhVien";
                if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                    MyPublics.conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(
               strDelete, MyPublics.conMyConnection);
                cmdCommand.Parameters.AddWithValue("@MaHo", cboMaHo.Text);
                cmdCommand.Parameters.AddWithValue("@SttThanhVien", txtSTT.Text);
                // Lưu dữ liệu về Server
                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();
                // Cập nhật dữ liệu cho DataTable
                int curRow = dgvThanhVien.CurrentRow.Index;
                dvThanhVien.Delete(curRow);
                dieuKhienKhiBinhThuong();
                ganDuLieu();
            }
        }

        private void dgvThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        void thucThiLuu()
        {
            string strSql , strMaHo, strMaNgheNghiep, strMaTrinhDo, strMaDoiTuong, strMatKhau = "", strQuyenSD;
            bool sPhai;
            if(ThemSua == 1)
            {
                strSql = "Insert Into ThanhVien Values(@MaHo,@SttThanhVien, @HoTenThanhVien, @Phai, @NgaySinh, @QuanHeVoiChuHo,@MaNgheNghiep, @MaTrinhDo, @MaDoiTuong, @MatKhau,@QuyenSD)";
            }
            else
                strSql = "Update ThanhVien Set HoTenThanhVien=@HoTenThanhVien, Phai=@Phai, NgaySinh=@NgaySinh, QuanHeVoiChuHo=@QuanHeVoiChuHo,MaNgheNghiep=@MaNgheNghiep, MaTrinhDo=@MaTrinhDo, MaDoiTuong=@MaDoiTuong, QuyenSD=@QuyenSD where MaHo=@MaHo and SttThanhVien=@SttThanhVien";
            if (MyPublics.conMyConnection.State ==ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql,MyPublics.conMyConnection);
            strMaHo = cboMaHo.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaHo", strMaHo);
            cmdCommand.Parameters.AddWithValue("@SttThanhVien", txtSTT.Text);
            cmdCommand.Parameters.AddWithValue("@HoTenThanhVien",txtHovaTen.Text);
            if (rdoNam.Checked)
            {
                sPhai = true;
            }
            else sPhai = false;
            cmdCommand.Parameters.AddWithValue("@Phai", sPhai);
            cmdCommand.Parameters.AddWithValue("@NgaySinh",dtpNgaySinh.Value);
            cmdCommand.Parameters.AddWithValue("@QuanHeVoiChuHo", txtQuanHeVoiChuHo.Text);

            strMaNgheNghiep = cboNgheNghiep.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaNgheNghiep", strMaNgheNghiep);
            strMaTrinhDo = cboTrinhDo.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaTrinhDo", strMaTrinhDo);
            strMaDoiTuong = cboDoiTuong.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MaDoiTuong", strMaDoiTuong);

            if (ThemSua == 1)
            {
                strMatKhau = MyPublics.MaHoaPassword(txtSTT.Text);
                cmdCommand.Parameters.AddWithValue("@MatKhau",
               strMatKhau);
            }
            strQuyenSD = cboQuyenSD.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QuyenSD", strQuyenSD);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            ThemSua = 0;
            dtThanhVien.Clear();
            string strSelect = "select tv.MaHo, tv.SttThanhVien, tv.HoTenThanhVien, tv.Phai, tv.NgaySinh, tv.QuanHeVoiChuHo, tv.MaNgheNghiep, tv.MaTrinhDo, tv.MaDoiTuong, tv.MatKhau, tv.QuyenSD from HoGiaDinh hgd, ThanhVien tv, NgheNghiep nn, TrinhDo td, DoiTuong dt where hgd.MaHo= tv.MaHo and tv.MaNgheNghiep= nn.MaNgheNghiep and tv.MaTrinhDo = td.MaTrinhDo and tv.MaDoiTuong= dt.MaDoiTuong";
            MyPublics.OpenData(strSelect, dtThanhVien);

            if (cboMaHo.SelectedIndex == viTriHo)
            {
                dvThanhVien.Sort = "MaHo";
                int curRow = dvThanhVien.Find(cboMaHo.Text);
                dgvThanhVien.CurrentCell = dgvThanhVien[0, curRow];
            }
            else
            {
                cboMaHo.SelectedIndex = viTriHo;
                if (dvThanhVien.Count > 0)
                    dgvThanhVien.CurrentCell = dgvThanhVien[0, 0];
            }
            dieuKhienKhiBinhThuong();

        }

        void ganDuLieu()
        {
            if(dvThanhVien.Count > 0)
            {
                cboMaHo.SelectedIndex = cboMaHo.FindString(dgvThanhVien[0, dgvThanhVien.CurrentRow.Index].Value.ToString());

                txtSTT.Text = dgvThanhVien[1, dgvThanhVien.CurrentRow.Index].Value.ToString();
                txtHovaTen.Text = dgvThanhVien[2,dgvThanhVien.CurrentRow.Index].Value.ToString();
                string stringValue = dgvThanhVien[3, dgvThanhVien.CurrentRow.Index].Value.ToString();
                bool bitValue = Convert.ToBoolean(stringValue);
                if (bitValue)
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;

                dtpNgaySinh.Value = DateTime.Parse(dgvThanhVien[4,dgvThanhVien.CurrentRow.Index].Value.ToString());
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
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;

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
                if (MyPublics.strQuyenSD != "Admin" && MyPublics.strMaHo == MaHo)
                {
                    btnChinhSua.Enabled = false;
                    btnThem.Enabled = false;
                }
            }
            else
            {
                // Không làm gì nếu giá trị của ComboBox là 0
                // Đây là phần sẽ được thực hiện khi giá trị của ComboBox là 0
            }
        }
        private void TimKiemTheoMaNgheNghiep(string MaNgheNghiep)
        {
            if (cboNgheNghiep.SelectedItem != null && cboNgheNghiep.SelectedIndex != -1)
            {
                dvThanhVien.RowFilter = "MaNgheNghiep =" + MaNgheNghiep;
                dgvThanhVien.DataSource = dvThanhVien;
                ganDuLieu();
                if (MyPublics.strQuyenSD != "Admin" && MyPublics.strMangheNghiep == MaNgheNghiep)
                {
                    btnChinhSua.Enabled = false;
                    btnThem.Enabled = false;
                }
            }
            else
            {
                // Không làm gì nếu giá trị của ComboBox là 0
                // Đây là phần sẽ được thực hiện khi giá trị của ComboBox là 0
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ganDuLieu();
        }


    }


}
