using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodyy06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CifLichSoucet(int cislo)
        {
            int soucet_lich = 0;
            while (cislo > 0)
            {
                int cifra = cislo % 10;
                if (cifra % 2 != 0)
                {
                    soucet_lich += cifra;
                }

                cislo /= 10;
            }
            return soucet_lich;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int vysledek = CifLichSoucet(n);
            MessageBox.Show("Soucet lichych cifer je " + vysledek);
        }
    }
}
