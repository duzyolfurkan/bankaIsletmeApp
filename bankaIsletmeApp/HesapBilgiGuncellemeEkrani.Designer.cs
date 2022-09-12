
namespace bankaIsletmeApp
{
    partial class HesapBilgiGuncellemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapBilgiGuncellemeEkrani));
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dgv_hesaplariListele = new System.Windows.Forms.DataGridView();
            this.btn_guncellemeYap = new System.Windows.Forms.Button();
            this.lbl_paraBirimiID = new System.Windows.Forms.Label();
            this.lbl_paraID = new System.Windows.Forms.Label();
            this.txt_paraBirimi = new System.Windows.Forms.TextBox();
            this.grp_guncelleme = new System.Windows.Forms.GroupBox();
            this.txt_paraBirimiID = new System.Windows.Forms.TextBox();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).BeginInit();
            this.grp_guncelleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(12, 9);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(269, 13);
            this.lbl_bilgi.TabIndex = 0;
            this.lbl_bilgi.Text = "Lütfen güncellemek istediğiniz müşteri TC bilgisini giriniz:";
            this.lbl_bilgi.Click += new System.EventHandler(this.lbl_bilgi_Click);
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(15, 25);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(368, 20);
            this.txt_tcNo.TabIndex = 1;
            this.txt_tcNo.TextChanged += new System.EventHandler(this.txt_tcNo_TextChanged);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(15, 50);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(368, 24);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Hesapları Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // dgv_hesaplariListele
            // 
            this.dgv_hesaplariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hesaplariListele.Location = new System.Drawing.Point(15, 80);
            this.dgv_hesaplariListele.Name = "dgv_hesaplariListele";
            this.dgv_hesaplariListele.Size = new System.Drawing.Size(368, 330);
            this.dgv_hesaplariListele.TabIndex = 3;
            this.dgv_hesaplariListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hesaplariListele_CellContentClick);
            // 
            // btn_guncellemeYap
            // 
            this.btn_guncellemeYap.Location = new System.Drawing.Point(15, 416);
            this.btn_guncellemeYap.Name = "btn_guncellemeYap";
            this.btn_guncellemeYap.Size = new System.Drawing.Size(368, 24);
            this.btn_guncellemeYap.TabIndex = 4;
            this.btn_guncellemeYap.Text = "Güncelleme Yap";
            this.btn_guncellemeYap.UseVisualStyleBackColor = true;
            this.btn_guncellemeYap.Click += new System.EventHandler(this.btn_guncellemeYap_Click);
            // 
            // lbl_paraBirimiID
            // 
            this.lbl_paraBirimiID.AutoSize = true;
            this.lbl_paraBirimiID.Location = new System.Drawing.Point(6, 16);
            this.lbl_paraBirimiID.Name = "lbl_paraBirimiID";
            this.lbl_paraBirimiID.Size = new System.Drawing.Size(90, 13);
            this.lbl_paraBirimiID.TabIndex = 5;
            this.lbl_paraBirimiID.Text = "Para Birimi Giriniz:";
            // 
            // lbl_paraID
            // 
            this.lbl_paraID.AutoSize = true;
            this.lbl_paraID.Location = new System.Drawing.Point(6, 55);
            this.lbl_paraID.Name = "lbl_paraID";
            this.lbl_paraID.Size = new System.Drawing.Size(73, 13);
            this.lbl_paraID.TabIndex = 7;
            this.lbl_paraID.Text = "Para Birimi ID:";
            // 
            // txt_paraBirimi
            // 
            this.txt_paraBirimi.Location = new System.Drawing.Point(9, 32);
            this.txt_paraBirimi.Name = "txt_paraBirimi";
            this.txt_paraBirimi.Size = new System.Drawing.Size(115, 20);
            this.txt_paraBirimi.TabIndex = 8;
            // 
            // grp_guncelleme
            // 
            this.grp_guncelleme.Controls.Add(this.txt_paraBirimiID);
            this.grp_guncelleme.Controls.Add(this.lbl_paraBirimiID);
            this.grp_guncelleme.Controls.Add(this.btn_Onay);
            this.grp_guncelleme.Controls.Add(this.lbl_paraID);
            this.grp_guncelleme.Controls.Add(this.txt_paraBirimi);
            this.grp_guncelleme.Location = new System.Drawing.Point(481, 160);
            this.grp_guncelleme.Name = "grp_guncelleme";
            this.grp_guncelleme.Size = new System.Drawing.Size(213, 100);
            this.grp_guncelleme.TabIndex = 9;
            this.grp_guncelleme.TabStop = false;
            this.grp_guncelleme.Text = "Para Birimi Guncelleme";
            // 
            // txt_paraBirimiID
            // 
            this.txt_paraBirimiID.Location = new System.Drawing.Point(9, 71);
            this.txt_paraBirimiID.Name = "txt_paraBirimiID";
            this.txt_paraBirimiID.Size = new System.Drawing.Size(115, 20);
            this.txt_paraBirimiID.TabIndex = 11;
            // 
            // btn_Onay
            // 
            this.btn_Onay.Location = new System.Drawing.Point(130, 31);
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.Size = new System.Drawing.Size(72, 21);
            this.btn_Onay.TabIndex = 10;
            this.btn_Onay.Text = "Onay";
            this.btn_Onay.UseVisualStyleBackColor = true;
            this.btn_Onay.Click += new System.EventHandler(this.btn_Onay_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(481, 266);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(213, 23);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HesapBilgiGuncellemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.grp_guncelleme);
            this.Controls.Add(this.btn_guncellemeYap);
            this.Controls.Add(this.dgv_hesaplariListele);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.lbl_bilgi);
            this.Name = "HesapBilgiGuncellemeEkrani";
            this.Text = "HesapBilgiGuncellemeEkrani";
            this.Load += new System.EventHandler(this.HesapBilgiGuncellemeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).EndInit();
            this.grp_guncelleme.ResumeLayout(false);
            this.grp_guncelleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.DataGridView dgv_hesaplariListele;
        private System.Windows.Forms.Button btn_guncellemeYap;
        private System.Windows.Forms.Label lbl_paraBirimiID;
        private System.Windows.Forms.Label lbl_paraID;
        private System.Windows.Forms.TextBox txt_paraBirimi;
        private System.Windows.Forms.GroupBox grp_guncelleme;
        private System.Windows.Forms.TextBox txt_paraBirimiID;
        private System.Windows.Forms.Button btn_Onay;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}