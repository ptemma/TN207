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
    public partial class frmNgheNghiep : Form
    {
        DataTable dtNgheNghiep = new DataTable("NgheNghiep");
        bool btnThemClicked = false;
        private bool blnThem;
        public frmNgheNghiep()
        {
            InitializeComponent();
        }
        private void GanDuLieu()
        {
            if (dtNgheNghiep.Rows.Count > 0)
            {
                txtMaNgheNghiep.Text = dgvNgheNghiep[0,
                    dgvNgheNghiep.CurrentRow.Index].Value.ToString();
                txtTenNgheNghiep.Text = dgvNgheNghiep[1,
                    dgvNgheNghiep.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaNgheNghiep.Clear();
                txtTenNgheNghiep.Clear();
            }
        }
        private void dgvNgheNghiep_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtMaNgheNghiep.ReadOnly = true;
            txtTenNgheNghiep.BackColor = Color.White;
            txtTenNgheNghiep.ReadOnly = true;
            txtTenNgheNghiep.BackColor = Color.White;
        }
        private void frmNgheNghiep_Load(object sender, EventArgs e)
        {
            string strSelect = "select MaNgheNghiep, TenNgheNghiep from NgheNghiep";
            MyPublics.OpenData(strSelect, dtNgheNghiep);
            txtMaNgheNghiep.MaxLength = 12;
            txtTenNgheNghiep.MaxLength = 40;
            dgvNgheNghiep.DataSource = dtNgheNghiep;
            GanDuLieu();
            dgvNgheNghiep.Width = 585;
            dgvNgheNghiep.Columns[0].Width = 100;
            dgvNgheNghiep.Columns[0].HeaderText = "Mã Nghề Nghiệp";
            dgvNgheNghiep.Columns[1].Width = 220;
            dgvNgheNghiep.Columns[1].HeaderText = "Tên Nghề Nghiệp";
            dgvNgheNghiep.AllowUserToAddRows = false;
            dgvNgheNghiep.AllowUserToDeleteRows = false;
            dgvNgheNghiep.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            txtMaNgheNghiep.ReadOnly = false;
            txtTenNgheNghiep.ReadOnly = false;
            txtMaNgheNghiep.Clear();
            txtTenNgheNghiep.Clear();
            dgvNgheNghiep.Enabled = false;
            txtMaNgheNghiep.Focus();
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaNgheNghiep.ReadOnly = true;
            txtTenNgheNghiep.ReadOnly = false;
            dgvNgheNghiep.Enabled = false;
            txtMaNgheNghiep.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LuuLopMoi()
        {
            string strThemLop = "Insert Into NgheNghiep Values (@MaNgheNghiep, @TenNgheNghiep)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strThemLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaNgheNghiep", txtMaNgheNghiep.Text);
            cmdCommand.Parameters.AddWithValue("@TenNgheNghiep", txtTenNgheNghiep.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            dtNgheNghiep.Rows.Add(txtMaNgheNghiep.Text, txtTenNgheNghiep.Text);
            dgvNgheNghiep.CurrentCell = dgvNgheNghiep[0, dgvNgheNghiep.Rows.Count - 1];
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

            string strCapNhatLop = "Update NgheNghiep Set MaNgheNghiep = @MaNgheNghiep" +
                ", TenNgheNghiep = @TenNgheNghiep";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strCapNhatLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaNgheNghiep", txtMaNgheNghiep.Text);
            cmdCommand.Parameters.AddWithValue("@TenNgheNghiep", txtTenNgheNghiep.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            int curRow = dgvNgheNghiep.CurrentRow.Index;
            dtNgheNghiep.Rows[curRow][1] = txtMaNgheNghiep.Text;
            dtNgheNghiep.Rows[curRow][2] = txtTenNgheNghiep.Text;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNgheNghiep.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã nghề nghiệp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNgheNghiep.Focus();
                return;
            }

            if (txtTenNgheNghiep.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên nghề nghiệp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNgheNghiep.Focus();
                return;
            }

            if (blnThem)
                if (MyPublics.TonTaiKhoaChinh(txtMaNgheNghiep.Text, "MaNgheNghiep", "NgheNghiep"))
                {
                    MessageBox.Show("Mã số nghề nghiệp này đã có rồi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNgheNghiep.Focus();
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
            if (MyPublics.TonTaiKhoaChinh(txtMaNgheNghiep.Text, "MaNgheNghiep", "ThanhVien"))
            {
                MessageBox.Show("Có thành viên thuộc nghề nghiệp này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (blnDongY == DialogResult.Yes)
                {
                    string strXoa = "Delete NgheNghiep Where MaNgheNghiep = @MaNgheNghiep";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strXoa, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaNgheNghiep", txtMaNgheNghiep.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtNgheNghiep.Rows.RemoveAt(dgvNgheNghiep.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }
    }
}
