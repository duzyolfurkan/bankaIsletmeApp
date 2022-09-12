
namespace bankaIsletmeApp
{
    partial class ParaCekmeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCekmeEkrani));
            this.lbl_bilgi2 = new System.Windows.Forms.Label();
            this.btn_paraCek = new System.Windows.Forms.Button();
            this.txt_cekilecekPara = new System.Windows.Forms.TextBox();
            this.lbl_bilgi3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_hesaplariListele = new System.Windows.Forms.DataGridView();
            this.btn_hesaplariListele = new System.Windows.Forms.Button();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bilgi2
            // 
            this.lbl_bilgi2.AutoSize = true;
            this.lbl_bilgi2.Location = new System.Drawing.Point(8, 118);
            this.lbl_bilgi2.Name = "lbl_bilgi2";
            this.lbl_bilgi2.Size = new System.Drawing.Size(136, 13);
            this.lbl_bilgi2.TabIndex = 17;
            this.lbl_bilgi2.Text = "Lütfen hesap seçimi yapınız";
            // 
            // btn_paraCek
            // 
            this.btn_paraCek.Location = new System.Drawing.Point(11, 422);
            this.btn_paraCek.Name = "btn_paraCek";
            this.btn_paraCek.Size = new System.Drawing.Size(386, 23);
            this.btn_paraCek.TabIndex = 16;
            this.btn_paraCek.Text = "Para Çek";
            this.btn_paraCek.UseVisualStyleBackColor = true;
            this.btn_paraCek.Click += new System.EventHandler(this.btn_paraYatir_Click);
            // 
            // txt_cekilecekPara
            // 
            this.txt_cekilecekPara.Location = new System.Drawing.Point(11, 396);
            this.txt_cekilecekPara.Name = "txt_cekilecekPara";
            this.txt_cekilecekPara.Size = new System.Drawing.Size(386, 20);
            this.txt_cekilecekPara.TabIndex = 15;
            // 
            // lbl_bilgi3
            // 
            this.lbl_bilgi3.AutoSize = true;
            this.lbl_bilgi3.Location = new System.Drawing.Point(8, 380);
            this.lbl_bilgi3.Name = "lbl_bilgi3";
            this.lbl_bilgi3.Size = new System.Drawing.Size(188, 13);
            this.lbl_bilgi3.TabIndex = 14;
            this.lbl_bilgi3.Text = "Lütfen hesaptan çekilecek tutarı giriniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_hesaplariListele
            // 
            this.dgv_hesaplariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hesaplariListele.Location = new System.Drawing.Point(11, 134);
            this.dgv_hesaplariListele.Name = "dgv_hesaplariListele";
            this.dgv_hesaplariListele.Size = new System.Drawing.Size(386, 243);
            this.dgv_hesaplariListele.TabIndex = 12;
            // 
            // btn_hesaplariListele
            // 
            this.btn_hesaplariListele.Location = new System.Drawing.Point(153, 70);
            this.btn_hesaplariListele.Name = "btn_hesaplariListele";
            this.btn_hesaplariListele.Size = new System.Drawing.Size(237, 23);
            this.btn_hesaplariListele.TabIndex = 11;
            this.btn_hesaplariListele.Text = "Hesapları Listele";
            this.btn_hesaplariListele.UseVisualStyleBackColor = true;
            this.btn_hesaplariListele.Click += new System.EventHandler(this.btn_hesaplariListele_Click);
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(150, 28);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(240, 13);
            this.lbl_bilgi.TabIndex = 10;
            this.lbl_bilgi.Text = "Lütfen işlem yapılacak müşteri TC Kimlik No giriniz";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(153, 44);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(237, 20);
            this.txt_tcNo.TabIndex = 9;
            // 
            // ParaCekmeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.lbl_bilgi2);
            this.Controls.Add(this.btn_paraCek);
            this.Controls.Add(this.txt_cekilecekPara);
            this.Controls.Add(this.lbl_bilgi3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_hesaplariListele);
            this.Controls.Add(this.btn_hesaplariListele);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.txt_tcNo);
            this.Name = "ParaCekmeEkrani";
            this.Text = "ParaCekmeEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hesaplariListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bilgi2;
        private System.Windows.Forms.Button btn_paraCek;
        private System.Windows.Forms.TextBox txt_cekilecekPara;
        private System.Windows.Forms.Label lbl_bilgi3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_hesaplariListele;
        private System.Windows.Forms.Button btn_hesaplariListele;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.TextBox txt_tcNo;
    }
}