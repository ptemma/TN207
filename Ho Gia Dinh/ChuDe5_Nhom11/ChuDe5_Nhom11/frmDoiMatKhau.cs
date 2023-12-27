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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
         /*   string strSelect = "Select TenTaiKhoan, QuyenSD From NguoiSuDung " +
                "Where TenTaiKhoan = @TenTaiKhoan";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSelect, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@TenTaiKhoan", MyPublics.strTenTK);
            SqlDataReader drReader = cmdCommand.ExecuteReader();
            drReader.Read();
            txtTenTK.Text = drReader.GetString(0);
            txtQuyenSD.Text = drReader.GetString(1);
            drReader.Close();
            MyPublics.conMyConnection.Close();
            txtTenTK.ReadOnly = true;
            txtTenTK.BackColor = Color.White;
            txtQuyenSD.ReadOnly = true;
            txtQuyenSD.BackColor = Color.White;
            txtMatKhau1.PasswordChar = '*';
            txtMatKhau2.PasswordChar = '*';
            txtMatKhau1.Focus(); */
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
          /*  if (txtMatKhau1.Text == "")
            {
                MessageBox.Show("Lỗi chưa nhập mật khẩu mới!");
                txtMatKhau1.Focus();
                return;
            }

            if (txtMatKhau1.Text != txtMatKhau2.Text)
            {
                MessageBox.Show("Lỗi mật khẩu mới không giống nhau!");
                txtMatKhau2.Clear();
                txtMatKhau2.Focus();
                return;
            }

            string strSelect = "Update NguoiSuDung Set MatKhau = @MatKhau " +
                "Where TenTaiKhoan = @TenTaiKhoan";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSelect, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MatKhau", txtMatKhau1.Text);
            cmdCommand.Parameters.AddWithValue("@TenTaiKhoan", MyPublics.strTenTK);
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();*/
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau1.PasswordChar = '\0';
                txtMatKhau2.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau1.PasswordChar = '*';
                txtMatKhau2.PasswordChar = '*';
            }
        }
    }
}
