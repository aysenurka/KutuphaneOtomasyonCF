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
using KutuphaneOtomasyonCF.MockData;
using KutuphaneOtomasyonCF.ViewModels;

namespace KutuphaneOtomasyonCF
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        DataHelper dataHelper = new DataHelper();
        private KitapViewModel seciliKitap;
        private YazarViewModel seciliYazar;
        private void BookForm_Load(object sender, EventArgs e)
        {
            lstKitaplar.DataSource = dataHelper.KitaplariGetir();
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex == null) return;

            MyContext db = new MyContext();
            seciliKitap = lstKitaplar.SelectedItem as KitapViewModel;
            var gosterilecekYazar = db.Yazarlar
                            .SingleOrDefault(x => x.YazarId == seciliKitap.YazarId);

            seciliYazar = new YazarViewModel()
            {
                YazarId = gosterilecekYazar.YazarId,
                YazarAd = gosterilecekYazar.YazarAd,
                YazarSoyad = gosterilecekYazar.YazarSoyad
            };
            txtId.Text = seciliKitap.KitapId.ToString();
            txtAd.Text = seciliKitap.KitapAd;

            var yazarList = dataHelper.YazarlariGetir();
            cmbYazarlar.DataSource = yazarList;
            foreach (var item in yazarList)
            {
                if (item.YazarId == seciliKitap.YazarId)
                {
                    cmbYazarlar.SelectedItem = item;
                    break;
                }
            }

            nuStok.Value = seciliKitap.Stok;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;

            MyContext db = new MyContext();
            seciliKitap = lstKitaplar.SelectedItem as KitapViewModel;
            var silinecekKitap = db.Kitaplar
                .SingleOrDefault(x => x.KitapId == seciliKitap.KitapId);

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    db.Kitaplar.Remove(silinecekKitap);
                    db.SaveChanges();
                    tran.Commit();
                    lstKitaplar.DataSource = dataHelper.KitaplariGetir();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;

            btnGuncelle.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;

            MyContext db = new MyContext();
            seciliKitap = lstKitaplar.SelectedItem as KitapViewModel;
            seciliYazar = cmbYazarlar.SelectedItem as YazarViewModel;
            var guncellenecekKitap = db.Kitaplar
                .SingleOrDefault(x => x.KitapId == seciliKitap.KitapId);
            var guncellenecekYazar = db.Yazarlar
                .SingleOrDefault(x => x.YazarId == seciliYazar.YazarId);

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    guncellenecekKitap.KitapAd = txtAd.Text;
                    guncellenecekKitap.Yazar = guncellenecekYazar;
                    guncellenecekKitap.Stok = (short)nuStok.Value;

                    db.SaveChanges();
                    tran.Commit();
                    lstKitaplar.DataSource = dataHelper.KitaplariGetir();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            btnGuncelle.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            seciliYazar = cmbYazarlar.SelectedItem as YazarViewModel;
            var eklenecekYazar = db.Yazarlar
                .SingleOrDefault(x => x.YazarId == seciliYazar.YazarId);

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var eklenecekKitap = new Kitap()
                    {
                        KitapAd = txtAd.Text,
                        Yazar = eklenecekYazar,
                        Stok = (short)nuStok.Value
                    };
                    db.Kitaplar.Add(eklenecekKitap);
                    db.SaveChanges();
                    tran.Commit();
                    lstKitaplar.DataSource = dataHelper.KitaplariGetir();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            MyContext db = new MyContext();
            var kelime = txtAra.Text.ToLower();
            var bulunanKitaplar = dataHelper.KitaplariGetir()
                .Where(x => x.KitapAd.ToLower().Contains(kelime) || x.YazarAd.ToLower().Contains(kelime) || x.YazarSoyad.ToLower().Contains(kelime))
                .ToList();
            lstKitaplar.DataSource = bulunanKitaplar;
        }
    }
}
