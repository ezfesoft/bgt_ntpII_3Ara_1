using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntpII_3Ara_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucgen u = new Ucgen();
            u.A_degiskeni = Convert.ToInt32(textBox1.Text);
            u.B_degiskeni = Convert.ToInt32(textBox2.Text);
            u.C_degiskeni = Convert.ToInt32(textBox3.Text);
            

            MessageBox.Show("Çevre Uzunluğu: " + u.CevreUzunluk.ToString());
        }
    }
}
