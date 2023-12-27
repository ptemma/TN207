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
    public partial class frmLop_03 : Form
    {
        private frmMain fMain;

        DataTable dtLop = new DataTable("Lop");
        bool blnThem = false;

        public frmLop_03()
        {
            InitializeComponent();
        }

        public frmLop_03(frmMain frmMain):this()
        {
            frmMain = fMain;
        }

        private void frmLop_03_Load(object sender, EventArgs e)
        {
            String sqlSelect = "select * from Lop";
            MyPublics.openData(sqlSelect, dtLop);

            dgvLop.DataSource = dtLop;
            txtmsLop.MaxLength = 8;
            txttenLop.MaxLength = 40;
            ganDuLieu();

            dgvLop.Width = 440;
            dgvLop.Columns[0].Width = 100;
            dgvLop.Columns[1].Width = 160;
            dgvLop.Columns[2].Width = 130;
            dgvLop.Columns[0].HeaderText = "Mã lớp";
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[2].HeaderText = "Mã khóa học";

            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;

            dgvLop.EditMode = DataGridViewEditMode.EditProgrammatically;

            dieuKhienKhiBinhThuong();

        }

        void dieuKhienKhiBinhThuong(){
            if (MyPublics.strQuyenSD == "AdminKhoa")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            if (MyPublics.strQuyenSD == "AdminLop")
                if (txtmsLop.Text == MyPublics.strLop)
                    btnSua.Enabled = true;
                else
                    btnSua.Enabled = false;

            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            txtmsLop.ReadOnly = true;
            txtmsLop.BackColor = Color.White;
            txttenLop.ReadOnly = true;
            txttenLop.BackColor = Color.White;
            txtkhoaHoc.ReadOnly = true;
            txtkhoaHoc.BackColor = Color.White;
            dgvLop.Enabled = true;
        }

        void dieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txtmsLop.ReadOnly = false;
            txttenLop.ReadOnly = false;
            txtkhoaHoc.ReadOnly = false;
            txtmsLop.Clear();
            txttenLop.Clear();
            txtkhoaHoc.Clear();
            dgvLop.Enabled = false;
            txtmsLop.Focus();
        }

        void dieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            txttenLop.ReadOnly = false;
            txtkhoaHoc.ReadOnly = false;
            dgvLop.Enabled = false;
            txttenLop.Focus();
        }

        void ganDuLieu()
        {
            if (dgvLop.Rows.Count > 0)
            {
                txtmsLop.Text = dgvLop[0, dgvLop.CurrentRow.Index].Value.ToString();
                txttenLop.Text = dgvLop[1, dgvLop.CurrentRow.Index].Value.ToString();
                txtkhoaHoc.Text = dgvLop[2, dgvLop.CurrentRow.Index].Value.ToString();
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtmsLop.Clear();
                txttenLop.Clear();
                txtkhoaHoc.Clear();
            }
        }

        void luuLop()
        {
            string strLuu = "insert into Lop values (@MSLop, @TenLop, @KhoaHoc)";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strLuu, MyPublics.conMyConnection);

            cmdCommand.Parameters.AddWithValue("@MSLop", txtmsLop.Text);
            cmdCommand.Parameters.AddWithValue("@TenLop", txttenLop.Text);
            cmdCommand.Parameters.AddWithValue("@KhoaHoc", txtkhoaHoc.Text);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            dtLop.Rows.Add(txtmsLop.Text, txttenLop.Text, txtkhoaHoc.Text);

            dgvLop.CurrentCell = dgvLop[0, dgvLop.Rows.Count - 1];

            ganDuLieu();
            blnThem = false;
            dieuKhienKhiBinhThuong();

        }

        void capNhatLop()
        {
            string strCapNhat = "update Lop set TenLop = @TenLop, KhoaHoc = @KhoaHoc Where MSLop = @MSLop";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed) ;
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strCapNhat, MyPublics.conMyConnection);

            cmdCommand.Parameters.AddWithValue("@MSLop", txtmsLop.Text);
            cmdCommand.Parameters.AddWithValue("@TenLop", txttenLop.Text);
            cmdCommand.Parameters.AddWithValue("@KhoaHoc", txtkhoaHoc.Text);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            int curRow = dgvLop.CurrentRow.Index;

            dtLop.Rows[curRow][1] = txttenLop.Text;
            dtLop.Rows[curRow][2] = txtkhoaHoc.Text;

            dieuKhienKhiBinhThuong();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ganDuLieu();

            if (MyPublics.strQuyenSD == "AdminLop")
                if (txtmsLop.Text == MyPublics.strLop)
                    btnSua.Enabled = true;
                else
                    btnSua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem=true;
            dieuKhienKhiThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dieuKhienKhiChinhSua(); 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int khoa;
            if (txtmsLop.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mã số lớp!");
                txtmsLop.Focus();
                return;
            }
            if (txttenLop.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập tên lớp!");
                txttenLop.Focus();
                return;
            }

            if ((!int.TryParse(txtkhoaHoc.Text, out khoa)) || (khoa <= 0))
            {
                MessageBox.Show("Lỗi nhập khóa học!");
                txtkhoaHoc.Clear();
                txtkhoaHoc.Focus();
                return;
            }

            if (blnThem)
            {
                if (MyPublics.tonTaiKhoaChinh(txtmsLop.Text, "MSLop", "Lop"))
                {
                    MessageBox.Show("Mã số lớp này đã tồn tại !");
                    txtmsLop.Clear();
                    txtmsLop.Focus();

                }
                else luuLop();
            }
            else capNhatLop();

        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            ganDuLieu();
            dieuKhienKhiBinhThuong();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.tonTaiKhoaChinh(txtmsLop.Text, "MSLop", "SinhVien"))
                MessageBox.Show("Phải xóa sinh viên thuộc bảng Lớp trước đó!");
            else
            {
                DialogResult blnY;
                blnY = MessageBox.Show("Bạn thật sự muốn xóa ?","Xác nhận", MessageBoxButtons.YesNo);

                if (blnY == DialogResult.Yes)
                {
                    string sqlDel = "delete Lop where MSLop= @MsLop";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(sqlDel, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSLop", txtmsLop.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    dtLop.Rows.RemoveAt(dgvLop.CurrentRow.Index);
                    ganDuLieu();
                }
            }
        }

    }
}
