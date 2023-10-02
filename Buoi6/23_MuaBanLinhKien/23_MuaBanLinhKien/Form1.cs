using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_MuaBanLinhKien
{
    public partial class frmMuaBanLinhKien : Form
    {
        public frmMuaBanLinhKien()
        {
            InitializeComponent();
        }

        private void frmMuaBanLinhKien_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnChonMua.Enabled = false;
            btnBoChon.Enabled = false;
            txtLK.Focus();
        }

        private void txtLK_TextChanged(object sender, EventArgs e)
        {
            if(txtLK.Text.Length>0)
                btnThem.Enabled = true;
            else
                btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strTemp = txtLK.Text.Trim();
            if (lstDSLK.Items.IndexOf(strTemp) >= 0)
                MessageBox.Show("Linh kiện đã được thêm", "Thông báo");
            else
                lstDSLK.Items.Add(strTemp);

            btnThem.Enabled = false;
            txtLK.Focus();
            txtLK.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstDSLK_SelectedIndexChanged(object sender, EventArgs e)
        {
                btnChonMua.Enabled = true;
                btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDSLK.SelectedIndex != -1 )
            {
                if (lstLKDC.Items.IndexOf(lstDSLK.SelectedItem) != -1)
                {
                    MessageBox.Show("Linh kiện đã được chọn mua", "Thông báo");
                }
                else
                {
                    lstDSLK.Items.RemoveAt(lstDSLK.SelectedIndex);
                    btnXoa.Enabled = false;
                    btnChonMua.Enabled = false;
                }
            }
        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            if (lstDSLK.SelectedIndex != -1)
            {
                if (lstLKDC.Items.IndexOf(lstDSLK.SelectedItem) >= 0)
                    MessageBox.Show("Linh kiện đã được chọn mua", "Thông báo");
                else
                    lstLKDC.Items.Add(lstDSLK.SelectedItem);
            }
            else
                MessageBox.Show("Chon linh kiện cần mua", " thông báo");
            
            btnXoa.Enabled = false;
            btnChonMua.Enabled = false;
            lstDSLK.SelectedIndex = -1;
        }

        private void lstLKDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBoChon.Enabled = true;

        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            lstLKDC.Items.RemoveAt(lstLKDC.SelectedIndex);
            btnBoChon.Enabled = false;
        }

    }
}
