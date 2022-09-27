
namespace UrunMasaustuUygulama.View
{
    partial class MainView
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
            this.buttonMusteri = new System.Windows.Forms.Button();
            this.buttonUrun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMusteri);
            this.panel1.Controls.Add(this.buttonUrun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 436);
            this.panel1.TabIndex = 0;
            // 
            // buttonMusteri
            // 
            this.buttonMusteri.Location = new System.Drawing.Point(0, 100);
            this.buttonMusteri.Name = "buttonMusteri";
            this.buttonMusteri.Size = new System.Drawing.Size(148, 40);
            this.buttonMusteri.TabIndex = 1;
            this.buttonMusteri.Text = "Müşteriler";
            this.buttonMusteri.UseVisualStyleBackColor = true;
            // 
            // buttonUrun
            // 
            this.buttonUrun.Location = new System.Drawing.Point(0, 40);
            this.buttonUrun.Name = "buttonUrun";
            this.buttonUrun.Size = new System.Drawing.Size(148, 40);
            this.buttonUrun.TabIndex = 0;
            this.buttonUrun.Text = "Ürünler";
            this.buttonUrun.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 436);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMusteri;
        private System.Windows.Forms.Button buttonUrun;
    }
}