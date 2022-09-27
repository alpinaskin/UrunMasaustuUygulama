
namespace UrunMasaustuUygulama.View
{
    partial class UrunView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUrunler = new System.Windows.Forms.TabPage();
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.ButtonUrunSil = new System.Windows.Forms.Button();
            this.buttonUrunDuzenle = new System.Windows.Forms.Button();
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            this.buttonUrunAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUrunAra = new System.Windows.Forms.TextBox();
            this.tabPageUrunDetay = new System.Windows.Forms.TabPage();
            this.tabPageUrunDetayText = new System.Windows.Forms.Label();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.buttonUrunKaydet = new System.Windows.Forms.Button();
            this.richTextBoxUrunAciklamasi = new System.Windows.Forms.RichTextBox();
            this.textBoxUrunRenk = new System.Windows.Forms.TextBox();
            this.textBoxUrunFiyat = new System.Windows.Forms.TextBox();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.textBoxUrunId = new System.Windows.Forms.TextBox();
            this.labelUrunAciklama = new System.Windows.Forms.Label();
            this.labelUrunRenk = new System.Windows.Forms.Label();
            this.labelUrunFiyat = new System.Windows.Forms.Label();
            this.labelUrunAdi = new System.Windows.Forms.Label();
            this.labelUrunId = new System.Windows.Forms.Label();
            this.tabPageSatilanUrunler = new System.Windows.Forms.TabPage();
            this.dataGridViewSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.tabPageUrunDetay.SuspendLayout();
            this.tabPageSatilanUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 38);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Location = new System.Drawing.Point(636, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 25);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Kapat";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜNLER";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabUrunler);
            this.tabControl1.Controls.Add(this.tabPageUrunDetay);
            this.tabControl1.Controls.Add(this.tabPageSatilanUrunler);
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 378);
            this.tabControl1.TabIndex = 1;
            // 
            // tabUrunler
            // 
            this.tabUrunler.Controls.Add(this.dataGridViewUrunler);
            this.tabUrunler.Controls.Add(this.ButtonUrunSil);
            this.tabUrunler.Controls.Add(this.buttonUrunDuzenle);
            this.tabUrunler.Controls.Add(this.buttonUrunEkle);
            this.tabUrunler.Controls.Add(this.buttonUrunAra);
            this.tabUrunler.Controls.Add(this.label2);
            this.tabUrunler.Controls.Add(this.textBoxUrunAra);
            this.tabUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabUrunler.Name = "tabUrunler";
            this.tabUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunler.Size = new System.Drawing.Size(721, 352);
            this.tabUrunler.TabIndex = 0;
            this.tabUrunler.Text = "Ürünler";
            this.tabUrunler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.AllowUserToAddRows = false;
            this.dataGridViewUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Location = new System.Drawing.Point(41, 47);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.RowHeadersWidth = 30;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(518, 265);
            this.dataGridViewUrunler.TabIndex = 6;
            // 
            // ButtonUrunSil
            // 
            this.ButtonUrunSil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonUrunSil.Location = new System.Drawing.Point(632, 114);
            this.ButtonUrunSil.Name = "ButtonUrunSil";
            this.ButtonUrunSil.Size = new System.Drawing.Size(73, 27);
            this.ButtonUrunSil.TabIndex = 5;
            this.ButtonUrunSil.Text = "Sil";
            this.ButtonUrunSil.UseVisualStyleBackColor = true;
            // 
            // buttonUrunDuzenle
            // 
            this.buttonUrunDuzenle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUrunDuzenle.Location = new System.Drawing.Point(632, 85);
            this.buttonUrunDuzenle.Name = "buttonUrunDuzenle";
            this.buttonUrunDuzenle.Size = new System.Drawing.Size(73, 27);
            this.buttonUrunDuzenle.TabIndex = 4;
            this.buttonUrunDuzenle.Text = "Düzenle";
            this.buttonUrunDuzenle.UseVisualStyleBackColor = true;
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUrunEkle.Location = new System.Drawing.Point(632, 56);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(73, 27);
            this.buttonUrunEkle.TabIndex = 3;
            this.buttonUrunEkle.Text = "Ekle";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            // 
            // buttonUrunAra
            // 
            this.buttonUrunAra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUrunAra.Location = new System.Drawing.Point(484, 19);
            this.buttonUrunAra.Name = "buttonUrunAra";
            this.buttonUrunAra.Size = new System.Drawing.Size(75, 23);
            this.buttonUrunAra.TabIndex = 2;
            this.buttonUrunAra.Text = "Ara";
            this.buttonUrunAra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Ara";
            // 
            // textBoxUrunAra
            // 
            this.textBoxUrunAra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUrunAra.Location = new System.Drawing.Point(41, 21);
            this.textBoxUrunAra.Name = "textBoxUrunAra";
            this.textBoxUrunAra.Size = new System.Drawing.Size(437, 20);
            this.textBoxUrunAra.TabIndex = 0;
            // 
            // tabPageUrunDetay
            // 
            this.tabPageUrunDetay.Controls.Add(this.tabPageUrunDetayText);
            this.tabPageUrunDetay.Controls.Add(this.buttonIptal);
            this.tabPageUrunDetay.Controls.Add(this.buttonUrunKaydet);
            this.tabPageUrunDetay.Controls.Add(this.richTextBoxUrunAciklamasi);
            this.tabPageUrunDetay.Controls.Add(this.textBoxUrunRenk);
            this.tabPageUrunDetay.Controls.Add(this.textBoxUrunFiyat);
            this.tabPageUrunDetay.Controls.Add(this.textBoxUrunAdi);
            this.tabPageUrunDetay.Controls.Add(this.textBoxUrunId);
            this.tabPageUrunDetay.Controls.Add(this.labelUrunAciklama);
            this.tabPageUrunDetay.Controls.Add(this.labelUrunRenk);
            this.tabPageUrunDetay.Controls.Add(this.labelUrunFiyat);
            this.tabPageUrunDetay.Controls.Add(this.labelUrunAdi);
            this.tabPageUrunDetay.Controls.Add(this.labelUrunId);
            this.tabPageUrunDetay.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunDetay.Name = "tabPageUrunDetay";
            this.tabPageUrunDetay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunDetay.Size = new System.Drawing.Size(721, 352);
            this.tabPageUrunDetay.TabIndex = 1;
            this.tabPageUrunDetay.Text = "Ürün Detay";
            this.tabPageUrunDetay.UseVisualStyleBackColor = true;
            // 
            // tabPageUrunDetayText
            // 
            this.tabPageUrunDetayText.AutoSize = true;
            this.tabPageUrunDetayText.Location = new System.Drawing.Point(38, 17);
            this.tabPageUrunDetayText.Name = "tabPageUrunDetayText";
            this.tabPageUrunDetayText.Size = new System.Drawing.Size(0, 13);
            this.tabPageUrunDetayText.TabIndex = 12;
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(435, 233);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 11;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // buttonUrunKaydet
            // 
            this.buttonUrunKaydet.Location = new System.Drawing.Point(435, 186);
            this.buttonUrunKaydet.Name = "buttonUrunKaydet";
            this.buttonUrunKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonUrunKaydet.TabIndex = 10;
            this.buttonUrunKaydet.Text = "Kaydet";
            this.buttonUrunKaydet.UseVisualStyleBackColor = true;
            // 
            // richTextBoxUrunAciklamasi
            // 
            this.richTextBoxUrunAciklamasi.Location = new System.Drawing.Point(41, 186);
            this.richTextBoxUrunAciklamasi.Name = "richTextBoxUrunAciklamasi";
            this.richTextBoxUrunAciklamasi.Size = new System.Drawing.Size(271, 70);
            this.richTextBoxUrunAciklamasi.TabIndex = 9;
            this.richTextBoxUrunAciklamasi.Text = "";
            // 
            // textBoxUrunRenk
            // 
            this.textBoxUrunRenk.Location = new System.Drawing.Point(435, 121);
            this.textBoxUrunRenk.Name = "textBoxUrunRenk";
            this.textBoxUrunRenk.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunRenk.TabIndex = 8;
            // 
            // textBoxUrunFiyat
            // 
            this.textBoxUrunFiyat.Location = new System.Drawing.Point(212, 121);
            this.textBoxUrunFiyat.Name = "textBoxUrunFiyat";
            this.textBoxUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunFiyat.TabIndex = 7;
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(41, 121);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunAdi.TabIndex = 6;
            // 
            // textBoxUrunId
            // 
            this.textBoxUrunId.Location = new System.Drawing.Point(41, 64);
            this.textBoxUrunId.Name = "textBoxUrunId";
            this.textBoxUrunId.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunId.TabIndex = 5;
            // 
            // labelUrunAciklama
            // 
            this.labelUrunAciklama.AutoSize = true;
            this.labelUrunAciklama.Location = new System.Drawing.Point(38, 161);
            this.labelUrunAciklama.Name = "labelUrunAciklama";
            this.labelUrunAciklama.Size = new System.Drawing.Size(83, 13);
            this.labelUrunAciklama.TabIndex = 4;
            this.labelUrunAciklama.Text = "Ürün Açıklaması";
            // 
            // labelUrunRenk
            // 
            this.labelUrunRenk.AutoSize = true;
            this.labelUrunRenk.Location = new System.Drawing.Point(432, 96);
            this.labelUrunRenk.Name = "labelUrunRenk";
            this.labelUrunRenk.Size = new System.Drawing.Size(61, 13);
            this.labelUrunRenk.TabIndex = 3;
            this.labelUrunRenk.Text = "Ürün Rengi";
            // 
            // labelUrunFiyat
            // 
            this.labelUrunFiyat.AutoSize = true;
            this.labelUrunFiyat.Location = new System.Drawing.Point(209, 96);
            this.labelUrunFiyat.Name = "labelUrunFiyat";
            this.labelUrunFiyat.Size = new System.Drawing.Size(57, 13);
            this.labelUrunFiyat.TabIndex = 2;
            this.labelUrunFiyat.Text = "Ürün Fiyatı";
            // 
            // labelUrunAdi
            // 
            this.labelUrunAdi.AutoSize = true;
            this.labelUrunAdi.Location = new System.Drawing.Point(38, 96);
            this.labelUrunAdi.Name = "labelUrunAdi";
            this.labelUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.labelUrunAdi.TabIndex = 1;
            this.labelUrunAdi.Text = "Ürün Adı";
            // 
            // labelUrunId
            // 
            this.labelUrunId.AutoSize = true;
            this.labelUrunId.Location = new System.Drawing.Point(38, 48);
            this.labelUrunId.Name = "labelUrunId";
            this.labelUrunId.Size = new System.Drawing.Size(44, 13);
            this.labelUrunId.TabIndex = 0;
            this.labelUrunId.Text = "Ürün ID";
            // 
            // tabPageSatilanUrunler
            // 
            this.tabPageSatilanUrunler.Controls.Add(this.dataGridViewSatilanUrunler);
            this.tabPageSatilanUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabPageSatilanUrunler.Name = "tabPageSatilanUrunler";
            this.tabPageSatilanUrunler.Size = new System.Drawing.Size(721, 352);
            this.tabPageSatilanUrunler.TabIndex = 2;
            this.tabPageSatilanUrunler.Text = "Satılan Ürünler";
            this.tabPageSatilanUrunler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSatilanUrunler
            // 
            this.dataGridViewSatilanUrunler.AllowUserToAddRows = false;
            this.dataGridViewSatilanUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewSatilanUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatilanUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatilanUrunler.Location = new System.Drawing.Point(41, 47);
            this.dataGridViewSatilanUrunler.Name = "dataGridViewSatilanUrunler";
            this.dataGridViewSatilanUrunler.Size = new System.Drawing.Size(532, 260);
            this.dataGridViewSatilanUrunler.TabIndex = 0;
            // 
            // UrunView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 422);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "UrunView";
            this.Text = "UrunView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabUrunler.ResumeLayout(false);
            this.tabUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.tabPageUrunDetay.ResumeLayout(false);
            this.tabPageUrunDetay.PerformLayout();
            this.tabPageSatilanUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatilanUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUrunler;
        private System.Windows.Forms.Button ButtonUrunSil;
        private System.Windows.Forms.Button buttonUrunDuzenle;
        private System.Windows.Forms.Button buttonUrunEkle;
        private System.Windows.Forms.Button buttonUrunAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUrunAra;
        private System.Windows.Forms.TabPage tabPageUrunDetay;
        private System.Windows.Forms.DataGridView dataGridViewUrunler;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Button buttonUrunKaydet;
        private System.Windows.Forms.RichTextBox richTextBoxUrunAciklamasi;
        private System.Windows.Forms.TextBox textBoxUrunRenk;
        private System.Windows.Forms.TextBox textBoxUrunFiyat;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunId;
        private System.Windows.Forms.Label labelUrunAciklama;
        private System.Windows.Forms.Label labelUrunRenk;
        private System.Windows.Forms.Label labelUrunFiyat;
        private System.Windows.Forms.Label labelUrunAdi;
        private System.Windows.Forms.Label labelUrunId;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label tabPageUrunDetayText;
        private System.Windows.Forms.TabPage tabPageSatilanUrunler;
        private System.Windows.Forms.DataGridView dataGridViewSatilanUrunler;
    }
}