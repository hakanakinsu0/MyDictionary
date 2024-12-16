namespace Project.WinFormUI
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
            this.LstKategoriler = new System.Windows.Forms.ListBox();
            this.LstKavramlar = new System.Windows.Forms.ListBox();
            this.BtnKategoriEkle = new System.Windows.Forms.Button();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKategoriSil = new System.Windows.Forms.Button();
            this.BtnKategoriYokEt = new System.Windows.Forms.Button();
            this.BtnKavramEkle = new System.Windows.Forms.Button();
            this.TxtKavram = new System.Windows.Forms.TextBox();
            this.TxtKavramAciklama = new System.Windows.Forms.TextBox();
            this.BtnKavramGuncelle = new System.Windows.Forms.Button();
            this.BtnKavramSil = new System.Windows.Forms.Button();
            this.BtnKavramYokEt = new System.Windows.Forms.Button();
            this.BtnTumunuGetir = new System.Windows.Forms.Button();
            this.BtnButunKavramlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstKategoriler
            // 
            this.LstKategoriler.FormattingEnabled = true;
            this.LstKategoriler.Location = new System.Drawing.Point(663, 21);
            this.LstKategoriler.Name = "LstKategoriler";
            this.LstKategoriler.Size = new System.Drawing.Size(710, 264);
            this.LstKategoriler.TabIndex = 0;
            this.LstKategoriler.Click += new System.EventHandler(this.LstKategoriler_Click);
            // 
            // LstKavramlar
            // 
            this.LstKavramlar.FormattingEnabled = true;
            this.LstKavramlar.Location = new System.Drawing.Point(663, 317);
            this.LstKavramlar.Name = "LstKavramlar";
            this.LstKavramlar.Size = new System.Drawing.Size(710, 264);
            this.LstKavramlar.TabIndex = 1;
            this.LstKavramlar.Click += new System.EventHandler(this.LstKavramlar_Click);
            // 
            // BtnKategoriEkle
            // 
            this.BtnKategoriEkle.Location = new System.Drawing.Point(12, 56);
            this.BtnKategoriEkle.Name = "BtnKategoriEkle";
            this.BtnKategoriEkle.Size = new System.Drawing.Size(105, 23);
            this.BtnKategoriEkle.TabIndex = 2;
            this.BtnKategoriEkle.Text = "Kategori Ekle";
            this.BtnKategoriEkle.UseVisualStyleBackColor = true;
            this.BtnKategoriEkle.Click += new System.EventHandler(this.BtnKategoriEkle_Click);
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(12, 21);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(437, 20);
            this.TxtKategori.TabIndex = 3;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(122, 56);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(105, 23);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Kategori Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKategoriSil
            // 
            this.BtnKategoriSil.Location = new System.Drawing.Point(233, 56);
            this.BtnKategoriSil.Name = "BtnKategoriSil";
            this.BtnKategoriSil.Size = new System.Drawing.Size(105, 23);
            this.BtnKategoriSil.TabIndex = 5;
            this.BtnKategoriSil.Text = "Kategori Sil";
            this.BtnKategoriSil.UseVisualStyleBackColor = true;
            this.BtnKategoriSil.Click += new System.EventHandler(this.BtnKategoriSil_Click);
            // 
            // BtnKategoriYokEt
            // 
            this.BtnKategoriYokEt.Location = new System.Drawing.Point(344, 56);
            this.BtnKategoriYokEt.Name = "BtnKategoriYokEt";
            this.BtnKategoriYokEt.Size = new System.Drawing.Size(105, 23);
            this.BtnKategoriYokEt.TabIndex = 6;
            this.BtnKategoriYokEt.Text = "Kategori Yok Et";
            this.BtnKategoriYokEt.UseVisualStyleBackColor = true;
            this.BtnKategoriYokEt.Click += new System.EventHandler(this.BtnKategoriYokEt_Click);
            // 
            // BtnKavramEkle
            // 
            this.BtnKavramEkle.Location = new System.Drawing.Point(12, 369);
            this.BtnKavramEkle.Name = "BtnKavramEkle";
            this.BtnKavramEkle.Size = new System.Drawing.Size(105, 23);
            this.BtnKavramEkle.TabIndex = 7;
            this.BtnKavramEkle.Text = "Kavram Ekle";
            this.BtnKavramEkle.UseVisualStyleBackColor = true;
            this.BtnKavramEkle.Click += new System.EventHandler(this.BtnKavramEkle_Click);
            // 
            // TxtKavram
            // 
            this.TxtKavram.Location = new System.Drawing.Point(12, 317);
            this.TxtKavram.Name = "TxtKavram";
            this.TxtKavram.Size = new System.Drawing.Size(437, 20);
            this.TxtKavram.TabIndex = 8;
            // 
            // TxtKavramAciklama
            // 
            this.TxtKavramAciklama.Location = new System.Drawing.Point(12, 343);
            this.TxtKavramAciklama.Name = "TxtKavramAciklama";
            this.TxtKavramAciklama.Size = new System.Drawing.Size(437, 20);
            this.TxtKavramAciklama.TabIndex = 9;
            // 
            // BtnKavramGuncelle
            // 
            this.BtnKavramGuncelle.Location = new System.Drawing.Point(122, 369);
            this.BtnKavramGuncelle.Name = "BtnKavramGuncelle";
            this.BtnKavramGuncelle.Size = new System.Drawing.Size(105, 23);
            this.BtnKavramGuncelle.TabIndex = 10;
            this.BtnKavramGuncelle.Text = "Kavram Guncelle";
            this.BtnKavramGuncelle.UseVisualStyleBackColor = true;
            this.BtnKavramGuncelle.Click += new System.EventHandler(this.BtnKavramGuncelle_Click);
            // 
            // BtnKavramSil
            // 
            this.BtnKavramSil.Location = new System.Drawing.Point(233, 369);
            this.BtnKavramSil.Name = "BtnKavramSil";
            this.BtnKavramSil.Size = new System.Drawing.Size(104, 23);
            this.BtnKavramSil.TabIndex = 11;
            this.BtnKavramSil.Text = "Kavram Sil";
            this.BtnKavramSil.UseVisualStyleBackColor = true;
            this.BtnKavramSil.Click += new System.EventHandler(this.BtnKavramSil_Click);
            // 
            // BtnKavramYokEt
            // 
            this.BtnKavramYokEt.Location = new System.Drawing.Point(343, 369);
            this.BtnKavramYokEt.Name = "BtnKavramYokEt";
            this.BtnKavramYokEt.Size = new System.Drawing.Size(104, 23);
            this.BtnKavramYokEt.TabIndex = 12;
            this.BtnKavramYokEt.Text = "Kavram Yok Et";
            this.BtnKavramYokEt.UseVisualStyleBackColor = true;
            this.BtnKavramYokEt.Click += new System.EventHandler(this.BtnKavramYokEt_Click);
            // 
            // BtnTumunuGetir
            // 
            this.BtnTumunuGetir.Location = new System.Drawing.Point(13, 472);
            this.BtnTumunuGetir.Name = "BtnTumunuGetir";
            this.BtnTumunuGetir.Size = new System.Drawing.Size(436, 23);
            this.BtnTumunuGetir.TabIndex = 13;
            this.BtnTumunuGetir.Text = "Secili Kategorideki Tum Kavramlari Getir";
            this.BtnTumunuGetir.UseVisualStyleBackColor = true;
            this.BtnTumunuGetir.Click += new System.EventHandler(this.BtnTumunuGetir_Click);
            // 
            // BtnButunKavramlar
            // 
            this.BtnButunKavramlar.Location = new System.Drawing.Point(13, 516);
            this.BtnButunKavramlar.Name = "BtnButunKavramlar";
            this.BtnButunKavramlar.Size = new System.Drawing.Size(434, 23);
            this.BtnButunKavramlar.TabIndex = 14;
            this.BtnButunKavramlar.Text = "Guncel Butun Kavramlari Getir";
            this.BtnButunKavramlar.UseVisualStyleBackColor = true;
            this.BtnButunKavramlar.Click += new System.EventHandler(this.BtnButunKavramlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 682);
            this.Controls.Add(this.BtnButunKavramlar);
            this.Controls.Add(this.BtnTumunuGetir);
            this.Controls.Add(this.BtnKavramYokEt);
            this.Controls.Add(this.BtnKavramSil);
            this.Controls.Add(this.BtnKavramGuncelle);
            this.Controls.Add(this.TxtKavramAciklama);
            this.Controls.Add(this.TxtKavram);
            this.Controls.Add(this.BtnKavramEkle);
            this.Controls.Add(this.BtnKategoriYokEt);
            this.Controls.Add(this.BtnKategoriSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.BtnKategoriEkle);
            this.Controls.Add(this.LstKavramlar);
            this.Controls.Add(this.LstKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstKategoriler;
        private System.Windows.Forms.ListBox LstKavramlar;
        private System.Windows.Forms.Button BtnKategoriEkle;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKategoriSil;
        private System.Windows.Forms.Button BtnKategoriYokEt;
        private System.Windows.Forms.Button BtnKavramEkle;
        private System.Windows.Forms.TextBox TxtKavram;
        private System.Windows.Forms.TextBox TxtKavramAciklama;
        private System.Windows.Forms.Button BtnKavramGuncelle;
        private System.Windows.Forms.Button BtnKavramSil;
        private System.Windows.Forms.Button BtnKavramYokEt;
        private System.Windows.Forms.Button BtnTumunuGetir;
        private System.Windows.Forms.Button BtnButunKavramlar;
    }
}

