using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Nhom
{
    class PTBac2:PTBac1
    {
        public string Giai_PTBac2(double a, double b, double c)
        {
            string s;
            double delta, x1, x2;
            if (a == 0)
                s = Giai_PTBac1(b,c);
            else
            {
                delta = (b * b) - (4 * a * c);
                if (delta < 0)
                    s = "Phương trình vô nghiệm";
                else
                {
                    if (delta == 0)
                        s = "Phương trình có 1 nghiệm x= " + (-b) / (2 * a);
                    else
                    {

                        x1 =Math.Round((-b + Math.Sqrt(delta)) / (2 * a),5);
                        x2 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a),5);
                        s = "Phương trình có 2 nghiệm: " + "x1= " + x1 + "và x2= " + x2;
                    }
                }
            }
            return s;
        }
        
    }
}
