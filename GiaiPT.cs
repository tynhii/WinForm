using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Nhom
{
    public partial class frmGiaiPT : Form
    {
        public frmGiaiPT()
        {
            InitializeComponent();
        }      
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtA.ResetText();
            txtB.ResetText();
            txtC.ResetText();
            txtResult.ResetText();
            txtA.Focus();
        }
        private void radioBtn_PT1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;
            txtResult.ReadOnly = true;
            txtA.Focus();
        }

        private void radioBtn_PT2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
            txtResult.ReadOnly = true;
            txtA.Focus();
        }
        PTBac2 giai = new PTBac2();
        private void btnSolve_Click(object sender, EventArgs e)
        {
             double x, y, z;
            if (radioBtn_PT1.Checked == true)
            {
                x = Convert.ToDouble(txtA.Text);
                y = Convert.ToDouble(txtB.Text);
                txtResult.Text = giai.Giai_PTBac1(x, y);
            }
            else if (radioBtn_PT2.Checked == true)
            {
                x = Convert.ToDouble(txtA.Text);
                y = Convert.ToDouble(txtB.Text);
                z = Convert.ToDouble(txtC.Text);
                txtResult.Text = giai.Giai_PTBac2(x, y, z);
            }
        }
    }
}
