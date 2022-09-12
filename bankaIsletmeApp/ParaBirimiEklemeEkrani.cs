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
    public partial class ParaBirimiEklemeEkrani : Form
    {
        public ParaBirimiEklemeEkrani()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısı yapıldı.
        DeutscheBankDBEntities1 dbBanka = new DeutscheBankDBEntities1();
        private void btn_paraBirimiEkle_Click(object sender, EventArgs e)
        {
            ParaBirimi eklenecekParaBirimi = new ParaBirimi();
            eklenecekParaBirimi.ParaBirimiKodu = txt_yeniParaBirimi.Text;

            dbBanka.ParaBirimis.Add(eklenecekParaBirimi);
            dbBanka.SaveChanges();

            MessageBox.Show("Para birimi ekleme işlemi tamamlanmıştır.");
        }
    }
}
