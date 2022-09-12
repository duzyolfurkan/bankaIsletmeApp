
namespace bankaIsletmeApp
{
    partial class HesapAcmaEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_iban = new System.Windows.Forms.TextBox();
            this.btn_ibanAta = new System.Windows.Forms.Button();
            this.rdb_usd = new System.Windows.Forms.RadioButton();
            this.rdb_euro = new System.Windows.Forms.RadioButton();
            this.grp_hesapTuruSecimi = new System.Windows.Forms.GroupBox();
            this.rdb_TL = new System.Windows.Forms.RadioButton();
            this.txt_musteriTCBilgisi = new System.Windows.Forms.TextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.grp_IBAN = new System.Windows.Forms.GroupBox();
            this.grp_musteriBilgiGetir = new System.Windows.Forms.GroupBox();
            this.dgv_musteriBilgileri = new System.Windows.Forms.DataGridView();
            this.grp_musteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btn_hesapAc = new System.Windows.Forms.Button();
            this.lbl_musteriID = new System.Windows.Forms.Label();
            this.txt_musteriID = new System.Windows.Forms.TextBox();
            this.lbl_hesapNo = new System.Windows.Forms.Label();
            this.txt_hesapNo = new System.Windows.Forms.TextBox();
            this.lbl_musteriAdi = new System.Windows.Forms.Label();
            this.txt_musteriAdi = new System.Windows.Forms.TextBox();
            this.txt_musteriSoyadi = new System.Windows.Forms.TextBox();
            this.txt_parabirimiID = new System.Windows.Forms.TextBox();
            this.lbl_musteriSoyadi = new System.Windows.Forms.Label();
            this.lbl_baslangicBakiyesi = new System.Windows.Forms.Label();
            this.txt_baslangicBakiyesi = new System.Windows.Forms.TextBox();
            this.lbl_paraBirimiKodu = new System.Windows.Forms.Label();
            this.txt_paraBirimiKod = new System.Windows.Forms.TextBox();
            this.lbl_paraBirimiID = new System.Windows.Forms.Label();
            this.grp_hesapTuruSecimi.SuspendLayout();
            this.grp_IBAN.SuspendLayout();
            this.grp_musteriBilgiGetir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriBilgileri)).BeginInit();
            this.grp_musteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_iban
            // 
            this.txt_iban.Location = new System.Drawing.Point(9, 35);
            this.txt_iban.Name = "txt_iban";
            this.txt_iban.Size = new System.Drawing.Size(189, 20);
            this.txt_iban.TabIndex = 0;
            // 
            // btn_ibanAta
            // 
            this.btn_ibanAta.Location = new System.Drawing.Point(9, 61);
            this.btn_ibanAta.Name = "btn_ibanAta";
            this.btn_ibanAta.Size = new System.Drawing.Size(189, 26);
            this.btn_ibanAta.TabIndex = 1;
            this.btn_ibanAta.Text = "IBAN Ata";
            this.btn_ibanAta.UseVisualStyleBackColor = true;
            this.btn_ibanAta.Click += new System.EventHandler(this.btn_ibanAta_Click);
            // 
            // rdb_usd
            // 
            this.rdb_usd.AutoSize = true;
            this.rdb_usd.Location = new System.Drawing.Point(6, 42);
            this.rdb_usd.Name = "rdb_usd";
            this.rdb_usd.Size = new System.Drawing.Size(131, 17);
            this.rdb_usd.TabIndex = 3;
            this.rdb_usd.TabStop = true;
            this.rdb_usd.Text = "Amerikan Doları (USD)";
            this.rdb_usd.UseVisualStyleBackColor = true;
            // 
            // rdb_euro
            // 
            this.rdb_euro.AutoSize = true;
            this.rdb_euro.Location = new System.Drawing.Point(6, 65);
            this.rdb_euro.Name = "rdb_euro";
            this.rdb_euro.Size = new System.Drawing.Size(131, 17);
            this.rdb_euro.TabIndex = 4;
            this.rdb_euro.TabStop = true;
            this.rdb_euro.Text = "AB Para Birimi (EURO)";
            this.rdb_euro.UseVisualStyleBackColor = true;
            // 
            // grp_hesapTuruSecimi
            // 
            this.grp_hesapTuruSecimi.Controls.Add(this.rdb_TL);
            this.grp_hesapTuruSecimi.Controls.Add(this.rdb_euro);
            this.grp_hesapTuruSecimi.Controls.Add(this.rdb_usd);
            this.grp_hesapTuruSecimi.Location = new System.Drawing.Point(12, 12);
            this.grp_hesapTuruSecimi.Name = "grp_hesapTuruSecimi";
            this.grp_hesapTuruSecimi.Size = new System.Drawing.Size(149, 95);
            this.grp_hesapTuruSecimi.TabIndex = 5;
            this.grp_hesapTuruSecimi.TabStop = false;
            this.grp_hesapTuruSecimi.Text = "Hesap Türü";
            // 
            // rdb_TL
            // 
            this.rdb_TL.AutoSize = true;
            this.rdb_TL.Location = new System.Drawing.Point(6, 19);
            this.rdb_TL.Name = "rdb_TL";
            this.rdb_TL.Size = new System.Drawing.Size(96, 17);
            this.rdb_TL.TabIndex = 2;
            this.rdb_TL.TabStop = true;
            this.rdb_TL.Text = "Türk Lirası (TL)";
            this.rdb_TL.UseVisualStyleBackColor = true;
            // 
            // txt_musteriTCBilgisi
            // 
            this.txt_musteriTCBilgisi.Location = new System.Drawing.Point(6, 35);
            this.txt_musteriTCBilgisi.Name = "txt_musteriTCBilgisi";
            this.txt_musteriTCBilgisi.Size = new System.Drawing.Size(227, 20);
            this.txt_musteriTCBilgisi.TabIndex = 7;
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(6, 15);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(228, 13);
            this.lbl_tc.TabIndex = 8;
            this.lbl_tc.Text = "Hesap Açılacak Müşteri TC Kimlik Girişi Yapınız";
            // 
            // btn_onayla
            // 
            this.btn_onayla.Location = new System.Drawing.Point(6, 61);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(230, 26);
            this.btn_onayla.TabIndex = 9;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // grp_IBAN
            // 
            this.grp_IBAN.Controls.Add(this.txt_iban);
            this.grp_IBAN.Controls.Add(this.btn_ibanAta);
            this.grp_IBAN.Location = new System.Drawing.Point(167, 12);
            this.grp_IBAN.Name = "grp_IBAN";
            this.grp_IBAN.Size = new System.Drawing.Size(200, 95);
            this.grp_IBAN.TabIndex = 10;
            this.grp_IBAN.TabStop = false;
            this.grp_IBAN.Text = "IBAN Atama";
            // 
            // grp_musteriBilgiGetir
            // 
            this.grp_musteriBilgiGetir.Controls.Add(this.lbl_tc);
            this.grp_musteriBilgiGetir.Controls.Add(this.txt_musteriTCBilgisi);
            this.grp_musteriBilgiGetir.Controls.Add(this.btn_onayla);
            this.grp_musteriBilgiGetir.Location = new System.Drawing.Point(373, 12);
            this.grp_musteriBilgiGetir.Name = "grp_musteriBilgiGetir";
            this.grp_musteriBilgiGetir.Size = new System.Drawing.Size(243, 95);
            this.grp_musteriBilgiGetir.TabIndex = 11;
            this.grp_musteriBilgiGetir.TabStop = false;
            this.grp_musteriBilgiGetir.Text = "Müşteri Bilgi Getirme";
            // 
            // dgv_musteriBilgileri
            // 
            this.dgv_musteriBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteriBilgileri.Location = new System.Drawing.Point(12, 113);
            this.dgv_musteriBilgileri.Name = "dgv_musteriBilgileri";
            this.dgv_musteriBilgileri.Size = new System.Drawing.Size(318, 325);
            this.dgv_musteriBilgileri.TabIndex = 12;
            this.dgv_musteriBilgileri.SelectionChanged += new System.EventHandler(this.dgv_musteriBilgileri_SelectionChanged);
            // 
            // grp_musteriBilgileri
            // 
            this.grp_musteriBilgileri.Controls.Add(this.btn_hesapAc);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_musteriID);
            this.grp_musteriBilgileri.Controls.Add(this.txt_musteriID);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_hesapNo);
            this.grp_musteriBilgileri.Controls.Add(this.txt_hesapNo);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_musteriAdi);
            this.grp_musteriBilgileri.Controls.Add(this.txt_musteriAdi);
            this.grp_musteriBilgileri.Controls.Add(this.txt_musteriSoyadi);
            this.grp_musteriBilgileri.Controls.Add(this.txt_parabirimiID);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_musteriSoyadi);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_baslangicBakiyesi);
            this.grp_musteriBilgileri.Controls.Add(this.txt_baslangicBakiyesi);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_paraBirimiKodu);
            this.grp_musteriBilgileri.Controls.Add(this.txt_paraBirimiKod);
            this.grp_musteriBilgileri.Controls.Add(this.lbl_paraBirimiID);
            this.grp_musteriBilgileri.Location = new System.Drawing.Point(336, 113);
            this.grp_musteriBilgileri.Name = "grp_musteriBilgileri";
            this.grp_musteriBilgileri.Size = new System.Drawing.Size(280, 325);
            this.grp_musteriBilgileri.TabIndex = 20;
            this.grp_musteriBilgileri.TabStop = false;
            this.grp_musteriBilgileri.Text = "Müşteri Bilgileri";
            this.grp_musteriBilgileri.Enter += new System.EventHandler(this.grp_musteriBilgileri_Enter);
            // 
            // btn_hesapAc
            // 
            this.btn_hesapAc.Location = new System.Drawing.Point(7, 292);
            this.btn_hesapAc.Name = "btn_hesapAc";
            this.btn_hesapAc.Size = new System.Drawing.Size(257, 26);
            this.btn_hesapAc.TabIndex = 2;
            this.btn_hesapAc.Text = "Hesap Aç";
            this.btn_hesapAc.UseVisualStyleBackColor = true;
            this.btn_hesapAc.Click += new System.EventHandler(this.btn_hesapAc_Click);
            // 
            // lbl_musteriID
            // 
            this.lbl_musteriID.AutoSize = true;
            this.lbl_musteriID.Location = new System.Drawing.Point(3, 52);
            this.lbl_musteriID.Name = "lbl_musteriID";
            this.lbl_musteriID.Size = new System.Drawing.Size(55, 13);
            this.lbl_musteriID.TabIndex = 14;
            this.lbl_musteriID.Text = "Müşteri ID";
            // 
            // txt_musteriID
            // 
            this.txt_musteriID.Location = new System.Drawing.Point(6, 67);
            this.txt_musteriID.Name = "txt_musteriID";
            this.txt_musteriID.Size = new System.Drawing.Size(258, 20);
            this.txt_musteriID.TabIndex = 13;
            // 
            // lbl_hesapNo
            // 
            this.lbl_hesapNo.AutoSize = true;
            this.lbl_hesapNo.Location = new System.Drawing.Point(4, 15);
            this.lbl_hesapNo.Name = "lbl_hesapNo";
            this.lbl_hesapNo.Size = new System.Drawing.Size(55, 13);
            this.lbl_hesapNo.TabIndex = 12;
            this.lbl_hesapNo.Text = "Hesap No";
            // 
            // txt_hesapNo
            // 
            this.txt_hesapNo.Location = new System.Drawing.Point(7, 30);
            this.txt_hesapNo.Name = "txt_hesapNo";
            this.txt_hesapNo.Size = new System.Drawing.Size(258, 20);
            this.txt_hesapNo.TabIndex = 11;
            // 
            // lbl_musteriAdi
            // 
            this.lbl_musteriAdi.AutoSize = true;
            this.lbl_musteriAdi.Location = new System.Drawing.Point(3, 89);
            this.lbl_musteriAdi.Name = "lbl_musteriAdi";
            this.lbl_musteriAdi.Size = new System.Drawing.Size(59, 13);
            this.lbl_musteriAdi.TabIndex = 6;
            this.lbl_musteriAdi.Text = "Müşteri Adı";
            // 
            // txt_musteriAdi
            // 
            this.txt_musteriAdi.Location = new System.Drawing.Point(6, 105);
            this.txt_musteriAdi.Name = "txt_musteriAdi";
            this.txt_musteriAdi.Size = new System.Drawing.Size(258, 20);
            this.txt_musteriAdi.TabIndex = 0;
            // 
            // txt_musteriSoyadi
            // 
            this.txt_musteriSoyadi.Location = new System.Drawing.Point(6, 145);
            this.txt_musteriSoyadi.Name = "txt_musteriSoyadi";
            this.txt_musteriSoyadi.Size = new System.Drawing.Size(258, 20);
            this.txt_musteriSoyadi.TabIndex = 1;
            // 
            // txt_parabirimiID
            // 
            this.txt_parabirimiID.Location = new System.Drawing.Point(6, 185);
            this.txt_parabirimiID.Name = "txt_parabirimiID";
            this.txt_parabirimiID.Size = new System.Drawing.Size(258, 20);
            this.txt_parabirimiID.TabIndex = 2;
            // 
            // lbl_musteriSoyadi
            // 
            this.lbl_musteriSoyadi.AutoSize = true;
            this.lbl_musteriSoyadi.Location = new System.Drawing.Point(3, 128);
            this.lbl_musteriSoyadi.Name = "lbl_musteriSoyadi";
            this.lbl_musteriSoyadi.Size = new System.Drawing.Size(76, 13);
            this.lbl_musteriSoyadi.TabIndex = 7;
            this.lbl_musteriSoyadi.Text = "Müşteri Soyadı";
            // 
            // lbl_baslangicBakiyesi
            // 
            this.lbl_baslangicBakiyesi.AutoSize = true;
            this.lbl_baslangicBakiyesi.Location = new System.Drawing.Point(3, 250);
            this.lbl_baslangicBakiyesi.Name = "lbl_baslangicBakiyesi";
            this.lbl_baslangicBakiyesi.Size = new System.Drawing.Size(95, 13);
            this.lbl_baslangicBakiyesi.TabIndex = 10;
            this.lbl_baslangicBakiyesi.Text = "Başlangıç Bakiyesi";
            // 
            // txt_baslangicBakiyesi
            // 
            this.txt_baslangicBakiyesi.Location = new System.Drawing.Point(6, 266);
            this.txt_baslangicBakiyesi.Name = "txt_baslangicBakiyesi";
            this.txt_baslangicBakiyesi.Size = new System.Drawing.Size(258, 20);
            this.txt_baslangicBakiyesi.TabIndex = 4;
            // 
            // lbl_paraBirimiKodu
            // 
            this.lbl_paraBirimiKodu.AutoSize = true;
            this.lbl_paraBirimiKodu.Location = new System.Drawing.Point(4, 210);
            this.lbl_paraBirimiKodu.Name = "lbl_paraBirimiKodu";
            this.lbl_paraBirimiKodu.Size = new System.Drawing.Size(84, 13);
            this.lbl_paraBirimiKodu.TabIndex = 9;
            this.lbl_paraBirimiKodu.Text = "Para Birimi Kodu";
            // 
            // txt_paraBirimiKod
            // 
            this.txt_paraBirimiKod.Location = new System.Drawing.Point(7, 225);
            this.txt_paraBirimiKod.Name = "txt_paraBirimiKod";
            this.txt_paraBirimiKod.Size = new System.Drawing.Size(257, 20);
            this.txt_paraBirimiKod.TabIndex = 5;
            // 
            // lbl_paraBirimiID
            // 
            this.lbl_paraBirimiID.AutoSize = true;
            this.lbl_paraBirimiID.Location = new System.Drawing.Point(3, 169);
            this.lbl_paraBirimiID.Name = "lbl_paraBirimiID";
            this.lbl_paraBirimiID.Size = new System.Drawing.Size(70, 13);
            this.lbl_paraBirimiID.TabIndex = 8;
            this.lbl_paraBirimiID.Text = "Para Birimi ID";
            // 
            // HesapAcmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.grp_musteriBilgileri);
            this.Controls.Add(this.dgv_musteriBilgileri);
            this.Controls.Add(this.grp_musteriBilgiGetir);
            this.Controls.Add(this.grp_IBAN);
            this.Controls.Add(this.grp_hesapTuruSecimi);
            this.Name = "HesapAcmaEkrani";
            this.Text = "HesapAcmaEkrani";
            this.grp_hesapTuruSecimi.ResumeLayout(false);
            this.grp_hesapTuruSecimi.PerformLayout();
            this.grp_IBAN.ResumeLayout(false);
            this.grp_IBAN.PerformLayout();
            this.grp_musteriBilgiGetir.ResumeLayout(false);
            this.grp_musteriBilgiGetir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriBilgileri)).EndInit();
            this.grp_musteriBilgileri.ResumeLayout(false);
            this.grp_musteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_iban;
        private System.Windows.Forms.Button btn_ibanAta;
        private System.Windows.Forms.RadioButton rdb_usd;
        private System.Windows.Forms.RadioButton rdb_euro;
        private System.Windows.Forms.GroupBox grp_hesapTuruSecimi;
        private System.Windows.Forms.RadioButton rdb_TL;
        private System.Windows.Forms.TextBox txt_musteriTCBilgisi;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.GroupBox grp_IBAN;
        private System.Windows.Forms.GroupBox grp_musteriBilgiGetir;
        private System.Windows.Forms.DataGridView dgv_musteriBilgileri;
        private System.Windows.Forms.GroupBox grp_musteriBilgileri;
        private System.Windows.Forms.Label lbl_musteriAdi;
        private System.Windows.Forms.TextBox txt_musteriAdi;
        private System.Windows.Forms.TextBox txt_musteriSoyadi;
        private System.Windows.Forms.TextBox txt_parabirimiID;
        private System.Windows.Forms.Label lbl_musteriSoyadi;
        private System.Windows.Forms.Label lbl_baslangicBakiyesi;
        private System.Windows.Forms.TextBox txt_baslangicBakiyesi;
        private System.Windows.Forms.Label lbl_paraBirimiKodu;
        private System.Windows.Forms.TextBox txt_paraBirimiKod;
        private System.Windows.Forms.Label lbl_paraBirimiID;
        private System.Windows.Forms.Label lbl_musteriID;
        private System.Windows.Forms.TextBox txt_musteriID;
        private System.Windows.Forms.Label lbl_hesapNo;
        private System.Windows.Forms.TextBox txt_hesapNo;
        private System.Windows.Forms.Button btn_hesapAc;
    }
}