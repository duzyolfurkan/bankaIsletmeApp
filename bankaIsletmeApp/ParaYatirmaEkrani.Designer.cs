
namespace bankaIsletmeApp
{
    partial class ParaYatirmaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaYatirmaEkrani));
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.btn_hesaplariListele = new System.Windows.Forms.Button();
            this.dgv_hesaplariListele = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_bilgi3 = new System.Windows.Forms.Label();
            this.txt_yatirilacakPara = new System.Windows.Forms.TextBox();
            this.btn_paraYatir = new System.Windows.Forms.Button();
            this.lbl_bilgi2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(157, 42);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(237, 20);
            this.txt_tcNo.TabIndex = 0;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(154, 26);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(240, 13);
            this.lbl_bilgi.TabIndex = 1;
            this.lbl_bilgi.Text = "Lütfen işlem yapılacak müşteri TC Kimlik No giriniz";
            // 
            // btn_hesaplariListele
            // 
            this.btn_hesaplariListele.Location = new System.Drawing.Point(157, 68);
            this.btn_hesaplariListele.Name = "btn_hesaplariListele";
            this.btn_hesaplariListele.Size = new System.Drawing.Size(237, 23);
            this.btn_hesaplariListele.TabIndex = 2;
            this.btn_hesaplariListele.Text = "Hesapları Listele";
            this.btn_hesaplariListele.UseVisualStyleBackColor = true;
            this.btn_hesaplariListele.Click += new System.EventHandler(this.btn_hesaplariListele_Click);
            // 
            // dgv_hesaplariListele
            // 
            this.dgv_hesaplariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hesaplariListele.Location = new System.Drawing.Point(15, 132);
            this.dgv_hesaplariListele.Name = "dgv_hesaplariListele";
            this.dgv_hesaplariListele.Size = new System.Drawing.Size(386, 243);
            this.dgv_hesaplariListele.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_bilgi3
            // 
            this.lbl_bilgi3.AutoSize = true;
            this.lbl_bilgi3.Location = new System.Drawing.Point(12, 378);
            this.lbl_bilgi3.Name = "lbl_bilgi3";
            this.lbl_bilgi3.Size = new System.Drawing.Size(180, 13);
            this.lbl_bilgi3.TabIndex = 5;
            this.lbl_bilgi3.Text = "Lütfen hesaba yatırılacak tutarı giriniz";
            // 
            // txt_yatirilacakPara
            // 
            this.txt_yatirilacakPara.Location = new System.Drawing.Point(15, 394);
            this.txt_yatirilacakPara.Name = "txt_yatirilacakPara";
            this.txt_yatirilacakPara.Size = new System.Drawing.Size(386, 20);
            this.txt_yatirilacakPara.TabIndex = 6;
            // 
            // btn_paraYatir
            // 
            this.btn_paraYatir.Location = new System.Drawing.Point(15, 420);
            this.btn_paraYatir.Name = "btn_paraYatir";
            this.btn_paraYatir.Size = new System.Drawing.Size(386, 23);
            this.btn_paraYatir.TabIndex = 7;
            this.btn_paraYatir.Text = "Para Yatır";
            this.btn_paraYatir.UseVisualStyleBackColor = true;
            this.btn_paraYatir.Click += new System.EventHandler(this.btn_paraYatir_Click);
            // 
            // lbl_bilgi2
            // 
            this.lbl_bilgi2.AutoSize = true;
            this.lbl_bilgi2.Location = new System.Drawing.Point(12, 116);
            this.lbl_bilgi2.Name = "lbl_bilgi2";
            this.lbl_bilgi2.Size = new System.Drawing.Size(136, 13);
            this.lbl_bilgi2.TabIndex = 8;
            this.lbl_bilgi2.Text = "Lütfen hesap seçimi yapınız";
            // 
            // ParaYatirmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.lbl_bilgi2);
            this.Controls.Add(this.btn_paraYatir);
            this.Controls.Add(this.txt_yatirilacakPara);
            this.Controls.Add(this.lbl_bilgi3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_hesaplariListele);
            this.Controls.Add(this.btn_hesaplariListele);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.txt_tcNo);
            this.Name = "ParaYatirmaEkrani";
            this.Text = "ParaYatirmaEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.Button btn_hesaplariListele;
        private System.Windows.Forms.DataGridView dgv_hesaplariListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_bilgi3;
        private System.Windows.Forms.TextBox txt_yatirilacakPara;
        private System.Windows.Forms.Button btn_paraYatir;
        private System.Windows.Forms.Label lbl_bilgi2;
    }
}