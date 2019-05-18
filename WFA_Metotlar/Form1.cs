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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tckn = txtTCKN.Text;
            string telefon = txtGSM.Text;
            string adres = txtAdres.Text;

            MessageBox.Show(string.Format("Adınız: {0} Soyadınız: {1}\nTCKN: {2} Telefon: {3}\nAdres: {4}",ad,soyad,tckn,telefon,adres));

        }

        void Clear() // Temizleme metotu oluşturdum
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MesajVer("Muhsin",58);
        }

        void MesajVer(string ad, int yas) //Değer döndürmeyen metot
        {
            label6.Text = "Merhaba " + ad + " " + yas;
        }

        string MesajVer2() // Değer döndüren metot
        {
            string karsila = "Merhaba2";
            return karsila;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label6.Text = MesajVer2();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}