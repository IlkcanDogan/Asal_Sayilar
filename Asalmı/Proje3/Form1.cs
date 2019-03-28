using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int tamBolen = 0;
            bool asalMi = true;
            int kalan = 0;
            sayi = Convert.ToInt32(txtSayi.Text);
            
            for(int i = 2; i < sayi; i++)
            {
               kalan = sayi % i;

                if(kalan == 0)
                {
                    tamBolen = i;
                    asalMi = false;
                    break;
                }
            }
            if (asalMi == true)
            {
                MessageBox.Show(sayi.ToString() + " sayısı asaldır");
            }
            else
            {
                MessageBox.Show(sayi.ToString() + " sayısı asal değildir. Tam böleni: " + tamBolen.ToString());
            }
            
            
        }
    }
}
