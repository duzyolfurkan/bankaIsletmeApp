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
    public partial class MusteriGoruntule : Form
    {
        public MusteriGoruntule()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            //Tıklandığında tüm müşteriler listelendi
            dgv_musteriGoruntuleme.DataSource = dbBanka.Musterilers.ToList();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_musteriAra_Click(object sender, EventArgs e)
        {
            //Seçilen müşterinin listelenmesi işlemi yapıldı.
            string tcNo = txt_tcArama.Text;

            var arananMusteri = dbBanka.Musterilers.Where(x => x.MusteriTcNo == tcNo).ToList();
            
            dgv_musteriGoruntuleme.DataSource = arananMusteri;
        }
    }
}
