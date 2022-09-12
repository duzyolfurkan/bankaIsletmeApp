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
    public partial class HesapKapatmaEkrani : Form
    {
        public HesapKapatmaEkrani()
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

        private void btn_hesapKapat_Click(object sender, EventArgs e)
        {

            var silinecekHesapID = Convert.ToInt32(dgv_hesaplariListele.CurrentRow.Cells[0].Value);

            decimal hesapBakiyesi = dbBanka.MusteriHesaplaris.Where(x => x.HesapID == silinecekHesapID).FirstOrDefault().HesapBakiyesi;

            if (hesapBakiyesi != 0)
            {
                MessageBox.Show("Hesaba ait bakiye bulunmaktadır, müşteriye ödeme yaptıktan sonra kapatma işlemi yapılabilir.");
            }

            if (hesapBakiyesi == 0)
            {
                var silienecekHesap = dbBanka.MusteriHesaplaris.Where(x => x.HesapID == silinecekHesapID).FirstOrDefault();

                dbBanka.MusteriHesaplaris.Remove(silienecekHesap);
                dbBanka.SaveChanges();

                MessageBox.Show("İlgili hesap kapatılmıştır.");
            }

            
        }
    }
}
