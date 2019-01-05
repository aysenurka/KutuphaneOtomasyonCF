using KutuphaneOtomasyonCF.Entities;
using KutuphaneOtomasyonCF.Helpers;
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

namespace KutuphaneOtomasyonCF
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }
        private DataHelper dataHelper = new DataHelper();
        private UyeViewModel seciliUye;

        private void MemberForm_Load(object sender, EventArgs e)
        {
            lstUyeler.DataSource= dataHelper.UyeleriGetir();
        }

        private void lstUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedIndex == null) return;

            seciliUye = lstUyeler.SelectedItem as UyeViewModel;
            MyContext db=new MyContext();
            var gosterilecekUye = db.Uyeler
                .SingleOrDefault(x => x.UyeId == seciliUye.UyeId);

            txtId.Text = gosterilecekUye.UyeId.ToString();
            txtAd.Text = gosterilecekUye.UyeAd;
            txtSoyad.Text = gosterilecekUye.UyeSoyad;
            txtTckn.Text = gosterilecekUye.UyeTckn.ToString();
            txtTelefon.Text = gosterilecekUye.UyeTelefon;
            txtEmail.Text = gosterilecekUye.UyeEmail;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    var yeniUye = new Uye()
                    {
                        UyeAd = txtAd.Text,
                        UyeSoyad = txtSoyad.Text,
                        UyeTckn = txtTckn.Text,
                        UyeTelefon = txtTelefon.Text,
                        UyeEmail = txtEmail.Text
                    };
                    db.Uyeler.Add(yeniUye);
                    db.SaveChanges();
                    tran.Commit();
                    lstUyeler.DataSource = dataHelper.UyeleriGetir();
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
            if (lstUyeler.SelectedItem == null) return;

            seciliUye = lstUyeler.SelectedItem as UyeViewModel;
            btnGuncelle.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedItem == null) return;

            seciliUye = lstUyeler.SelectedItem as UyeViewModel;
            MyContext db = new MyContext();
            var guncelUye = db.Uyeler
                .SingleOrDefault(x => x.UyeId == seciliUye.UyeId);

            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    if (guncelUye != null)
                    {
                        //guncelUye.UyeId = Convert.ToInt32(txtId.Text);
                        guncelUye.UyeAd = txtAd.Text;
                        guncelUye.UyeSoyad = txtSoyad.Text;
                        guncelUye.UyeTckn = txtTckn.Text;
                        guncelUye.UyeTelefon = txtTelefon.Text;
                        guncelUye.UyeEmail = txtEmail.Text;
                    }
                    db.SaveChanges();
                    tran.Commit();
                    lstUyeler.DataSource = dataHelper.UyeleriGetir();
                    btnGuncelle.Visible = false;
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
            if (lstUyeler.SelectedItem == null) return;

            seciliUye = lstUyeler.SelectedItem as UyeViewModel;
            MyContext db = new MyContext();
            var bulunacakUye = db.Uyeler
                .SingleOrDefault(x => x.UyeId == seciliUye.UyeId);

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    db.Uyeler.Remove(bulunacakUye);
                    db.SaveChanges();
                    tran.Commit();
                    lstUyeler.DataSource = dataHelper.UyeleriGetir();
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
            var bulunanUyeler = dataHelper.UyeleriGetir()
                .Where(x => x.UyeAd.ToLower().Contains(kelime) || x.UyeSoyad.ToLower().Contains(kelime))
                .ToList();
            lstUyeler.DataSource = bulunanUyeler;
        }
    }
}
