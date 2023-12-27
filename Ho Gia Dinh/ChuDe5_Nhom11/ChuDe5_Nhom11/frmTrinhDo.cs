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
    public partial class frmTrinhDo : Form
    {
        DataTable dtTrinhDo = new DataTable("TrinhDo");
        bool btnThemClicked = false;
        private bool blnThem;
        public frmTrinhDo()
        {
            InitializeComponent();
        }

        private void GanDuLieu()
        {
            if (dtTrinhDo.Rows.Count > 0)
            {
                txtMaTrinhDo.Text = dgvTrinhDo[0,
                    dgvTrinhDo.CurrentRow.Index].Value.ToString();
                txtDienGiai.Text = dgvTrinhDo[1,
                    dgvTrinhDo.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaTrinhDo.Clear();
                txtDienGiai.Clear();
            }
        }

        private void dgvTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtMaTrinhDo.ReadOnly = true;
            txtMaTrinhDo.BackColor = Color.White;
            txtDienGiai.ReadOnly = true;
            txtDienGiai.BackColor = Color.White;
        }

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            string strSelect = "select MaTrinhDo, DienGiai from TrinhDo";
            MyPublics.OpenData(strSelect, dtTrinhDo);
            txtMaTrinhDo.MaxLength = 12;
            txtDienGiai.MaxLength = 40;
            dgvTrinhDo.DataSource = dtTrinhDo;
            GanDuLieu();
            dgvTrinhDo.Width = 585;
            dgvTrinhDo.Columns[0].Width = 100;
            dgvTrinhDo.Columns[0].HeaderText = "Mã Trình Độ";
            dgvTrinhDo.Columns[1].Width = 220;
            dgvTrinhDo.Columns[1].HeaderText = "Diễn Giải";
            dgvTrinhDo.AllowUserToAddRows = false;
            dgvTrinhDo.AllowUserToDeleteRows = false;
            dgvTrinhDo.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            txtMaTrinhDo.ReadOnly = false;
            txtDienGiai.ReadOnly = false;
            txtMaTrinhDo.Clear();
            txtDienGiai.Clear();
            dgvTrinhDo.Enabled = false;
            txtMaTrinhDo.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaTrinhDo.ReadOnly = true;
            txtDienGiai.ReadOnly = false;
            dgvTrinhDo.Enabled = false;
            txtDienGiai.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LuuLopMoi()
        {
            string strThemLop = "Insert Into TrinhDo Values (@MaTrinhDo, @DienGiai)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strThemLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaTrinhDo", txtMaTrinhDo.Text);
            cmdCommand.Parameters.AddWithValue("@DienGiai", txtDienGiai.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            dtTrinhDo.Rows.Add(txtMaTrinhDo.Text, txtDienGiai.Text);
            dgvTrinhDo.CurrentCell = dgvTrinhDo[0, dgvTrinhDo.Rows.Count - 1];
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

            string strCapNhatLop = "Update TrinhDo Set DienGiai = @DienGiai where MaTrinhDo = @MaTrinhDo";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strCapNhatLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaTrinhDo",txtMaTrinhDo.Text);
            cmdCommand.Parameters.AddWithValue("@DienGiai", txtDienGiai.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            int curRow = dgvTrinhDo.CurrentRow.Index;
            dtTrinhDo.Rows[curRow][1] = txtMaTrinhDo.Text;
            dtTrinhDo.Rows[curRow][2] = txtDienGiai.Text;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }


        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaTrinhDo.Text, "MaTrinhDo", "ThanhVien"))
            {
                MessageBox.Show("Có mã trình độ thuộc lớp này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (blnDongY == DialogResult.Yes)
                {
                    string strXoa = "Delete TrinhDo Where MaTrinhDo = @MaTrinhDo";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strXoa, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaTrinhDo", txtMaTrinhDo.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtTrinhDo.Rows.RemoveAt(dgvTrinhDo.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtMaTrinhDo.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã trình độ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTrinhDo.Focus();
                return;
            }

            if (txtDienGiai.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập diễn giải!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienGiai.Focus();
                return;
            }

            if (blnThem)
                if (MyPublics.TonTaiKhoaChinh(txtMaTrinhDo.Text, "MaTrinhDo", "TrinhDo"))
                {
                    MessageBox.Show("Mã trình độ này đã có rồi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaTrinhDo.Focus();
                }
                else LuuLopMoi();
            else CapNhatLop();
        }
    }
}
