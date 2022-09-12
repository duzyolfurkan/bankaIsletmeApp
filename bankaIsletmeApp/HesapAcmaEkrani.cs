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
    public partial class HesapAcmaEkrani : Form
    {
        public HesapAcmaEkrani()
        {
            InitializeComponent();
        }
        
        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();

        string hesapTuru = string.Empty;
        int paraBirimiID;

        private void grp_musteriBilgileri_Enter(object sender, EventArgs e)
        {
           
        }

        private void btn_ibanAta_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1000000000, 2147483647);

            txt_iban.Text = "TR" + sayi;

            if (rdb_TL.Checked == true)
            {
                hesapTuru = "TL";
                paraBirimiID = 1;
            }

            if (rdb_usd.Checked == true)
            {
                hesapTuru = "USD";
                paraBirimiID = 2;
            }

            if (rdb_euro.Checked == true)
            {
                hesapTuru = "EUR";
                paraBirimiID = 3;
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            var secilenMusteri = dbBanka.Musterilers.Where(x => x.MusteriTcNo == txt_musteriTCBilgisi.Text).ToList();
            dgv_musteriBilgileri.DataSource = secilenMusteri;

         
        }

        private void dgv_musteriBilgileri_SelectionChanged(object sender, EventArgs e)
        {
            int musteriID = Convert.ToInt32(dgv_musteriBilgileri.CurrentRow.Cells[0].Value);
            var bilgiCekilecekMusteri = dbBanka.Musterilers.Where(x=>x.MusteriID == musteriID).FirstOrDefault();

            txt_hesapNo.Text = txt_iban.Text;
            txt_musteriID.Text = bilgiCekilecekMusteri.MusteriID.ToString();
            txt_musteriAdi.Text = bilgiCekilecekMusteri.MusteriAdi;
            txt_musteriSoyadi.Text = bilgiCekilecekMusteri.MusteriSoyadi;
            txt_parabirimiID.Text = paraBirimiID.ToString();
            txt_paraBirimiKod.Text = hesapTuru;

        }

        private void btn_hesapAc_Click(object sender, EventArgs e)
        {
            MusteriHesaplari musteriHesabiEkle = new MusteriHesaplari();

            musteriHesabiEkle.HesapNo = txt_hesapNo.Text;
            musteriHesabiEkle.MusteriID = Convert.ToInt32(txt_musteriID.Text);
            musteriHesabiEkle.MusteriAdi = txt_musteriAdi.Text;
            musteriHesabiEkle.MusteriSoyadi = txt_musteriSoyadi.Text;
            musteriHesabiEkle.ParaBirimiID = Convert.ToInt32(txt_parabirimiID.Text);
            musteriHesabiEkle.ParaBirimiKodu = txt_paraBirimiKod.Text;
            musteriHesabiEkle.HesapBakiyesi = Convert.ToDecimal(txt_baslangicBakiyesi.Text);

            dbBanka.MusteriHesaplaris.Add(musteriHesabiEkle);
            dbBanka.SaveChanges();

            MessageBox.Show("Hesap açılışı tamamlanmıştır.");

        }
    }
}
