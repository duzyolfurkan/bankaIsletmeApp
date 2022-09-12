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
    public partial class HesapOlusturma : Form
    {
        public HesapOlusturma()
        {
            InitializeComponent();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HesapOlusturma_Load(object sender, EventArgs e)
        {
            //Veritabanı ile etkileşim sağlanmadan kullanıcının veri girişi yapması engellendi.
            KullaniciKayitEngelle();
        }

        //İlgili metod tek kullanımlık şifre girişi yapılmadan kullanıcı kaydı girilmesini engeller.
        void KullaniciKayitEngelle()
        {
            txt_ad.Enabled = false;
            txt_soyad.Enabled = false;
            txt_birim.Enabled = false;
            txt_sube.Enabled = false;
            txt_unvan.Enabled = false;
            txt_kullaniciAdi.Enabled = false;
            txt_sifre.Enabled = false;
            btn_hesapOlustur.Enabled = false;
        }

        //İlgili metod tek kullanımlık şifre girişi yapıldıktan sonra kullanıcı kaydı girilmesini sağlar.
        void KullaniciKayitAc()
        {
            txt_ad.Enabled = true;
            txt_soyad.Enabled = true;
            txt_birim.Enabled = true;
            txt_sube.Enabled = true;
            txt_unvan.Enabled = true;
            txt_kullaniciAdi.Enabled = true;
            txt_sifre.Enabled = true;
            btn_hesapOlustur.Enabled = true;

            txt_kucukAdSoyad.Enabled = false;
            txt_tekSifre.Enabled = false;
            btn_guncelHesapOlustur.Enabled = false;
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_guncelHesapOlustur_Click(object sender, EventArgs e)
        {
            //Tek kullanımlık kullanıcı adı ve şifre girişleri alındı.
            string girilenAdSoyad = txt_kucukAdSoyad.Text;
            int girilenTekSifre = Convert.ToInt32(txt_tekSifre.Text);

            //Tek kullanımlık kullanıcı adına sahip kullanıcı çekildi.
            var tekKullanimlikGiris = dbBanka.TekKullanimlikSifres.Where(x => x.CalisanAdSoyad == girilenAdSoyad).FirstOrDefault();

            //Kullanıcı adı ve şifre kontrolü yapıldı.
            if (tekKullanimlikGiris.CalisanTekKullanimlikSifre == girilenTekSifre)
            {
                KullaniciKayitAc();
                dbBanka.TekKullanimlikSifres.Remove(tekKullanimlikGiris);
                dbBanka.SaveChanges();
            }
            else
            {
                MessageBox.Show("Tek kullanımlık şifre veya kullanıcı adınız hatalıdır, lütfen tekrar deneyiniz veya IT ile irtibata geçiniz.");
            }
        }

        private void btn_hesapOlustur_Click(object sender, EventArgs e)
        {
            CalisanProfil yeniCalisanEkle = new CalisanProfil();

            yeniCalisanEkle.CalisanAdi = txt_ad.Text;
            yeniCalisanEkle.CalisanSoyadi = txt_soyad.Text;
            yeniCalisanEkle.CalisanBirim = txt_birim.Text;
            yeniCalisanEkle.CalisanSube = txt_sube.Text;
            yeniCalisanEkle.CalisanUnvan = txt_unvan.Text;
            yeniCalisanEkle.CalisanKullaniciAdi = txt_kullaniciAdi.Text;
            yeniCalisanEkle.CalisanSifre = txt_sifre.Text;

            dbBanka.CalisanProfils.Add(yeniCalisanEkle);
            dbBanka.SaveChanges();

            MessageBox.Show("Kullanıcı kaydınız başarıyla tamamlanmıştır.");
            this.Close();
        }
    }
}
