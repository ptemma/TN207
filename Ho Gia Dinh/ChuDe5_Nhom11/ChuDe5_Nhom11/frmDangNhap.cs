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
    public partial class frmDangNhap : Form
    {
        private frmMain fMain;
        public frmDangNhap()
        {
            InitializeComponent();
        }


        public frmDangNhap(frmMain fm) : this()
        {
            fMain = fm;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaHo.Text = "1";
            txtMatKhau.Text = "1";
            txtMaHo.Focus();
            txtMatKhau.PasswordChar = '*';
            fMain.btnMenuDuLieu.Enabled = false;
            fMain.btnMenuHoTro.Enabled = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string sqlSelect,strPassword;
            try
            {
                MyPublics.ConnectDatabase();
                if (MyPublics.conMyConnection.State == 
                    ConnectionState.Open)
                {
                    MyPublics.strMaHo = txtMaHo.Text;
                    MyPublics.strSTT = txtSoThuTu.Text;
                    strPassword = txtMatKhau.Text;
                    sqlSelect = "Select QuyenSD " +
                        "From ThanhVien " +
                        "Where MaHo = @MaHo " +
                        "And SttThanhVien = @SttThanhVien "+
                        " And MatKhau = @MatKhau";
                    cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MaHo", txtMaHo.Text);
                    cmdCommand.Parameters.AddWithValue("@SttThanhVien", txtSoThuTu.Text);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", strPassword);
                    drReader = cmdCommand.ExecuteReader();
                    if (drReader.HasRows)
                    {
                        drReader.Read();
                        MyPublics.strQuyenSD = drReader.GetString(0);
                        drReader.Close();
                        fMain.btnMenuDuLieu.Enabled = true;
                        fMain.btnMenuHoTro.Enabled = true;
                        fMain.btnDoiMatKhau.Enabled = true;
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        MyPublics.conMyConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu sai!", "Thông báo");
                        txtMatKhau.Clear();
                        txtMaHo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo");
                }
            } catch (Exception)
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối", "Thông báo");
            }     
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MyPublics.conMyConnection != null)
                MyPublics.conMyConnection = null;
            fMain.btnMenuDuLieu.Enabled = false;
            fMain.btnMenuHoTro.Enabled = false;
            fMain.btnDoiMatKhau.Enabled = false;
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
                txtMatKhau.PasswordChar = '\0';
            else txtMatKhau.PasswordChar = '*';
        }
    }
}
