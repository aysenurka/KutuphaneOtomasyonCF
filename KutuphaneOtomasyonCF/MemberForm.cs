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

        private void MemberForm_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            lstUyeler.DataSource = db.Uyeler
                .OrderBy(x => x.UyeAd).ThenBy(x => x.UyeSoyad)
                .Select(x => new UyeViewModel()
                {
                    UyeId = x.UyeId,
                    UyeAd = x.UyeAd,
                    UyeSoyad = x.UyeSoyad,
                    UyeTckn=x.UyeTckn,
                    UyeTelefon=x.UyeTelefon,
                    UyeEmail=x.UyeEmail
                })
                .ToList();
        }

        private void lstUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedIndex == null) return;

            var seciliUye=lstUyeler.SelectedItem as UyeViewModel;
            txtId.Text = seciliUye.UyeId.ToString();
            txtAd.Text = seciliUye.UyeAd;
            txtSoyad.Text = seciliUye.UyeSoyad;
            txtTckn.Text = seciliUye.UyeTckn.ToString() ;
            txtTelefon.Text = seciliUye.UyeTelefon;
            txtEmail.Text = seciliUye.UyeEmail;
        }
    }
}
