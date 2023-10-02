using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_DangKyMonHoc
{
    public partial class frmDKMonHoc : Form
    {
        const int intCSDL=3;
        const int intJava=3;
        const int intHDH = 2;
        const int intCSharp = 3;
        int intsum = 0;

        public frmDKMonHoc()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDKMonHoc_Load(object sender, EventArgs e)
        {
            txtTongSoTC.Text = intsum.ToString();
        }

        private void chkJava_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJava.Checked)
                intsum += intJava;
            else
                intsum -= intJava;
            txtTongSoTC.Text = intsum.ToString();
        }

        private void chkCSDL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCSDL.Checked)
                intsum += intCSDL;
            else
                intsum -= intCSDL;
            txtTongSoTC.Text = intsum.ToString();
        }

        private void chkHDH_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHDH.Checked)
                intsum += intHDH;
            else
                intsum -= intHDH;
            txtTongSoTC.Text = intsum.ToString();
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC.Checked)
                intsum += intCSharp;
            else
                intsum -= intCSharp;
            txtTongSoTC.Text = intsum.ToString();
        }
    }
}
