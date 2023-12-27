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
    public partial class frmDoiTuong : Form
    {
        DataTable dtDoiTuong = new DataTable("DoiTuong");
        bool btnThemClicked = false;
        private bool blnThem;
        public frmDoiTuong()
        {
            InitializeComponent();
        }
        private void GanDuLieu()
        {
            if (dtDoiTuong.Rows.Count > 0)
            {
                txtMaDoiTuong.Text = dgvDoiTuong[0,
                    dgvDoiTuong.CurrentRow.Index].Value.ToString();
                txtTenDoiTuong.Text = dgvDoiTuong[1,
                    dgvDoiTuong.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaDoiTuong.Clear();
                txtTenDoiTuong.Clear();
            }
        }


        private void dgvDoiTuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void DieuKhienKhiBinhThuong()
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
            txtMaDoiTuong.ReadOnly = true;
            txtMaDoiTuong.BackColor = Color.White;
            txtTenDoiTuong.ReadOnly = true;
            txtTenDoiTuong.BackColor = Color.White;
        }
        private void frmDoiTuong_Load(object sender, EventArgs e)
        {
            string strSelect = "select MaDoiTuong, TenDoiTuong from DoiTuong";
            MyPublics.OpenData(strSelect, dtDoiTuong);
            txtMaDoiTuong.MaxLength = 12;
            txtTenDoiTuong.MaxLength = 40;
            dgvDoiTuong.DataSource = dtDoiTuong;
            GanDuLieu();
            dgvDoiTuong.Width = 373;
            dgvDoiTuong.Columns[0].Width = 100;
            dgvDoiTuong.Columns[0].HeaderText = "Mã Đối Tượng";
            dgvDoiTuong.Columns[1].Width = 220;
            dgvDoiTuong.Columns[1].HeaderText = "Tên Đối Tượng";
            dgvDoiTuong.AllowUserToAddRows = false;
            dgvDoiTuong.AllowUserToDeleteRows = false;
            dgvDoiTuong.EditMode = DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong();
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaDoiTuong.ReadOnly = false;
            txtTenDoiTuong.ReadOnly = false;
            txtMaDoiTuong.Clear();
            txtTenDoiTuong.Clear();
            dgvDoiTuong.Enabled = false;
            txtMaDoiTuong.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaDoiTuong.ReadOnly = true;
            txtTenDoiTuong.ReadOnly = false;
            dgvDoiTuong.Enabled = false;
            txtMaDoiTuong.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LuuLopMoi()
        {
            string strThemLop = "Insert Into DoiTuong Values (@MaDoiTuong, @TenDoiTuong)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strThemLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaDoiTuong", txtMaDoiTuong.Text);
            cmdCommand.Parameters.AddWithValue("@TenDoiTuong", txtTenDoiTuong.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            dtDoiTuong.Rows.Add(txtMaDoiTuong.Text, txtTenDoiTuong.Text);
            dgvDoiTuong.CurrentCell = dgvDoiTuong[0, dgvDoiTuong.Rows.Count - 1];
            GanDuLieu();
            blnThem = false;
            DieuKhienKhiBinhThuong();
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
        void CapNhatLop()
        {

            string strCapNhatLop = "Update DoiTuong Set  TenDoiTuong = @TenDoiTuong where MaDoiTuong = @MaDoiTuong ";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strCapNhatLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaDoiTuong", txtMaDoiTuong.Text);
            cmdCommand.Parameters.AddWithValue("@TenDoiTuong", txtTenDoiTuong.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            int curRow = dgvDoiTuong.CurrentRow.Index;
            dtDoiTuong.Rows[curRow][1] = txtMaDoiTuong.Text;
            dtDoiTuong.Rows[curRow][2] = txtTenDoiTuong.Text;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDoiTuong.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã đối tượng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDoiTuong.Focus();
                return;
            }

            if (txtTenDoiTuong.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên đối tượng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDoiTuong.Focus();
                return;
            }

            if (blnThem)
                if (MyPublics.TonTaiKhoaChinh(txtMaDoiTuong.Text, "MaDoiTuong", "DoiTuong"))
                {
                    MessageBox.Show("Mã đối tượng này đã có rồi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDoiTuong.Focus();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaDoiTuong.Text, "MaDoiTuong", "ThanhVien"))
            {
                MessageBox.Show("Có đối tượng thuộc lớp này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (blnDongY == DialogResult.Yes)
                {
                    string strXoa = "Delete DoiTuong Where MaDoiTuong = @MaDoiTuong";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strXoa, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaDoiTuong", txtMaDoiTuong.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtDoiTuong.Rows.RemoveAt(dgvDoiTuong.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }

    }
}
