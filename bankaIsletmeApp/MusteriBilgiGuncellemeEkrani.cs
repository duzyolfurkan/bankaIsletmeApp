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
    public partial class MusteriBilgiGuncellemeEkrani : Form
    {
        public MusteriBilgiGuncellemeEkrani()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_getir_Click(object sender, EventArgs e)
        {
            string guncellenecekTC = txt_guncellenecekMusteriBilgisi.Text;

            var guncellenecekMusteri = dbBanka.Musterilers.Where(x => x.MusteriTcNo == guncellenecekTC).FirstOrDefault();

            txt_musteriTC.Text = guncellenecekMusteri.MusteriTcNo;
            txt_musteriAdi.Text = guncellenecekMusteri.MusteriAdi;
            txt_musteriSoyadi.Text = guncellenecekMusteri.MusteriSoyadi;
            txt_musteriAdres.Text = guncellenecekMusteri.MusteriAdresi;
            txt_telefon.Text = guncellenecekMusteri.MusteriTelefon;

        }

        private void btn_bilgiGuncelle_Click(object sender, EventArgs e)
        {
            var musteriBilgiGuncelle = dbBanka.Musterilers.Where(x => x.MusteriTcNo == txt_guncellenecekMusteriBilgisi.Text).FirstOrDefault();

            musteriBilgiGuncelle.MusteriTcNo = txt_musteriTC.Text;
            musteriBilgiGuncelle.MusteriAdi = txt_musteriAdi.Text;
            musteriBilgiGuncelle.MusteriSoyadi = txt_musteriSoyadi.Text;
            musteriBilgiGuncelle.MusteriAdresi = txt_musteriAdres.Text;
            musteriBilgiGuncelle.MusteriTelefon = txt_telefon.Text;

            dbBanka.SaveChanges();
            MessageBox.Show("Müşteri bilgi güncelleme işlemi tamamlanmıştır.");
        }
    }
}
