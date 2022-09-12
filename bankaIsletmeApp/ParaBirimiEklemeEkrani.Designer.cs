
namespace bankaIsletmeApp
{
    partial class ParaBirimiEklemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaBirimiEklemeEkrani));
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.txt_yeniParaBirimi = new System.Windows.Forms.TextBox();
            this.btn_paraBirimiEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(156, 42);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(319, 13);
            this.lbl_bilgi.TabIndex = 0;
            this.lbl_bilgi.Text = "Lütfen eklemek istediğiniz para birimi kodunu kısaltma olarak giriniz";
            // 
            // txt_yeniParaBirimi
            // 
            this.txt_yeniParaBirimi.Location = new System.Drawing.Point(159, 58);
            this.txt_yeniParaBirimi.Name = "txt_yeniParaBirimi";
            this.txt_yeniParaBirimi.Size = new System.Drawing.Size(316, 20);
            this.txt_yeniParaBirimi.TabIndex = 1;
            // 
            // btn_paraBirimiEkle
            // 
            this.btn_paraBirimiEkle.Location = new System.Drawing.Point(159, 84);
            this.btn_paraBirimiEkle.Name = "btn_paraBirimiEkle";
            this.btn_paraBirimiEkle.Size = new System.Drawing.Size(316, 23);
            this.btn_paraBirimiEkle.TabIndex = 2;
            this.btn_paraBirimiEkle.Text = "Ekle";
            this.btn_paraBirimiEkle.UseVisualStyleBackColor = true;
            this.btn_paraBirimiEkle.Click += new System.EventHandler(this.btn_paraBirimiEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ParaBirimiEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 168);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_paraBirimiEkle);
            this.Controls.Add(this.txt_yeniParaBirimi);
            this.Controls.Add(this.lbl_bilgi);
            this.Name = "ParaBirimiEklemeEkrani";
            this.Text = "ParaBirimiEklemeEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.TextBox txt_yeniParaBirimi;
        private System.Windows.Forms.Button btn_paraBirimiEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}