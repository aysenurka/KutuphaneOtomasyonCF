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
            this.lstKitap = new System.Windows.Forms.ListBox();
            this.cmbUyeler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKiraID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstKira = new System.Windows.Forms.ListBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnIadeEt = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstKitap
            // 
            this.lstKitap.FormattingEnabled = true;
            this.lstKitap.Location = new System.Drawing.Point(12, 38);
            this.lstKitap.Name = "lstKitap";
            this.lstKitap.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKitap.Size = new System.Drawing.Size(219, 264);
            this.lstKitap.TabIndex = 1;
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.Location = new System.Drawing.Point(322, 67);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(172, 21);
            this.cmbUyeler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uyeler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kira ID:";
            // 
            // txtKiraID
            // 
            this.txtKiraID.Enabled = false;
            this.txtKiraID.Location = new System.Drawing.Point(322, 38);
            this.txtKiraID.Name = "txtKiraID";
            this.txtKiraID.Size = new System.Drawing.Size(172, 20);
            this.txtKiraID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kiralama Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lstKira
            // 
            this.lstKira.FormattingEnabled = true;
            this.lstKira.Location = new System.Drawing.Point(509, 38);
            this.lstKira.Name = "lstKira";
            this.lstKira.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKira.Size = new System.Drawing.Size(219, 264);
            this.lstKira.TabIndex = 9;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(322, 123);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(172, 23);
            this.btnKirala.TabIndex = 10;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.Location = new System.Drawing.Point(322, 152);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(172, 23);
            this.btnIadeEt.TabIndex = 11;
            this.btnIadeEt.Text = "Iade Et";
            this.btnIadeEt.UseVisualStyleBackColor = true;
            this.btnIadeEt.Visible = false;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(219, 20);
            this.txtAra.TabIndex = 12;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 345);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnIadeEt);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.lstKira);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKiraID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUyeler);
            this.Controls.Add(this.lstKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitap;
        private System.Windows.Forms.ComboBox cmbUyeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKiraID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstKira;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Button btnIadeEt;
        private System.Windows.Forms.TextBox txtAra;
    }
}