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
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            lstYazarlar.DataSource = db.Yazarlar
                .OrderBy(x => x.YazarAd).ThenBy(x => x.YazarSoyad)
                .Select(x => new YazarViewModel()
                {
                    YazarId = x.YazarId,
                    YazarAd = x.YazarAd,
                    YazarSoyad = x.YazarSoyad
                })
                .ToList();
        }

        private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedIndex == null) return;

            var seciliYazar = lstYazarlar.SelectedItem as YazarViewModel;
            txtId.Text = seciliYazar.YazarId.ToString();
            txtAd.Text = seciliYazar.YazarAd;
            txtSoyad.Text = seciliYazar.YazarSoyad;
        }
    }
}
