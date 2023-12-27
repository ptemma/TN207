using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnTapTN207
{
    public partial class frmDangNhap : Form
   {
        private frmMain fMain;

        public frmDangNhap (frmMain fm) : this()
        {
            fMain = fm;
        }
      public frmDangNhap()
      {
            InitializeComponent();
      }

        private void frmDangNhap_Load(object sender, System.EventArgs e)
        {
            txtTaiKhoan.Text = "002222";
            txtMatKhau.PasswordChar = '*';
            txtTaiKhoan.Focus();
        }

        private void btnDangNhap_Click(object sender, System.EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string sqlSelect, strPassword;
            try
            {
                MyPublics.ConnectDatabase();
                if(MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    MyPublics.strMaCB = txtTaiKhoan.Text;
                    strPassword = MyPublics.MaHoaPassword(txtMatKhau.Text);

                    sqlSelect = "select MADV, QUYENSD from CANBO where MACB=@MACB and MATKHAU=@MATKHAU";

                    cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);

                    cmdCommand.Parameters.AddWithValue("@MACB", txtTaiKhoan.Text);
                    cmdCommand.Parameters.AddWithValue("@MATKHAU", txtMatKhau.Text);
                    
                    drReader = cmdCommand.ExecuteReader();
                    if (drReader.HasRows)
                    {
                        drReader.Read();
                        MyPublics.strDonVi = drReader.GetString(0);
                        MyPublics.strQuyenSD= drReader.GetString(1);
                        drReader.Close();

                        fMain.mnuDuLieu.Enabled = true;
                        fMain.mnuCapNhat.Enabled = true;
                        fMain.mnuDangNhap.Enabled = true;
                        fMain.mnuDoiMatKhau.Enabled = true;
                        fMain.mnuThoatDangNhap.Enabled = true;

                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
                        txtTaiKhoan.Focus();
                    }

                }
                else
                {
                        MessageBox.Show("Kết nối không thành công", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối", "Thông báo");

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(MyPublics.conMyConnection != null)
            {
                MyPublics.conMyConnection = null;
            }
            fMain.mnuDuLieu.Enabled = true;
            fMain.mnuCapNhat.Enabled = true;
            fMain.mnuDoiMatKhau.Enabled = true;
            fMain.mnuThoatDangNhap.Enabled = true;
            this.Close();

        }
    }
}
