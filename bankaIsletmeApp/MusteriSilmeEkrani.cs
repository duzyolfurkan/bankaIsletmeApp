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
    public partial class MusteriSilmeEkrani : Form
    {
        public MusteriSilmeEkrani()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_musteriAra_Click(object sender, EventArgs e)
        {
            //Seçilen müşterinin listelenmesi işlemi yapıldı.
            string tcNo = txt_tcArama.Text;

            var arananMusteri = dbBanka.Musterilers.Where(x => x.MusteriTcNo == tcNo).ToList();

            dgv_musteriGoruntuleme.DataSource = arananMusteri;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_musteriSil_Click(object sender, EventArgs e)
        {
            //Müşteri silme kodu yazıldı.
            int musteriID = Convert.ToInt32(dgv_musteriGoruntuleme.CurrentRow.Cells[0].Value);

            var hesapSayisi = dbBanka.MusteriHesaplaris
                .Where(x => x.MusteriID == musteriID).ToList().Count();
                

            if (hesapSayisi == 0)
            {
                var silinecekMusteri = dbBanka.Musterilers.Where(x => x.MusteriID == musteriID).FirstOrDefault();

                dbBanka.Musterilers.Remove(silinecekMusteri);
                dbBanka.SaveChanges();
                MessageBox.Show("Müşteri silme işleminiz tamamlanmıştır.");

            }

            if (hesapSayisi != 0)
            {
                MessageBox.Show("İlgili müşteriye ait hesap bulunmaktadır. Lütfen öncelikle hesap kapamalarını yapınız.");
            }


        }
    }
}
