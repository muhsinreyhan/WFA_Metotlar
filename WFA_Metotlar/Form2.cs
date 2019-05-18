using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Degistir(textBox1.Text);
            int sayi2 = Degistir(textBox2.Text);
            label3.Text = Topla1(sayi1, sayi2).ToString();
        }

        int Topla1(int a, int b) // döndüren
        {
            int c = a + b;
            return c;
        }

        void Topla2() //döndürmeyen
        {
            int sayi1 = Degistir(textBox1.Text);
            int sayi2 = Degistir(textBox2.Text);
            label3.Text = (sayi1 + sayi2).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Topla2();
        }

        int Degistir (string sayi1)
        {
            int donusenSayi = Convert.ToInt32(sayi1);
            return donusenSayi;
        }
    }
}
