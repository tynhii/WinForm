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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dvdxgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq==DialogResult.Yes)
            Close();
        }
        private void thôngTinNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin frmthongtin = new ThongTin();
            frmthongtin.ShowDialog();
        }
        private void fxbfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaiPT frmGiaiPT = new frmGiaiPT();
            frmGiaiPT.ShowDialog();
        }
        private void tínhChiViDiệnTíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuVi_DienTich CV_DT = new frmChuVi_DienTich();
            CV_DT.ShowDialog();
        }
        private void tínhToánTrênMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mang mang = new Mang();
            mang.ShowDialog();
        }
        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySV sv = new QuanLySV();
            sv.ShowDialog();
        }
    }
}
