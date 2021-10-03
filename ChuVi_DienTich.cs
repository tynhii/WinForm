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
    public partial class frmChuVi_DienTich : Form
    {
        float a, b, c, r, d;
        double p, S;
        public frmChuVi_DienTich()
        {
            InitializeComponent();
        }
        private void btn_Done_Click(object sender, EventArgs e)
        {
           
            if (rbtn_HV.Checked == true)
            {                     
                d = float.Parse(txtHV_canh.Text);
                txtHV_CV.Text = Convert.ToString(d * 4);
                txtHV_DT.Text = Convert.ToString(d * d);               
            }
            if (rbtn_HT.Checked == true)
            {                
                r = float.Parse(txtHT_r.Text);
                txtHT_CV.Text = Convert.ToString(2 * r * 3.14);
                txtHT_DT.Text = Convert.ToString(r * r * 3.14);
            }
            if (rbtn_HCN.Checked == true)
            {                
                a = float.Parse(txtHCN_Dai.Text);
                b = float.Parse(txtHCN_Rong.Text);
                txtHCN_CV.Text = Convert.ToString((a + b) * 2);
                txtHCN_DT.Text = Convert.ToString(a * b);
            }
            if (rbtn_HTG.Checked == true)
            {               
                a = float.Parse(txtHTG_a.Text);
                b = float.Parse(txtHTG_b.Text);
                c = float.Parse(txtHTG_c.Text);
                if (a + b > c && a + c > b && b + c > a)
                {
                    p = (a + b + c) / 2;
                    S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),5);
                    txtHTG_CV.Text = Convert.ToString(p * 2);
                    txtHTG_DT.Text = Convert.ToString(S);
                }
                else
                {
                    MessageBox.Show("Ba cạnh vừa nhập không tạo thành tam giác!", "Lỗi",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);                    
                }
            }            
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                Close();
        }
        private void frmChuVi_DienTich_Load(object sender, EventArgs e)
        {
            txtHV_CV.ReadOnly = true;
            txtHV_DT.ReadOnly = true;
            txtHT_DT.ReadOnly = true;
            txtHT_CV.ReadOnly = true;
            txtHCN_CV.ReadOnly = true;
            txtHCN_DT.ReadOnly = true;
            txtHTG_CV.ReadOnly = true;
            txtHTG_DT.ReadOnly = true;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtHCN_CV.ResetText();
            txtHCN_Dai.ResetText();
            txtHCN_DT.ResetText();
            txtHCN_Rong.ResetText();
            txtHTG_CV.ResetText();
            txtHTG_DT.ResetText();
            txtHT_r.ResetText();
            txtHTG_a.ResetText();
            txtHTG_b.ResetText();
            txtHTG_c.ResetText();
            txtHT_CV.ResetText();
            txtHT_DT.ResetText();
            txtHV_canh.ResetText();
            txtHV_CV.ResetText();
            txtHV_DT.ResetText();
            if (rbtn_HCN.Checked == true) txtHCN_Dai.Focus();
            if (rbtn_HT.Checked == true) txtHT_r.Focus();
            if (rbtn_HTG.Checked == true) txtHTG_a.Focus();
            if (rbtn_HV.Checked == true) txtHV_canh.Focus();
        }
        private void rbtn_HCN_CheckedChanged(object sender, EventArgs e)
        {            
            grbox_HCN.Enabled = true;
            grbox_HT.Enabled = false;
            grbox_HTG.Enabled = false;
            grbox_HV.Enabled = false;
            txtHCN_Dai.Focus();
        }
        private void rbtn_HV_CheckedChanged(object sender, EventArgs e)
        {           
            grbox_HV.Enabled = true;
            grbox_HTG.Enabled = false;
            grbox_HT.Enabled = false;
            grbox_HCN.Enabled = false;
            txtHV_canh.Focus();
        }
        private void rbtn_HTG_CheckedChanged(object sender, EventArgs e)
        {            
            grbox_HTG.Enabled = true;
            grbox_HV.Enabled = false;
            grbox_HT.Enabled = false;
            grbox_HCN.Enabled = false;
            txtHTG_a.Focus();
        }
        private void rbtn_HT_CheckedChanged(object sender, EventArgs e)
        {            
            grbox_HT.Enabled = true;
            grbox_HTG.Enabled = false;
            grbox_HV.Enabled = false;
            grbox_HCN.Enabled = false;
            txtHT_r.Focus();
        }
    }
}
