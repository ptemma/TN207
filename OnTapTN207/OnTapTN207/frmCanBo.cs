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

namespace OnTapTN207
{
    public partial class frmCanBo : Form
    {
        public frmCanBo()
        {
            InitializeComponent();
        }
        DataTable dtCanBo= new DataTable("CANBO");
        DataTable dtDonVi = new DataTable("DONVI");
        DataTable dtQuyenSD = new DataTable("QuyenSD");
        bool blnthem= false;

        void dieuKhienBinhThuong()
        {
            if(MyPublics.strQuyenSD == "Quản lý")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnnXoa.Enabled = true;

            }
            else
            {
                btnThem.Enabled= true;
                btnSua.Enabled = false;
                btnnXoa.Enabled = false;

            }
            btnKhongLuu.Enabled = false;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;

            txtMaCB.ReadOnly = true;
            txtMaCB.BackColor= Color.White;
            txtHovaten.ReadOnly = true;
            txtHovaten.BackColor = Color.White;
            cboQuyenSD.Enabled = false;
            cboMaDV.Enabled = false;

            dgvCanBo.Enabled = true;


        }

        void ganDuLieu()
        {
            if(dtCanBo.Rows.Count > 0)
            {
                txtMaCB.Text = dgvCanBo[0, dgvCanBo.CurrentRow.Index].Value.ToString();
                txtHovaten.Text = dgvCanBo[1, dgvCanBo.CurrentRow.Index].Value.ToString();
                cboMaDV.SelectedValue = dgvCanBo[2, dgvCanBo.CurrentRow.Index].Value.ToString();
                cboQuyenSD.SelectedValue = dgvCanBo[4, dgvCanBo.CurrentRow.Index].Value.ToString();

            }
            else
            {
                btnSua.Enabled=false;
                btnnXoa.Enabled=false;
                txtMaCB.Clear();
                txtHovaten.Clear();
                cboMaDV.SelectedIndex = -1;
                cboQuyenSD.SelectedIndex = -1;
            }
        }
        private void frmCanBo_Load(object sender, EventArgs e)
        {
            string strSelect = "select * from CANBO";
            MyPublics.OpenData(strSelect, dtCanBo);

            strSelect = "select MADV, TENDV from DONVI";
            MyPublics.OpenData(strSelect, dtDonVi);
            cboMaDV.DataSource = dtDonVi;
            cboMaDV.DisplayMember = "TENDV";
            cboMaDV.ValueMember = "MADV";
            cboMaDV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaDV.AutoCompleteSource = AutoCompleteSource.ListItems;

            dtQuyenSD.Columns.Add("QuyenSD");
            dtQuyenSD.Rows.Add("Quản lý");
            dtQuyenSD.Rows.Add("Nhân viên   ");
            dtQuyenSD.Rows.Add("Dẫn chương trình");
            dtQuyenSD.Rows.Add("Giám khảo");
            cboQuyenSD.DataSource = dtQuyenSD;
            cboQuyenSD.DisplayMember = "QUYENSD";
            cboQuyenSD.ValueMember = "QUYENSD";

            txtMaCB.MaxLength = 6;
            txtHovaten.MaxLength = 40;

            dgvCanBo.DataSource = dtCanBo;
            dgvCanBo.Width = 600;
            dgvCanBo.AllowUserToAddRows=false; 
            dgvCanBo.AllowUserToDeleteRows=false;

            dgvCanBo.Columns[0].Width = 100;
            dgvCanBo.Columns[0].HeaderText = "Mã cán bộ";

            dgvCanBo.Columns[1].Width = 100;
            dgvCanBo.Columns[1].HeaderText = "Họ và tên";

            dgvCanBo.Columns[2].Width = 100;
            dgvCanBo.Columns[2].HeaderText = "Mã đơn vị";

            dgvCanBo.Columns[4].Width = 100;
            dgvCanBo.Columns[4].HeaderText = "Quyền sử dụng";

            dgvCanBo.Columns[3].Width = 100;
            dgvCanBo.Columns[3].HeaderText = "Mật khẩu";

            dgvCanBo.EditMode = DataGridViewEditMode.EditProgrammatically;
            ganDuLieu();
            dieuKhienBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ganDuLieu();
        }

        void dieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnnXoa.Enabled = false;
            btnDong.Enabled = false;
            btnKhongLuu.Enabled = true;
            btnLuu.Enabled=true;
            txtHovaten.ReadOnly = false;
            txtMaCB.ReadOnly = true;
            cboMaDV.Enabled = true;
            cboMaDV.SelectedIndex=0;

            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;

            dgvCanBo.Enabled = false;
            txtMaCB.Clear();
            txtHovaten.Clear();
            txtMaCB.Focus();

        }
        void dieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnnXoa.Enabled = false;
            btnDong.Enabled = false;
            btnKhongLuu.Enabled = true;
            btnLuu.Enabled = true;
            txtHovaten.ReadOnly = false;
            txtMaCB.ReadOnly = true;
            cboMaDV.Enabled = true;
            cboMaDV.SelectedIndex = 0;

            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;

            dgvCanBo.Enabled = false;
            txtHovaten.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnthem = true;
            dieuKhienKhiThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dieuKhienKhiChinhSua();
        }

        void thucThiLuu()
        {
            string strSql, strDonVi, strMatKhau = "", strQuyenSD;
            if (blnthem)
            {
                strSql = "insert into CANBO values (@MACB, @HOTEN, @MADV, @MATKHAU, @QUYENSD)";

            }
            else
            {
                strSql = "update CANBO set HOTEN=@HOTEN, MADV=@MADV, QUYENSD=@QUYENSD where MACB=@MACB";
            }
            if(MyPublics.conMyConnection.State == ConnectionState.Closed)
            {
                MyPublics.conMyConnection.Open();
            }
            SqlCommand cmdCommand = new SqlCommand(strSql,MyPublics.conMyConnection);

            cmdCommand.Parameters.AddWithValue("@MACB", txtMaCB.Text);
            cmdCommand.Parameters.AddWithValue("@HOTEN", txtHovaten.Text);
            strDonVi = cboMaDV.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MADV", strDonVi);
            if (blnthem)
            {
                strMatKhau = MyPublics.MaHoaPassword(txtMaCB.Text);
                cmdCommand.Parameters.AddWithValue("@MATKHAU", strMatKhau);
            }
            strQuyenSD= cboQuyenSD.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QUYENSD", strQuyenSD);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            if(blnthem)
            {
                dtCanBo.Rows.Add(txtMaCB.Text, txtHovaten.Text, strDonVi, strMatKhau, strQuyenSD);
                ganDuLieu();
                blnthem = false;
            }
            else
            {
                int curRow = dgvCanBo.CurrentRow.Index;
                dtCanBo.Rows[curRow][1] = txtHovaten.Text;
                dtCanBo.Rows[curRow][2] = strDonVi;
                dtCanBo.Rows[curRow][4] = strQuyenSD;

            }
            dieuKhienBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaCB.Text == "")
            {
                MessageBox.Show("Mã cán bộ trống", "thông báo");
                txtMaCB.Focus();
                return;
            }
            if (txtHovaten.Text == "")
            {
                MessageBox.Show("Họ và tên trống", "thông báo");
                txtHovaten.Focus();
                return;
            }
            if (cboMaDV.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chọn đơn vị", "thông báo");
                cboMaDV.Focus();
                return;
            }

            if (blnthem && MyPublics.TonTaiKhoaChinh(txtMaCB.Text, "MACB", "CANBO"))
            {
                MessageBox.Show("Cán bộ đã tồn tại", "thông báo");
                txtMaCB.Focus();
            }
            else
                thucThiLuu();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnthem = false;
            ganDuLieu();
            dieuKhienBinhThuong();
        }

        private void btnnXoa_Click(object sender, EventArgs e)
        {
            DialogResult blnDongy;
            blnDongy = MessageBox.Show("bạn có muốn xóa", "xác nhận", MessageBoxButtons.YesNo);
            if(blnDongy == DialogResult.Yes)
            {
                string strdel = "delete CANBO where MACB = @MACB";
                if(MyPublics.conMyConnection.State == ConnectionState.Closed) 
                {
                    MyPublics.conMyConnection.Open();
                }
                SqlCommand cmdCommand = new SqlCommand(strdel, MyPublics.conMyConnection);

                cmdCommand.Parameters.AddWithValue("@MACB", txtMaCB.Text) ;

                cmdCommand.ExecuteNonQuery();
                MyPublics.conMyConnection.Close();

                int curRow = dgvCanBo.CurrentRow.Index;
                dtCanBo.Rows.RemoveAt(curRow);
                ganDuLieu();
            }
            dieuKhienBinhThuong();
        }
    }
}
