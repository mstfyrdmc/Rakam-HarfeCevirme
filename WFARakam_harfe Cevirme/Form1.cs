using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFARakam_harfe_Cevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtsayi.Text);

            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "alti", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kirk", "elli", "altmiş", "yetmiş", "seksen", "doksan" };
            string[] yüzler = { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altiyüz", "yediyüz", "sekizyüz", "dokuzyüz" };

            int a = sayi / 1000;
            int b = (sayi%1000/ 100);
            int c = (sayi % 100) / 10;
            int d = sayi % 10;

            if (sayi == 0)
                lblsonuc.Text = "Sifir";

            if (a > 0)
            {
                if (a != 1)
                    lblsonuc.Text=birler[a] + " ";

                lblsonuc.Text = lblsonuc.Text+" bin ";
            }

            if (b > 0)
               lblsonuc.Text=lblsonuc.Text+yüzler[b] + " ";

            if (c > 0)
                lblsonuc.Text=lblsonuc.Text+onlar[c] + " ";

            if (d > 0)
                lblsonuc.Text = lblsonuc.Text+birler[d] + " ";
        }
    }
}
