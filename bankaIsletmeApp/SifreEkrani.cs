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
    public partial class SifreEkrani : Form
    {
        public SifreEkrani()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            //Bu ekrandan çıkış yapma özelliği tanımlandı
            this.Close();
        }

        private void SifreEkrani_Load(object sender, EventArgs e)
        {
            txt_girilenSifre.PasswordChar = '*';
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            //Kullanıcı adı ve şifre kontrolü yapıldı, kullanıcının bilgileri personel ekranına aktarıldı.
            string girilenKullaniciAdi = txt_girilenKullaniciAdi.Text;
            string girilenSifre = txt_girilenSifre.Text;

            var kullaniciGirisi = dbBanka.CalisanProfils.Where(x => x.CalisanKullaniciAdi == girilenKullaniciAdi).FirstOrDefault();

            if (kullaniciGirisi == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı, lütfen geçerli bir kullanıcı girişi yapınız.");
            }

            if (kullaniciGirisi.CalisanSifre == girilenSifre)
            {
                PersonelEkrani personelEkrani = new PersonelEkrani();

                personelEkrani.lbl_isim.Text = kullaniciGirisi.CalisanAdi + " " + kullaniciGirisi.CalisanSoyadi;
                personelEkrani.lbl_birim.Text = kullaniciGirisi.CalisanBirim;
                personelEkrani.lbl_sube.Text = kullaniciGirisi.CalisanSube;
                personelEkrani.lbl_unvan.Text = kullaniciGirisi.CalisanUnvan;

                personelEkrani.ShowDialog();

            }

            else
            {
                MessageBox.Show("Lütfen şifrenizi kontrol ediniz.");
            }

        }
    }
}
