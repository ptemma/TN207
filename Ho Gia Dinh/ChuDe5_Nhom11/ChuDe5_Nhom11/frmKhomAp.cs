using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ChuDe5_Nhom11
{


    public partial class frmKhomAp : Form
    {

        DataTable dtKhomAp = new DataTable("KhomAp");
        //DataTable dtHoGiaDinh = new DataTable("")

        bool bltThem = false;
        bool blnThemClicked = false;
        private bool blnThem;

        public frmKhomAp()
        {
            InitializeComponent();
        }

        private void dgvKhmAp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void frmKhomAp_Load(object sender, EventArgs e)
        {
            string strSelect = "select MaAp, TenAp, SoTo, DacDiem from KhomAp ";
            MyPublics.OpenData(strSelect, dtKhomAp);
            txtMaAp.MaxLength = 12;
            txtTenAp.MaxLength = 40;
            txtSoTo.MaxLength = 12;
            dgvKhmAp.DataSource = dtKhomAp;
            GanDuLieu();
            dgvKhmAp.Width = 455;
            dgvKhmAp.Columns[0].Width = 40;
            dgvKhmAp.Columns[0].HeaderText = "Mã Ấp";
            dgvKhmAp.Columns[1].Width = 150;
            dgvKhmAp.Columns[1].HeaderText = "Tên Ấp";
            dgvKhmAp.Columns[2].Width = 70;
            dgvKhmAp.Columns[2].HeaderText = "Số Tổ";
            dgvKhmAp.Columns[3].Width = 150;
            dgvKhmAp.Columns[3].HeaderText = "Đặc Điểm";
            dgvKhmAp.AllowUserToAddRows = false;
            dgvKhmAp.AllowUserToDeleteRows = false;
            dgvKhmAp.EditMode = DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong(); 
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
            txtMaAp.ReadOnly = true;
            txtMaAp.BackColor = Color.White;
            txtTenAp.ReadOnly = true;
            txtTenAp.BackColor = Color.White;
            txtDacDiem.ReadOnly = false;
            txtDacDiem.BackColor = Color.White;
            txtSoTo.ReadOnly = false;
            txtSoTo.BackColor = Color.White;
            dgvKhmAp.Enabled = true;
        }
        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaAp.ReadOnly = false;
            txtTenAp.ReadOnly = false;
            txtDacDiem.ReadOnly = false;
            txtSoTo.ReadOnly = false;
            txtMaAp.Clear();
            txtTenAp.Clear();
            txtSoTo.Clear();
            txtDacDiem.Clear();
            dgvKhmAp.Enabled = false;
            txtMaAp.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtMaAp.ReadOnly = true;
            txtTenAp.ReadOnly = false;
            txtSoTo.ReadOnly = false;
            txtDacDiem.ReadOnly = false;
            dgvKhmAp.Enabled = false;
            txtTenAp.Focus();
        }

        private void GanDuLieu()
        {
            if (dtKhomAp.Rows.Count > 0)
            {
                txtMaAp.Text = dgvKhmAp[0,
                    dgvKhmAp.CurrentRow.Index].Value.ToString();
                txtTenAp.Text = dgvKhmAp[1,
                    dgvKhmAp.CurrentRow.Index].Value.ToString();
                txtSoTo.Text = dgvKhmAp[2,
                      dgvKhmAp.CurrentRow.Index].Value.ToString();
                txtDacDiem.Text = dgvKhmAp[3,
                    dgvKhmAp.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaAp.Clear();
                txtTenAp.Clear();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LuuLopMoi()
        {
            string strThemLop = "Insert Into KhomAp Values (@MaAp, @TenAp, @SoTo, @DacDiem)";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strThemLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaAp", txtMaAp.Text);
            cmdCommand.Parameters.AddWithValue("@TenAp", txtTenAp.Text);
            cmdCommand.Parameters.AddWithValue("@SoTo", txtSoTo.Text);
            cmdCommand.Parameters.AddWithValue("@DacDiem", txtDacDiem.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            dtKhomAp.Rows.Add(txtMaAp.Text, txtTenAp.Text, txtSoTo.Text, txtDacDiem.Text);
            dgvKhmAp.CurrentCell = dgvKhmAp[0, dgvKhmAp.Rows.Count - 1];
            GanDuLieu();
            blnThem = false;
            DieuKhienKhiBinhThuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThemClicked = true;
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }
        void CapNhatLop()
        {
            
            string strCapNhatLop = "Update KhomAp Set TenAp = @TenAp" +
                ", SoTo = @SoTo ,DacDiem = @DacDiem  Where MaAp = @MaAp";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strCapNhatLop,
                MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MaAp", txtMaAp.Text);
            cmdCommand.Parameters.AddWithValue("@TenAp", txtTenAp.Text);
            cmdCommand.Parameters.AddWithValue("@SoTo", txtSoTo.Text);
            cmdCommand.Parameters.AddWithValue("@DacDiem", txtDacDiem.Text);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            int curRow = dgvKhmAp.CurrentRow.Index;
            dtKhomAp.Rows[curRow][1] = txtTenAp.Text;
            dtKhomAp.Rows[curRow][2] = txtSoTo.Text;
            dtKhomAp.Rows[curRow][3] = txtDacDiem.Text;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaAp.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mà số ấp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaAp.Focus();
                return;
            }

            if (txtTenAp.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên ấp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenAp.Focus();
                return;
            }
            if (txtSoTo.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập số tổ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTo.Focus();
                return;
            }
            if (txtDacDiem.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập đặc điểm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDacDiem.Focus();
                return;
            }

            if (blnThem)
                if (MyPublics.TonTaiKhoaChinh(txtMaAp.Text, "MaAp", "KhomAp"))
                {
                    MessageBox.Show("Mã số ấp này đã có rồi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaAp.Focus();
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
            if (MyPublics.TonTaiKhoaChinh(txtMaAp.Text, "@MaAp", "HoGiaDinh"))
            {
                MessageBox.Show("Có hộ gia đình thuộc ấp này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (blnDongY == DialogResult.Yes)
                {
                    string strXoa = "Delete KhomAp Where MaAp = @MaAp";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strXoa, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaAp", txtMaAp.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtKhomAp.Rows.RemoveAt(dgvKhmAp.CurrentRow.Index);
                    GanDuLieu();
                }
            }
        }

    }
}
