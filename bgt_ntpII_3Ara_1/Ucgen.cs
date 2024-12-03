using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntpII_3Ara_1
{
    public class Ucgen
    {
        int a;
        int b;
        int c;

        public int A_degiskeni {
            get { return a; }
            set { a = value; }
        }
        public int B_degiskeni
        {
            get { return b; }
            set { b = value; }
        }
        public int C_degiskeni
        {
            get { return c; }
            set { 
                if(value <= 0)
                {
                    MessageBox.Show("Hatalı giris");
                }
                else
                {
                    c = value;
                }
            }
        }
        public int CevreUzunluk
        {
            get { return a + b + c; }
        }











    }
}
