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
        private List<UyeViewModel> uyeList = new List<UyeViewModel>();
        private void MemberForm_Load(object sender, EventArgs e)
        {
            lstUyeler.DataSource= dataHelper.UyeleriGetir();
        }

        private void lstUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedIndex == null) return;

            var seciliUye = lstUyeler.SelectedItem as UyeViewModel;
            txtId.Text = seciliUye.UyeId.ToString();
            txtAd.Text = seciliUye.UyeAd;
            txtSoyad.Text = seciliUye.UyeSoyad;
            txtTckn.Text = seciliUye.UyeTckn.ToString();
            txtTelefon.Text = seciliUye.UyeTelefon;
            txtEmail.Text = seciliUye.UyeEmail;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

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
                lstUyeler.DataSource = dataHelper.UyeleriGetir();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private UyeViewModel seciliUye;
        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedItem == null) return;

            seciliUye = lstUyeler.SelectedItem as UyeViewModel;
            btnGuncelle.Visible = true;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTckn.Enabled = false;

            seciliUye.UyeTelefon = txtTelefon.Text;
            seciliUye.UyeEmail = txtEmail.Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    foreach (var item in db.Uyeler)
                    {
                        if (seciliUye.UyeId == item.UyeId)
                        {
                            item.UyeTelefon = txtTelefon.Text;
                            item.UyeEmail = txtEmail.Text;
                            //lstUyeler.Items.Add(item);
                            //uyeList.Add(item);

                            db.Uyeler.Add(item);
                            break;
                        }
                    }
                    tran.Commit();
                    db.SaveChanges();
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
            MyContext db = new MyContext();
            if (lstUyeler.SelectedItem == null) return;

            seciliUye = lstUyeler.SelectedItem as UyeViewModel;

            var bulunacakId = seciliUye.UyeId;

            var bulunacakUye = db.Uyeler
                .SingleOrDefault(x => x.UyeId == bulunacakId);

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    db.Uyeler.Remove(bulunacakUye);
                    tran.Commit();
                    db.SaveChanges();
                    lstUyeler.DataSource = dataHelper.UyeleriGetir();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            //uyeList.Remove(seciliUye1);
            //db.Uyeler.Remove(seciliUye1);
            //db.SaveChanges();
        }
    }
}
