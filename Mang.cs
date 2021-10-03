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
    public partial class Mang : Form
    {
        int i, n, tam;
        int[] a = new int[100];
        string s, s1;      
        public Mang()
        {
            InitializeComponent();           
        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        {   
            s = txt_Nhap.Text;
            i = s.LastIndexOf(" ");
            while (i != -1)
            {
                s1 = s.Substring(i);
                s = s.Substring(0, i);
                a[n] = Convert.ToInt32(s1);
                n++;
                i = s.LastIndexOf(" ");
            }
            a[n] = Convert.ToInt32(s);
            s = " ";
            for (i = n; i >= 0; i--)
                s = s + " " + a[i].ToString();
            txt_Xuat.Text = s.Trim();
        }
        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            if (rbtn_Tang.Checked == true)
            {
                for (i = 0; i < n; i++)
                    for(int j = i + 1; j <= n;j++)
                        if (a[i] > a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;
                        }
                s = " ";
                for (i = 0; i <= n; i++)
                    s = s + " " + a[i].ToString();
                txt_Xuat.Text = s.Trim();                
            }
            if (rbtn_Giam.Checked == true)
            {
                for (i = 0; i < n; i++)
                    for (int j = i + 1; j <= n; j++)
                        if (a[i] < a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;
                        }
                s = " ";
                for (i = 0; i <= n; i++)
                    s = s + " " + a[i].ToString();
                txt_Xuat.Text = s.Trim();
            }
        }
        public static int TongMang(int[]a, int n)
        {   
            int s = 0;
            for (int i = 0; i <= n; i++)
                s += a[i];
            return s;
        }
        public static int TongChan(int [] a, int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
                if (a[i] % 2 == 0) s += a[i];
            return s;
        }      
        private void btn_Sum_Click(object sender, EventArgs e)
        {  
            txt_Sum.Text = TongMang(a, n).ToString();
            txt_SumOdd.Text = TongLe(a, n).ToString();
            txt_SumEven.Text = TongChan(a, n).ToString();
        }
        public static int TongLe(int[] a, int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
                if (a[i] % 2 != 0) s += a[i];
            return s;
        }
        public static int Min(int [] a, int n)
        {
            int gtMin = a[0];
            for (int i = 1; i <= n; i++)
                if (gtMin > a[i]) gtMin = a[i];
            return gtMin;
        }
        private void btn_MinMax_Click(object sender, EventArgs e)
        {
            txt_Max.Text = Max(a, n).ToString();
            txt_Min.Text = Min(a, n).ToString();
        }
        private void Mang_Load(object sender, EventArgs e)
        {            
            txt_Xuat.Enabled = false;
            txt_SumEven.Enabled = false;
            txt_SumOdd.Enabled = false;
            txt_Sum.Enabled = false;
            txt_Min.Enabled = false;
            txt_Max.Enabled = false;
        }
        public static int Max(int[] a, int n)
        {
            int gtMax = a[0];
            for (int i = 1; i <= n; i++)
                if (gtMax < a[i]) gtMax = a[i];
            return gtMax;
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                Close();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            n = 0;
            s = " ";
            txt_Max.ResetText();
            txt_Min.ResetText();
            txt_Nhap.ResetText();
            txt_Sum.ResetText();
            txt_SumEven.ResetText();
            txt_SumOdd.ResetText();
            txt_Xuat.ResetText();
            rbtn_Giam.Checked = false;
            rbtn_Tang.Checked = false;
            txt_Nhap.Focus();
        }
    }
}
