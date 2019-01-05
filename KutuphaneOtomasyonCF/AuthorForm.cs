using KutuphaneOtomasyonCF.ViewModels;
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

namespace KutuphaneOtomasyonCF
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }
        private DataHelper dataHelper=new DataHelper();
        private YazarViewModel seciliYazar;
        private void AuthorForm_Load(object sender, EventArgs e)
        {
            lstYazarlar.DataSource = dataHelper.YazarlariGetir();
        }

        private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedIndex == null) return;

            seciliYazar = lstYazarlar.SelectedItem as YazarViewModel;
            txtId.Text = seciliYazar.YazarId.ToString();
            txtAd.Text = seciliYazar.YazarAd;
            txtSoyad.Text = seciliYazar.YazarSoyad;
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedItem == null) return;

            btnGuncelle.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedItem == null) return;

            MyContext db=new MyContext();
            seciliYazar=lstYazarlar.SelectedItem as YazarViewModel;
            var guncelYazar = db.Yazarlar
                .SingleOrDefault(x => x.YazarId == seciliYazar.YazarId);

            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    guncelYazar.YazarId = seciliYazar.YazarId;
                    guncelYazar.YazarAd = txtAd.Text;
                    guncelYazar.YazarSoyad = txtSoyad.Text;

                    db.SaveChanges();
                    tran.Commit();
                    lstYazarlar.DataSource = dataHelper.YazarlariGetir();
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
            MyContext db=new MyContext();

            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    var eklenecekYazar = new Yazar()
                    {
                        YazarAd = txtAd.Text,
                        YazarSoyad = txtSoyad.Text
                    };
                    db.Yazarlar.Add(eklenecekYazar);
                    db.SaveChanges();
                    tran.Commit();
                    lstYazarlar.DataSource = dataHelper.YazarlariGetir();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedItem == null) return;

            seciliYazar=lstYazarlar.SelectedItem as YazarViewModel;
            MyContext db=new MyContext();
            var silinecekYazar = db.Yazarlar
                .SingleOrDefault(x => x.YazarId == seciliYazar.YazarId);

            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    db.Yazarlar.Remove(silinecekYazar);
                    db.SaveChanges();
                    tran.Commit();
                    lstYazarlar.DataSource = dataHelper.YazarlariGetir();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var kelime = txtAra.Text.ToLower();
            MyContext db=new MyContext();
            var bulunanYazarlar = dataHelper.YazarlariGetir()
                .Where(x => x.YazarAd.ToLower().Contains(kelime) || x.YazarSoyad.ToLower().Contains(kelime))
                .ToList();
            lstYazarlar.DataSource = bulunanYazarlar;
        }
    }
}
