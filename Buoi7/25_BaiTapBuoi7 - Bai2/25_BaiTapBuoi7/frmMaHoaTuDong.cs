using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_BaiTapBuoi7
{
    public partial class frmMaHoaTuDong : Form
    {
        public frmMaHoaTuDong()
        {
            InitializeComponent();
        }

        private void frmMaHoaTuDong_Load(object sender, EventArgs e)
        {
            txtPwCanTao.Focus();
        }
        private void btnTaoPasswords_Click(object sender, EventArgs e)
        {
            int cantao, chieudai, i,j, k, intChon;

            string strPw;
            if ((!int.TryParse(txtPwCanTao.Text, out cantao)) || (cantao <= 0))
            {
                MessageBox.Show("Lỗi nhập số password cần tạo", "thông báo");
                txtPwCanTao.Focus();
                txtPwCanTao.Clear();
                return;
            }
            if ((!int.TryParse(txtPwLength.Text, out chieudai)) || (chieudai <= 0))
            {
                MessageBox.Show("Lỗi nhập chiều dài password", "thông báo");
                txtPwLength.Focus();
                txtPwLength.Clear();
                return;
            }
            Random random = new Random();
            lstPwDuocTao.Items.Clear();
            lstPwDuocMaHoa.Items.Clear();
            for (i = 1; i <= cantao; i++)
            {
                strPw = "";
                for (j = 1; j <= chieudai; j++)
                {
                    intChon = (int)(random.Next(0, 3));
                    if (intChon == 0)
                    {
                        k = (int)(random.Next(48, 58));
                    }
                    else if (intChon == 1)
                    {
                        k = (int)(random.Next(65, 91));
                    }
                    else
                        k = (int)(random.Next(97, 123));
                    strPw += (char)(k);
                }
                lstPwDuocTao.Items.Add(strPw);
            }

        }

        String MaHoaPasswords(string password)
        {
            string str1 ,str2 ;
            int i, chieudai;
            str1 = "";
            str2 = "";
            chieudai = password.Length;
            for (i = 0; i < chieudai ; i= i+2)
            {
                str1 += password[i];
                if (i + 1 < chieudai)
                {
                    str2 += password[i + 1];
                }

            }
                return (str1 + str2);
        }
        private void btnMaHoaPasswords_Click(object sender, EventArgs e)
        {
            int i, canMaHoa ;
            canMaHoa = lstPwDuocTao.Items.Count;
            lstPwDuocMaHoa.Items.Clear();
            for (i = 0; i < canMaHoa; i++)
            {
                lstPwDuocMaHoa.Items.Add(this.MaHoaPasswords((String)lstPwDuocTao.Items[i]));   
            }
            
        }

        String GiaiMaPW(String password)
        {
            string strPw ="";
            int i, chieudai,n;
            chieudai = password.Length;
            n = chieudai / 2;
            if (chieudai % 2 != 0)
                n++;
                for (i = 0; i < n; i++)
                {
                    strPw += password[i];
                    if (n + i < chieudai)
                    {
                        strPw += password[n + i];
                    }
                }
                    return strPw;
        }
       

        private void lstPwDuocMaHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPwDuocGiaiMa.Text = this.GiaiMaPW((string)lstPwDuocMaHoa.SelectedItem);
        }

        private void chkHidePw_CheckedChanged(object sender, EventArgs e)
        {
            txtPwDuocGiaiMa.PasswordChar = '*';
            if(!chkHidePw.Checked)
                txtPwDuocGiaiMa.PasswordChar = '\0';
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
