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
        //private List<KitapViewModel> kitaplar;
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
            txtYazar.Text = seciliYazar.ToString();
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
            var guncellenecekKitap = db.Kitaplar
                .SingleOrDefault(x => x.KitapId == seciliKitap.KitapId);
            //var guncel

            guncellenecekKitap = new Kitap()
            {
                KitapAd = txtAd.Text,
                //Yazar = txtYazar.Text,
                Stok = (short)nuStok.Value
            };
        }
    }
}
