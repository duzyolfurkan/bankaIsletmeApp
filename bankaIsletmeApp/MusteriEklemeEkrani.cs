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
    public partial class MusteriEklemeEkrani : Form
    {
        public MusteriEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_musteriKaydet_Click(object sender, EventArgs e)
        {
            Musteriler eklenecekMusteri = new Musteriler();

            eklenecekMusteri.MusteriTcNo = txt_musteriTC.Text;
            eklenecekMusteri.MusteriAdi = txt_musteriAdi.Text;
            eklenecekMusteri.MusteriSoyadi = txt_musteriSoyadi.Text;
            eklenecekMusteri.MusteriAdresi = txt_musteriAdres.Text;
            eklenecekMusteri.MusteriTelefon = txt_telefon.Text;

            dbBanka.Musterilers.Add(eklenecekMusteri);
            dbBanka.SaveChanges();
            MessageBox.Show("Müşteri kaydınız başarıyla tamamlanmıştır.");
        }
    }
}
