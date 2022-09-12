using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaIsletmeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_oturumAc_Click(object sender, EventArgs e)
        {
            //Şifre ekranı ile bağlantı yapılması sağlandı.
            SifreEkrani sifreEkrani = new SifreEkrani();
            sifreEkrani.ShowDialog();
            
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            //Çıkış yap butonuna programı kapatma özelliği tanımlandı.
            Application.Exit();
        }

        private void btn_hesapOlustur_Click(object sender, EventArgs e)
        {
            //Hesap oluşturma ekranı ile bağlantı sağlandı.
            HesapOlusturma hesapOlusturma = new HesapOlusturma();
            hesapOlusturma.Show();
        }
    }
}
