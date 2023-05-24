using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometriHesaplayıcısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // KARE ALANI HESAPLAMA
            int kareKenarUzunluk = Convert.ToInt16(textBoxKenar.Text);
            int alan = kareKenarUzunluk * kareKenarUzunluk;
            labelKare.Text = alan.ToString();

            // DİKDÖRTGEN ALAN HESAPLAMA
            int uzunKenar = Convert.ToInt16(textBoxUzunKenar.Text);
            int kısaKenar = Convert.ToInt16(textBoxKısaKenar.Text);
            int alandikdortgen = uzunKenar * kısaKenar;

            labelDikdortgen.Text = alandikdortgen.ToString();

            //DAİRE ALAN HESAPLAMA

            int yaricap = Convert.ToInt16(textBoxYarıCap.Text);
            int alandaire = (int)3.14 * yaricap * yaricap;

            labeldaire.Text = alandaire.ToString();


        }
    }
}
