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
    public partial class frmHoGiaDinhTheoKhomAp : Form
    {
        DataTable dtHoGiaDinh = new DataTable("HoGiaDinh");
        DataView dvHoGiaDinh = new DataView();
        DataTable dtMaAp = new DataTable("MaAp");
        bool blnThem = false;
        bool btnThemClicked = false;
        int ViTriTT, ThemSua = 0;
        public frmHoGiaDinhTheoKhomAp()
        {
            InitializeComponent();
        }
        void DieuKhienKhiBinhThuong()
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
            txtMaHo.ReadOnly = true;
            txtMaHo.BackColor = Color.White;
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.White;
            dtkNgayLap.Enabled = false;
            dtkNgayLap.BackColor = Color.White;
            cbbMaAp.Enabled = true;
          //  cbbMaAp.BackColor = Color.White;
            cbbTenAp.Enabled = false;
          //  cbbTenAp.BackColor = Color.White;
            dgvHoGiaDinh.Enabled = true;
        }
        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaHo.Clear();
            txtMaHo.ReadOnly = true;
            txtMaHo.BackColor = Color.White;
            int maxMaHo = 0;
            if (dtHoGiaDinh.Rows.Count > 0)
            {// Lấy giá trị mã hộ lớn nhất trong DataTable
                maxMaHo = dtHoGiaDinh.AsEnumerable().Max(row => row.Field<int>("MaHo"));
            }
            // Hiển thị mã hộ tăng lên 1 đơn vị so với giá trị lớn nhất hiện tại
            txtMaHo.Text = (maxMaHo + 1).ToString();
            txtDiaChi.ReadOnly = false;
            dtkNgayLap.Value = DateTime.Now;
            dtkNgayLap.Enabled = true;
            txtDiaChi.Clear();
            cbbMaAp.Enabled = false;
            cbbMaAp.BackColor = Color.White;
            cbbTenAp.Enabled = false;
            cbbTenAp.BackColor = Color.White;
            dgvHoGiaDinh.Enabled = false;
            txtDiaChi.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtDiaChi.ReadOnly = false;
            dtkNgayLap.Enabled = true;
            cbbMaAp.Enabled = false;
            cbbMaAp.BackColor = Color.White;
            cbbTenAp.Enabled = false;
            cbbTenAp.BackColor = Color.White;
            txtDiaChi.Focus();
        }
        void GanDuLieu()
        {
            if (dtHoGiaDinh.Rows.Count > 0 && dgvHoGiaDinh.CurrentRow != null)
            {
                txtMaHo.Text = dgvHoGiaDinh[0, dgvHoGiaDinh.CurrentRow.Index].Value.ToString();
                txtDiaChi.Text = dgvHoGiaDinh[1, dgvHoGiaDinh.CurrentRow.Index].Value.ToString();

                if (dgvHoGiaDinh[2, dgvHoGiaDinh.CurrentRow.Index].Value.ToString() == "")
                {
                    dtkNgayLap.Value = DateTime.Parse("2/2/2222");
                }
                else
                {
                    dtkNgayLap.Value = DateTime.Parse(dgvHoGiaDinh[2, dgvHoGiaDinh.CurrentRow.Index].Value.ToString());
                }

                // cbbMaAp.SelectedIndex = cbbMaAp.FindString(dgvHoGiaDinh[3, dgvHoGiaDinh.CurrentRow.Index].Value.ToString());
                cbbTenAp.SelectedIndex = cbbTenAp.FindString(dgvHoGiaDinh[3, dgvHoGiaDinh.CurrentRow.Index].Value.ToString());
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaHo.Clear();
                txtDiaChi.Clear();
                dtkNgayLap.Value = DateTime.Today;
            }
        }
        void LuuLopMoi()
        {
            string strMaAp;
            cbbMaAp.ValueMember = "MaAp";
            string strThemLop = "Insert Into HoGiaDinh (DiaChiNha, NgayLapHo, MaAp) Values (@DiaChiNha , @NgayLapHo, @MaAp) ";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strThemLop,
                MyPublics.conMyConnection);
            strMaAp = cbbMaAp.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@DiaChiNha", txtDiaChi.Text);
            cmdCommand.Parameters.AddWithValue("@NgayLapHo", dtkNgayLap.Value);
            cmdCommand.Parameters.AddWithValue("@MaAp", strMaAp);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            dtHoGiaDinh.Rows.Add(dtHoGiaDinh.Rows.Count + 1, txtDiaChi.Text, dtkNgayLap.Value, cbbTenAp.SelectedValue, strMaAp);
            GanDuLieu();
            blnThem = false;
            DieuKhienKhiBinhThuong();
        }
        void CapNhatLop()
        {
            //   int intMaHo = int.Parse(txtMaHo.Text);
            int intMaHo = int.Parse(dgvHoGiaDinh.CurrentRow.Cells["MaHo"].Value.ToString());
            cbbMaAp.ValueMember = "MaAp";
            string strCapNhatLop = "Update HoGiaDinh Set DiaChiNha = @DiaChiNha, NgayLapHo= @NgayLapHo , " +
                " MaAp = @MaAp Where MaHo = @MaHo";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strCapNhatLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaHo", intMaHo);
            cmdCommand.Parameters.AddWithValue("@DiaChiNha", txtDiaChi.Text);
            cmdCommand.Parameters.AddWithValue("@NgayLapHo", dtkNgayLap.Value);
            cmdCommand.Parameters.AddWithValue("@MaAp", cbbMaAp.SelectedValue);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            int curRow = dgvHoGiaDinh.CurrentRow.Index;
            dtHoGiaDinh.Rows[curRow][1] = txtDiaChi.Text;
            dtHoGiaDinh.Rows[curRow][2] = dtkNgayLap.Value;
            dtHoGiaDinh.Rows[curRow][3] = cbbTenAp.SelectedValue;
            dtHoGiaDinh.Rows[curRow][4] = cbbMaAp.SelectedValue;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }
        private void dgvHoGiaDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThemClicked = true;
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int intMaHo = int.Parse(txtMaHo.Text);
            int intMaHo = int.Parse(dgvHoGiaDinh.CurrentRow.Cells["MaHo"].Value.ToString());
            if (MyPublics.TonTaiKhoaChinh(txtMaHo.Text, "MaHo", "ThanhVien"))
            {
                MessageBox.Show("Có Thành viên thuộc hộ gia đình này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (blnDongY == DialogResult.Yes)
                {
                    string strXoa = "Delete HoGiaDinh Where MaHo = @MaHo";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strXoa, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaHo", intMaHo);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtHoGiaDinh.Rows.RemoveAt(dgvHoGiaDinh.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập địa chỉ nhà!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }


            if (blnThem)
                if (MyPublics.TonTaiKhoaChinh(txtMaHo.Text, "MaHo", "HoGiaDinh"))
                {
                    MessageBox.Show("Mã số hộ này đã có rồi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHo.Focus();
                }
                else LuuLopMoi();
            else CapNhatLop();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoGiaDinhTheoKhomAp_Load(object sender, EventArgs e)
        {
            string strSelect1 = "Select MaAp, TenAp From KhomAp";
            MyPublics.OpenData(strSelect1, dtMaAp);
            cbbMaAp.DataSource = dtMaAp;
            cbbMaAp.DisplayMember = "MaAp";
            cbbMaAp.ValueMember = "MaAp";
            cbbTenAp.DataSource = dtMaAp;
            cbbTenAp.DisplayMember = "TenAp";
            cbbTenAp.ValueMember = "TenAp";
            cbbMaAp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaAp.AutoCompleteSource = AutoCompleteSource.ListItems;
            string strSelect = "Select a.MaHo, a.DiaChiNha, a.NgayLapHo, b.TenAp, a.MaAp " +
               "From HoGiaDinh a, KhomAp b " +
               "Where a.MaAp = b.MaAp";
            MyPublics.OpenData(strSelect, dtHoGiaDinh);
            dvHoGiaDinh.Table = dtHoGiaDinh;
            LoadDataGrid(cbbMaAp.SelectedValue.ToString());
            dgvHoGiaDinh.DataSource = dtHoGiaDinh;
           // dgvHoGiaDinh.DataSource = dvHoGiaDinh;
            dgvHoGiaDinh.Width = 600;
            dgvHoGiaDinh.Columns[0].Width = 90;
            dgvHoGiaDinh.Columns[0].HeaderText = "Mã hộ";
            dgvHoGiaDinh.Columns[1].Width = 160;
            dgvHoGiaDinh.Columns[1].HeaderText = "Địa chỉ";
            dgvHoGiaDinh.Columns[2].Width = 130;
            dgvHoGiaDinh.Columns[2].HeaderText = "Ngày Lập";
            dgvHoGiaDinh.Columns[3].Width = 175;
            dgvHoGiaDinh.Columns[3].HeaderText = "Tên Ấp";
            dgvHoGiaDinh.Columns[4].Visible = false;
            dgvHoGiaDinh.AllowUserToAddRows = false;
            dgvHoGiaDinh.AllowUserToDeleteRows = false;
            dgvHoGiaDinh.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }
        private void LoadDataGrid(string maAp)
        {
            dvHoGiaDinh.RowFilter = "MaAP like '" + maAp + "'";
            dgvHoGiaDinh.DataSource = dvHoGiaDinh;
            GanDuLieu();
            if (MyPublics.strQuyenSD != "Admin" && MyPublics.strMaAp == maAp)
            {
                btnChinhSua.Enabled = false;
                btnThem.Enabled = false;
            }
        }
        private void cbbMaAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbbMaAp.SelectedIndex != -1) && (ThemSua == 0))
            {
                LoadDataGrid(cbbMaAp.SelectedValue.ToString());
                if (MyPublics.strQuyenSD != "Admin" && MyPublics.strMaAp == cbbMaAp.SelectedValue.ToString())
                {
                    btnChinhSua.Enabled = false;
                    btnThem.Enabled = false;
                }

            }
        }
    }
}
