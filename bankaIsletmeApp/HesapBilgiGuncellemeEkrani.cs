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
    public partial class HesapBilgiGuncellemeEkrani : Form
    {
        public HesapBilgiGuncellemeEkrani()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            int musteriID = dbBanka.Musterilers.Where(x => x.MusteriTcNo == txt_tcNo.Text).FirstOrDefault().MusteriID;

            var listelenecekHesaplar = dbBanka.MusteriHesaplaris.Where(x => x.MusteriID == musteriID).ToList();

            dgv_hesaplariListele.DataSource = listelenecekHesaplar;

        }

        private void HesapBilgiGuncellemeEkrani_Load(object sender, EventArgs e)
        {
            grp_guncelleme.Enabled = false;
            btn_guncelle.Enabled = false;

        }

        private void btn_guncellemeYap_Click(object sender, EventArgs e)
        {
            grp_guncelleme.Enabled = true;
            btn_guncelle.Enabled = true;
        }


        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekHesapID = Convert.ToInt32(dgv_hesaplariListele.CurrentRow.Cells[0].Value);

            var guncellenecekHesap = dbBanka.MusteriHesaplaris.Where(x => x.HesapID == guncellenecekHesapID).FirstOrDefault();

            guncellenecekHesap.ParaBirimiKodu = txt_paraBirimi.Text;
            guncellenecekHesap.ParaBirimiID = Convert.ToInt32(txt_paraBirimiID.Text);

            dbBanka.SaveChanges();
        }

        private void btn_Onay_Click(object sender, EventArgs e)
        {
            if (txt_paraBirimi.Text == "TL")
            {
                txt_paraBirimiID.Text = Convert.ToString("1");
            }

            else if (txt_paraBirimi.Text == "USD")
            {
                txt_paraBirimiID.Text = Convert.ToString("2");
            }

            else if (txt_paraBirimi.Text == "EUR")
            {
                txt_paraBirimiID.Text = Convert.ToString("3");
            }
            else
            {
                MessageBox.Show("İlgili para birimi bulunamadı, lütfen ekleme yapınız.");
            }
        }

        private void dgv_hesaplariListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_bilgi_Click(object sender, EventArgs e)
        {

        }
    }
}
