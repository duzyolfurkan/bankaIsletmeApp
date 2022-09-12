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
    public partial class ParaYatirmaEkrani : Form
    {
        public ParaYatirmaEkrani()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_hesaplariListele_Click(object sender, EventArgs e)
        {
            string tcNo = txt_tcNo.Text;

            int musteriID = dbBanka.Musterilers.Where(x => x.MusteriTcNo == tcNo).FirstOrDefault().MusteriID;

            var listelenecekHesaplar = dbBanka.MusteriHesaplaris.Where(x => x.MusteriID == musteriID).ToList();

            dgv_hesaplariListele.DataSource = listelenecekHesaplar;
        }

        private void btn_paraYatir_Click(object sender, EventArgs e)
        {
            int secilenHesapID = Convert.ToInt32(dgv_hesaplariListele.CurrentRow.Cells[0].Value);

            decimal hesabınBakiyesi = dbBanka.MusteriHesaplaris.Where(x => x.HesapID == secilenHesapID).FirstOrDefault().HesapBakiyesi;

            var yatirilacakHesap = dbBanka.MusteriHesaplaris.Where(x => x.HesapID == secilenHesapID).FirstOrDefault();

            yatirilacakHesap.HesapBakiyesi = hesabınBakiyesi + Convert.ToDecimal(txt_yatirilacakPara.Text);
            dbBanka.SaveChanges();

            MessageBox.Show("Para yatırma işleminiz tamamlanmıştır.");
        }
    }
}
