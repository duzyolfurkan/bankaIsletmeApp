
namespace bankaIsletmeApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_bilgilendirme = new System.Windows.Forms.Label();
            this.btn_oturumAc = new System.Windows.Forms.Button();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.btn_hesapOlustur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bilgilendirme
            // 
            this.lbl_bilgilendirme.AutoSize = true;
            this.lbl_bilgilendirme.Location = new System.Drawing.Point(33, 195);
            this.lbl_bilgilendirme.Name = "lbl_bilgilendirme";
            this.lbl_bilgilendirme.Size = new System.Drawing.Size(428, 13);
            this.lbl_bilgilendirme.TabIndex = 0;
            this.lbl_bilgilendirme.Text = "Kullanıcı girişi yapmadan devam edemezsiniz, lütfen aşağıdaki seçeneklerden birin" +
    "i seçiniz";
            // 
            // btn_oturumAc
            // 
            this.btn_oturumAc.Location = new System.Drawing.Point(167, 233);
            this.btn_oturumAc.Name = "btn_oturumAc";
            this.btn_oturumAc.Size = new System.Drawing.Size(153, 23);
            this.btn_oturumAc.TabIndex = 1;
            this.btn_oturumAc.Text = "Oturum Aç";
            this.btn_oturumAc.UseVisualStyleBackColor = true;
            this.btn_oturumAc.Click += new System.EventHandler(this.btn_oturumAc_Click);
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.Location = new System.Drawing.Point(167, 291);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(153, 23);
            this.btn_cikisYap.TabIndex = 2;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // btn_hesapOlustur
            // 
            this.btn_hesapOlustur.Location = new System.Drawing.Point(167, 262);
            this.btn_hesapOlustur.Name = "btn_hesapOlustur";
            this.btn_hesapOlustur.Size = new System.Drawing.Size(153, 23);
            this.btn_hesapOlustur.TabIndex = 3;
            this.btn_hesapOlustur.Text = "Hesap Oluştur";
            this.btn_hesapOlustur.UseVisualStyleBackColor = true;
            this.btn_hesapOlustur.Click += new System.EventHandler(this.btn_hesapOlustur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_hesapOlustur);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.btn_oturumAc);
            this.Controls.Add(this.lbl_bilgilendirme);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bilgilendirme;
        private System.Windows.Forms.Button btn_oturumAc;
        private System.Windows.Forms.Button btn_cikisYap;
        private System.Windows.Forms.Button btn_hesapOlustur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

