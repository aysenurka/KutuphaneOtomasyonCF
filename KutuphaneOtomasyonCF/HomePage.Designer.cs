namespace KutuphaneOtomasyonCF
{
    partial class HomePage
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
            this.msIslemler = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIslemler
            // 
            this.msIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.msIslemler.Location = new System.Drawing.Point(0, 0);
            this.msIslemler.Name = "msIslemler";
            this.msIslemler.Size = new System.Drawing.Size(800, 24);
            this.msIslemler.TabIndex = 1;
            this.msIslemler.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyeEkleToolStripMenuItem,
            this.kitapEkleToolStripMenuItem,
            this.yazarEkleToolStripMenuItem,
            this.kiralaToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ekleToolStripMenuItem.Text = "Islemler";
            // 
            // uyeEkleToolStripMenuItem
            // 
            this.uyeEkleToolStripMenuItem.Name = "uyeEkleToolStripMenuItem";
            this.uyeEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.uyeEkleToolStripMenuItem.Text = "Uye Ekle";
            this.uyeEkleToolStripMenuItem.Click += new System.EventHandler(this.uyeEkleToolStripMenuItem_Click);
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // yazarEkleToolStripMenuItem
            // 
            this.yazarEkleToolStripMenuItem.Name = "yazarEkleToolStripMenuItem";
            this.yazarEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.yazarEkleToolStripMenuItem.Text = "Yazar Ekle";
            this.yazarEkleToolStripMenuItem.Click += new System.EventHandler(this.yazarEkleToolStripMenuItem_Click);
            // 
            // kiralaToolStripMenuItem
            // 
            this.kiralaToolStripMenuItem.Name = "kiralaToolStripMenuItem";
            this.kiralaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kiralaToolStripMenuItem.Text = "Kirala";
            this.kiralaToolStripMenuItem.Click += new System.EventHandler(this.kiralaToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonCF.Properties.Resources.Kutuphane;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msIslemler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIslemler;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.msIslemler.ResumeLayout(false);
            this.msIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIslemler;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarEkleToolStripMenuItem;
    }
}

