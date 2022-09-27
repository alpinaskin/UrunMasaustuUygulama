
namespace UrunMasaustuUygulama.View
{
    partial class MusteriView
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMusteriler = new System.Windows.Forms.TabPage();
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            this.buttonAlinanUrunler = new System.Windows.Forms.Button();
            this.buttonUrunAra = new System.Windows.Forms.Button();
            this.lblMusteriAra = new System.Windows.Forms.Label();
            this.txtBoxMusteriAra = new System.Windows.Forms.TextBox();
            this.tabPageAlinanUrunler = new System.Windows.Forms.TabPage();
            this.dataGridViewAlinanUrunler = new System.Windows.Forms.DataGridView();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.tabPageAlinanUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlinanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 38);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(636, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MÜŞTERİLER";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMusteriler);
            this.tabControl1.Controls.Add(this.tabPageAlinanUrunler);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 378);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageMusteriler
            // 
            this.tabPageMusteriler.Controls.Add(this.dataGridViewMusteriler);
            this.tabPageMusteriler.Controls.Add(this.buttonAlinanUrunler);
            this.tabPageMusteriler.Controls.Add(this.buttonUrunAra);
            this.tabPageMusteriler.Controls.Add(this.lblMusteriAra);
            this.tabPageMusteriler.Controls.Add(this.txtBoxMusteriAra);
            this.tabPageMusteriler.Location = new System.Drawing.Point(4, 22);
            this.tabPageMusteriler.Name = "tabPageMusteriler";
            this.tabPageMusteriler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMusteriler.Size = new System.Drawing.Size(735, 352);
            this.tabPageMusteriler.TabIndex = 0;
            this.tabPageMusteriler.Text = "Müşteriler";
            this.tabPageMusteriler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AllowUserToAddRows = false;
            this.dataGridViewMusteriler.AllowUserToDeleteRows = false;
            this.dataGridViewMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(41, 56);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(518, 255);
            this.dataGridViewMusteriler.TabIndex = 6;
            // 
            // buttonAlinanUrunler
            // 
            this.buttonAlinanUrunler.Location = new System.Drawing.Point(632, 56);
            this.buttonAlinanUrunler.Name = "buttonAlinanUrunler";
            this.buttonAlinanUrunler.Size = new System.Drawing.Size(83, 27);
            this.buttonAlinanUrunler.TabIndex = 3;
            this.buttonAlinanUrunler.Text = "Alınan Ürünler";
            this.buttonAlinanUrunler.UseVisualStyleBackColor = true;
            // 
            // buttonUrunAra
            // 
            this.buttonUrunAra.Location = new System.Drawing.Point(484, 28);
            this.buttonUrunAra.Name = "buttonUrunAra";
            this.buttonUrunAra.Size = new System.Drawing.Size(75, 23);
            this.buttonUrunAra.TabIndex = 2;
            this.buttonUrunAra.Text = "Ara";
            this.buttonUrunAra.UseVisualStyleBackColor = true;
            // 
            // lblMusteriAra
            // 
            this.lblMusteriAra.AutoSize = true;
            this.lblMusteriAra.Location = new System.Drawing.Point(38, 14);
            this.lblMusteriAra.Name = "lblMusteriAra";
            this.lblMusteriAra.Size = new System.Drawing.Size(60, 13);
            this.lblMusteriAra.TabIndex = 1;
            this.lblMusteriAra.Text = "Müşteri Ara";
            // 
            // txtBoxMusteriAra
            // 
            this.txtBoxMusteriAra.Location = new System.Drawing.Point(41, 30);
            this.txtBoxMusteriAra.Name = "txtBoxMusteriAra";
            this.txtBoxMusteriAra.Size = new System.Drawing.Size(437, 20);
            this.txtBoxMusteriAra.TabIndex = 0;
            // 
            // tabPageAlinanUrunler
            // 
            this.tabPageAlinanUrunler.Controls.Add(this.dataGridViewAlinanUrunler);
            this.tabPageAlinanUrunler.Controls.Add(this.buttonIptal);
            this.tabPageAlinanUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlinanUrunler.Name = "tabPageAlinanUrunler";
            this.tabPageAlinanUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlinanUrunler.Size = new System.Drawing.Size(792, 352);
            this.tabPageAlinanUrunler.TabIndex = 1;
            this.tabPageAlinanUrunler.Text = "Alınan Ürünler";
            this.tabPageAlinanUrunler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAlinanUrunler
            // 
            this.dataGridViewAlinanUrunler.AllowUserToAddRows = false;
            this.dataGridViewAlinanUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewAlinanUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlinanUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlinanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlinanUrunler.Location = new System.Drawing.Point(41, 46);
            this.dataGridViewAlinanUrunler.Name = "dataGridViewAlinanUrunler";
            this.dataGridViewAlinanUrunler.Size = new System.Drawing.Size(518, 180);
            this.dataGridViewAlinanUrunler.TabIndex = 12;
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(632, 46);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(73, 23);
            this.buttonIptal.TabIndex = 11;
            this.buttonIptal.Text = "Geri";
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // MusteriView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MusteriView";
            this.Text = "MusteriView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMusteriler.ResumeLayout(false);
            this.tabPageMusteriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.tabPageAlinanUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlinanUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMusteriler;
        private System.Windows.Forms.DataGridView dataGridViewMusteriler;
        private System.Windows.Forms.Button buttonAlinanUrunler;
        private System.Windows.Forms.Button buttonUrunAra;
        private System.Windows.Forms.Label lblMusteriAra;
        private System.Windows.Forms.TextBox txtBoxMusteriAra;
        private System.Windows.Forms.TabPage tabPageAlinanUrunler;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.DataGridView dataGridViewAlinanUrunler;
    }
}