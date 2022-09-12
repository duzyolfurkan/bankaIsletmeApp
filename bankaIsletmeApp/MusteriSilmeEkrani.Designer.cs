
namespace bankaIsletmeApp
{
    partial class MusteriSilmeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSilmeEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_musteriAra = new System.Windows.Forms.Button();
            this.lbl_musteriTC = new System.Windows.Forms.Label();
            this.txt_tcArama = new System.Windows.Forms.TextBox();
            this.dgv_musteriGoruntuleme = new System.Windows.Forms.DataGridView();
            this.btn_musteriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriGoruntuleme)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(156, 108);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(163, 23);
            this.btn_cikis.TabIndex = 12;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_musteriAra
            // 
            this.btn_musteriAra.Location = new System.Drawing.Point(156, 50);
            this.btn_musteriAra.Name = "btn_musteriAra";
            this.btn_musteriAra.Size = new System.Drawing.Size(163, 23);
            this.btn_musteriAra.TabIndex = 10;
            this.btn_musteriAra.Text = "Müşteri Ara";
            this.btn_musteriAra.UseVisualStyleBackColor = true;
            this.btn_musteriAra.Click += new System.EventHandler(this.btn_musteriAra_Click);
            // 
            // lbl_musteriTC
            // 
            this.lbl_musteriTC.AutoSize = true;
            this.lbl_musteriTC.Location = new System.Drawing.Point(153, 8);
            this.lbl_musteriTC.Name = "lbl_musteriTC";
            this.lbl_musteriTC.Size = new System.Drawing.Size(166, 13);
            this.lbl_musteriTC.TabIndex = 9;
            this.lbl_musteriTC.Text = "Müşteri TC Kimlik Numarası Giriniz";
            // 
            // txt_tcArama
            // 
            this.txt_tcArama.Location = new System.Drawing.Point(156, 24);
            this.txt_tcArama.Name = "txt_tcArama";
            this.txt_tcArama.Size = new System.Drawing.Size(163, 20);
            this.txt_tcArama.TabIndex = 8;
            // 
            // dgv_musteriGoruntuleme
            // 
            this.dgv_musteriGoruntuleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteriGoruntuleme.Location = new System.Drawing.Point(12, 143);
            this.dgv_musteriGoruntuleme.Name = "dgv_musteriGoruntuleme";
            this.dgv_musteriGoruntuleme.Size = new System.Drawing.Size(776, 300);
            this.dgv_musteriGoruntuleme.TabIndex = 7;
            // 
            // btn_musteriSil
            // 
            this.btn_musteriSil.Location = new System.Drawing.Point(156, 79);
            this.btn_musteriSil.Name = "btn_musteriSil";
            this.btn_musteriSil.Size = new System.Drawing.Size(163, 23);
            this.btn_musteriSil.TabIndex = 14;
            this.btn_musteriSil.Text = "Müşteri Sil";
            this.btn_musteriSil.UseVisualStyleBackColor = true;
            this.btn_musteriSil.Click += new System.EventHandler(this.btn_musteriSil_Click);
            // 
            // MusteriSilmeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_musteriSil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_musteriAra);
            this.Controls.Add(this.lbl_musteriTC);
            this.Controls.Add(this.txt_tcArama);
            this.Controls.Add(this.dgv_musteriGoruntuleme);
            this.Name = "MusteriSilmeEkrani";
            this.Text = "MusteriSilmeEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriGoruntuleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_musteriAra;
        private System.Windows.Forms.Label lbl_musteriTC;
        private System.Windows.Forms.TextBox txt_tcArama;
        private System.Windows.Forms.DataGridView dgv_musteriGoruntuleme;
        private System.Windows.Forms.Button btn_musteriSil;
    }
}