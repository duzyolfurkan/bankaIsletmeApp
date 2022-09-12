
namespace bankaIsletmeApp
{
    partial class HesapKapatmaEkrani
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
            this.btn_hesapKapat = new System.Windows.Forms.Button();
            this.dgv_hesaplariListele = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hesapKapat
            // 
            this.btn_hesapKapat.Location = new System.Drawing.Point(12, 416);
            this.btn_hesapKapat.Name = "btn_hesapKapat";
            this.btn_hesapKapat.Size = new System.Drawing.Size(368, 24);
            this.btn_hesapKapat.TabIndex = 9;
            this.btn_hesapKapat.Text = "Hesap Kapat";
            this.btn_hesapKapat.UseVisualStyleBackColor = true;
            this.btn_hesapKapat.Click += new System.EventHandler(this.btn_hesapKapat_Click);
            // 
            // dgv_hesaplariListele
            // 
            this.dgv_hesaplariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hesaplariListele.Location = new System.Drawing.Point(12, 80);
            this.dgv_hesaplariListele.Name = "dgv_hesaplariListele";
            this.dgv_hesaplariListele.Size = new System.Drawing.Size(368, 330);
            this.dgv_hesaplariListele.TabIndex = 8;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(12, 50);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(368, 24);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "Hesapları Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(12, 25);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(368, 20);
            this.txt_tcNo.TabIndex = 6;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(9, 9);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(308, 13);
            this.lbl_bilgi.TabIndex = 5;
            this.lbl_bilgi.Text = "Lütfen kapatmak istediğiniz hesaba ait müşteri TC bilgisini giriniz:";
            // 
            // HesapKapatmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hesapKapat);
            this.Controls.Add(this.dgv_hesaplariListele);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.lbl_bilgi);
            this.Name = "HesapKapatmaEkrani";
            this.Text = "HesapKapatmaEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapKapat;
        private System.Windows.Forms.DataGridView dgv_hesaplariListele;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Label lbl_bilgi;
    }
}