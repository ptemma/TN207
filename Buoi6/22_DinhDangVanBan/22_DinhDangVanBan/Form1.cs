using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_DinhDangVanBan
{
    public partial class frmDDVB : Form
    {
        public frmDDVB()
        {
            InitializeComponent();
        }

        private void frmDDVB_Load(object sender, EventArgs e)
        {
            rdioLeft.Checked = true;
        }

        private void rdioLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioLeft.Checked)
                txtVB.TextAlign = HorizontalAlignment.Left;
        }

        private void rdioCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioCenter.Checked)
                txtVB.TextAlign = HorizontalAlignment.Center;
        }

        private void rdioRight_CheckedChanged(object sender, EventArgs e)
        {
            if(rdioRight.Checked)
                txtVB.TextAlign = HorizontalAlignment.Right;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
