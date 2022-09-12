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
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void PersonelEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEklemeEkrani musteriEklemeEkrani = new MusteriEklemeEkrani();
            musteriEklemeEkrani.Show();
        }

        private void btn_musteriGoruntule_Click(object sender, EventArgs e)
        {
            MusteriGoruntule musteriGoruntulemeEkrani = new MusteriGoruntule();
            musteriGoruntulemeEkrani.Show();
        }

        private void btn_musteriSil_Click(object sender, EventArgs e)
        {
            MusteriSilmeEkrani musteriSilmeEkrani = new MusteriSilmeEkrani();
            musteriSilmeEkrani.Show();
        }

        private void btn_musteriBilgiGuncelle_Click(object sender, EventArgs e)
        {
            MusteriBilgiGuncellemeEkrani musteriBilgiGuncellemeEkrani = new MusteriBilgiGuncellemeEkrani();
            musteriBilgiGuncellemeEkrani.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yeniKullaniciGiris_Click(object sender, EventArgs e)
        {
            this.Close();
            SifreEkrani sifreEkrani = new SifreEkrani();
            sifreEkrani.Show();
        }


        private void btn_mola_Click(object sender, EventArgs e)
        {
            grp_musteriIslemleri.Enabled = false;
            grp_hesapIslemleri.Enabled = false;
            grp_finansalIslemler.Enabled = false;
            grp_paraBirimi.Enabled = false;
            btn_mola.Enabled = false;
            btn_yeniKullaniciGiris.Enabled = false;
            btn_cikis.Enabled = false;

        }

        private void btn_molaBitir_Click(object sender, EventArgs e)
        {
            SifreEkrani sifreEkrani = new SifreEkrani();
            sifreEkrani.ShowDialog();

        }

        private void btn_hesapAc_Click(object sender, EventArgs e)
        {
            HesapAcmaEkrani hesapAcmaEkrani = new HesapAcmaEkrani();
            hesapAcmaEkrani.ShowDialog();
        }

        private void btn_hesapGoruntule_Click(object sender, EventArgs e)
        {
            HesapGoruntulemeEkrani hesapGoruntulemeEkrani = new HesapGoruntulemeEkrani();
            hesapGoruntulemeEkrani.ShowDialog();
        }

        private void btn_hesapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            HesapBilgiGuncellemeEkrani hesapBilgiGuncellemeEkrani = new HesapBilgiGuncellemeEkrani();
            hesapBilgiGuncellemeEkrani.ShowDialog();
        }

        private void btn_hesapKapat_Click(object sender, EventArgs e)
        {
            HesapKapatmaEkrani hesapKapatmaEkrani = new HesapKapatmaEkrani();
            hesapKapatmaEkrani.ShowDialog();

        }

        private void btn_paraBirimi_Click(object sender, EventArgs e)
        {
            ParaBirimiEklemeEkrani paraBirimiEklemeEkrani = new ParaBirimiEklemeEkrani();
            paraBirimiEklemeEkrani.ShowDialog();
        }

        private void btn_paraYatirma_Click(object sender, EventArgs e)
        {
            ParaYatirmaEkrani paraYatirmaEkrani = new ParaYatirmaEkrani();
            paraYatirmaEkrani.ShowDialog();
        }

        private void btn_paraCekme_Click(object sender, EventArgs e)
        {
            ParaCekmeEkrani paraCekmeEkrani = new ParaCekmeEkrani();
            paraCekmeEkrani.ShowDialog();
        }
    }
}
