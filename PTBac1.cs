using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Nhom
{
    class PTBac1
    {
        public string Giai_PTBac1(double a, double b)
        {
            string s;
            if (a == 0)
                if (b == 0)
                    s = "Phương trình vô số nghiệm";
                else
                    s = "Phương trình vô nghiệm";
            else
                s = "Phương trình có nghiệm:" + ((-b) / a).ToString();
            return s;
        }
    }
}
