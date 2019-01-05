using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonCF.Entities;
using KutuphaneOtomasyonCF.Helpers;
using KutuphaneOtomasyonCF.ViewModels;

namespace KutuphaneOtomasyonCF
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
        }
        DataHelper dataHelper = new DataHelper();
        private KitapViewModel seciliKitap;
        private UyeViewModel seciliUye;
        private KiraViewModel seciliKira;
        private void RentForm_Load(object sender, EventArgs e)
        {
            lstKitaplar.DataSource = dataHelper.KitaplariGetir();
            cmbUyeler.DataSource = dataHelper.UyeleriGetir();
            lstKiralar.DataSource = dataHelper.KiralariGetir();
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;
            if (cmbUyeler.SelectedItem == null) return;

            MyContext db = new MyContext();
            seciliKitap = lstKitaplar.SelectedItem as KitapViewModel;
            seciliUye = cmbUyeler.SelectedItem as UyeViewModel;

            if (seciliKitap.Stok <= 0) MessageBox.Show($"{seciliKitap.KitapAd} stokta yok, baska kitap seciniz");

            //var eklenecekkira = new Kira()
            //{
            //    kitapıd = secilikitap.kitapıd,
            //    kitapad = secilikitap.kitapad,
            //    uyeıd = seciliuye.uyeıd,
            //    uyead = seciliuye.uyead,
            //    Uyesoyad = seciliuye.uyesoyad
            //};

            seciliKitap.Stok--;
            var guncellenecekKitap = db.Kitaplar
                .SingleOrDefault(x => x.KitapId == seciliKitap.KitapId);
            guncellenecekKitap.Stok = seciliKitap.Stok;

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var eklenecekKira = new Kira()
                    {
                        KitapId = seciliKitap.KitapId,
                        UyeId = seciliUye.UyeId
                    };
                    db.Kiralar.Add(eklenecekKira);
                    db.SaveChanges();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }
        private void lstKira_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            dtpVerisTarihi.Visible = true;
            btnIadeEt.Visible = true;
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (lstKiralar.SelectedItem == null) return;

            MyContext db = new MyContext();
            seciliKira = lstKiralar.SelectedItem as KiraViewModel;
            seciliKitap.KitapId = seciliKira.KitapId;
            seciliKira.VerisTarihi = dtpVerisTarihi.Value.Date;

            seciliKitap.Stok++;
            var guncellenecekKitap = db.Kitaplar
                .SingleOrDefault(x => x.KitapId == seciliKitap.KitapId);
            guncellenecekKitap.Stok = seciliKitap.Stok;

            var tutar = seciliKira.CezaHesapla(seciliKira.VerisTarihi, seciliKira.AlisTarihi);
            if (tutar > 0) MessageBox.Show($"Odemeniz gereken ceza: {tutar}");
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            var kelime = txtAra.Text.ToLower();
            MyContext db = new MyContext();
            var bulunanKitaplar = dataHelper.KitaplariGetir()
                .Where(x => x.KitapAd.ToLower().Contains(kelime) || x.YazarAd.ToLower().Contains(kelime) ||
                            x.YazarSoyad.ToLower().Contains(kelime))
                .ToList();
            lstKitaplar.DataSource = bulunanKitaplar;
        }
    }
}
