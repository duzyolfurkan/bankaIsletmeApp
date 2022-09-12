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
    public partial class HesapGoruntulemeEkrani : Form
    {
        public HesapGoruntulemeEkrani()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            int musteriID = Convert.ToInt32(txt_hesapgoruntulemeTC.Text);

            var goruntulenecekMusteri = dbBanka.MusteriHesaplaris.Where(x => x.MusteriID == musteriID).ToList();

            dataGridView1.DataSource = goruntulenecekMusteri;
        }
    }
}
