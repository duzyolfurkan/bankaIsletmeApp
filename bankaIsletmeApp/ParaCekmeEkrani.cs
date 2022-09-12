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
    public partial class ParaCekmeEkrani : Form
    {
        public ParaCekmeEkrani()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_paraYatir_Click(object sender, EventArgs e)
        {
            int cekilecekHesapID = Convert.ToInt32(dgv_hesaplariListele.CurrentRow.Cells[0].Value);

            var cekilecekHesap = dbBanka.MusteriHesaplaris.Where(x => x.HesapID == cekilecekHesapID).FirstOrDefault();

            decimal hesapBakiye = cekilecekHesap.HesapBakiyesi;

            cekilecekHesap.HesapBakiyesi = hesapBakiye - Convert.ToDecimal(txt_cekilecekPara.Text);

            MessageBox.Show("Para çekme işleminiz tamamlanmıştır.");
        }

        private void btn_hesaplariListele_Click(object sender, EventArgs e)
        {
            var listelecekMusteriID = dbBanka.Musterilers.Where(x => x.MusteriTcNo == txt_tcNo.Text).FirstOrDefault().MusteriID;

            var listelenecekHesaplar = dbBanka.MusteriHesaplaris.Where(x => x.MusteriID == listelecekMusteriID).ToList();

            dgv_hesaplariListele.DataSource = listelenecekHesaplar;

        }
    }
}
