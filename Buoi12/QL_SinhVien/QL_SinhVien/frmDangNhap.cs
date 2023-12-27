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
    public partial class frmDangNhap : Form
    {
        private frmMain fMain;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public  frmDangNhap (frmMain fm):this() 
        {
            fMain = fm;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            String sqlSelect, strPassword;
            try
            {
                MyPublics.ConnectDatabase();
                if(MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    MyPublics.strMSSV = txtMSSV.Text;
                    strPassword = MyPublics.MaHoaPassword(txtMK.Text);

                    sqlSelect = "select MSLop, QuyenSD from SinhVien where MSSV=@MSSV and MatKhau=@MatKhau";

                    cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
                    cmdCommand.Parameters.AddWithValue("@MatKhau", strPassword);

                    drReader = cmdCommand.ExecuteReader();
                    if(drReader.HasRows)
                    {
                        drReader.Read();
                        MyPublics.strLop = drReader.GetString(0);
                        MyPublics.strQuyenSD = drReader.GetString(1);
                        drReader.Close();

                        fMain.mnuDuLieu.Enabled = true;
                        fMain.mnuCapNhat.Enabled = true;
                        fMain.mnuDoiMK.Enabled = true;
                        fMain.mnuThoatDangNhap.Enabled = true;
                        fMain.mnuDangNhap.Enabled = true;
                        MessageBox.Show("Dang nhap thanh cong", "thong bao");

                        MyPublics.conMyConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("MSSV hoặc mật khẩu sai!", "Thông báo");
                        txtMSSV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo");
                }
            }
            catch (Exception ) 
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối","Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MyPublics.conMyConnection != null)
                MyPublics.conMyConnection = null;
            fMain.mnuDuLieu.Enabled = false;
            fMain.mnuCapNhat.Enabled = false;
            fMain.mnuThoatDangNhap.Enabled = false;
            fMain.mnuDoiMK.Enabled = false;
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMSSV.Text = "1065779";
            txtMK.Text = "1065779";
            txtMSSV.Focus();
            txtMK.PasswordChar = '*';
        }
    }
}
