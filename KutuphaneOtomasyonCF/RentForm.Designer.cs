namespace KutuphaneOtomasyonCF
{
    partial class RentForm
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
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.cmbUyeler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKiraID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVerisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lstKiralar = new System.Windows.Forms.ListBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnIadeEt = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(12, 38);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKitaplar.Size = new System.Drawing.Size(219, 264);
            this.lstKitaplar.TabIndex = 1;
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.Location = new System.Drawing.Point(310, 63);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(172, 21);
            this.cmbUyeler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uyeler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kira ID:";
            // 
            // txtKiraID
            // 
            this.txtKiraID.Enabled = false;
            this.txtKiraID.Location = new System.Drawing.Point(310, 36);
            this.txtKiraID.Name = "txtKiraID";
            this.txtKiraID.Size = new System.Drawing.Size(172, 20);
            this.txtKiraID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iade Tarihi:";
            this.label3.Visible = false;
            // 
            // dtpVerisTarihi
            // 
            this.dtpVerisTarihi.Location = new System.Drawing.Point(310, 92);
            this.dtpVerisTarihi.Name = "dtpVerisTarihi";
            this.dtpVerisTarihi.Size = new System.Drawing.Size(172, 20);
            this.dtpVerisTarihi.TabIndex = 8;
            this.dtpVerisTarihi.Visible = false;
            // 
            // lstKiralar
            // 
            this.lstKiralar.FormattingEnabled = true;
            this.lstKiralar.Location = new System.Drawing.Point(497, 36);
            this.lstKiralar.Name = "lstKiralar";
            this.lstKiralar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKiralar.Size = new System.Drawing.Size(219, 264);
            this.lstKiralar.TabIndex = 9;
            this.lstKiralar.SelectedIndexChanged += new System.EventHandler(this.lstKira_SelectedIndexChanged);
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(310, 121);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(172, 23);
            this.btnKirala.TabIndex = 10;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.Location = new System.Drawing.Point(310, 150);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(172, 23);
            this.btnIadeEt.TabIndex = 11;
            this.btnIadeEt.Text = "Iade Et";
            this.btnIadeEt.UseVisualStyleBackColor = true;
            this.btnIadeEt.Visible = false;
            this.btnIadeEt.Click += new System.EventHandler(this.btnIadeEt_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(219, 20);
            this.txtAra.TabIndex = 12;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 345);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnIadeEt);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.lstKiralar);
            this.Controls.Add(this.dtpVerisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKiraID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUyeler);
            this.Controls.Add(this.lstKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.ComboBox cmbUyeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKiraID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVerisTarihi;
        private System.Windows.Forms.ListBox lstKiralar;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Button btnIadeEt;
        private System.Windows.Forms.TextBox txtAra;
    }
}