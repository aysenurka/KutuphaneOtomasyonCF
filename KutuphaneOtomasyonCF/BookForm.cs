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

        private List<KitapViewModel> kitaplar;
        private void BookForm_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            lstKitaplar.DataSource = db.Kitaplar
                .OrderBy(x => x.KitapAd)
                .Select(x=> new KitapViewModel() {
                    KitapId=x.KitapId,
                    KitapAd=x.KitapAd,
                    Yazar=x.Yazar,
                    Stok=x.Stok
                })
                .ToList();
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex == null) return;

            var seciliKitap = lstKitaplar.SelectedItem as KitapViewModel;
            txtId.Text = seciliKitap.KitapId.ToString();
            txtAd.Text = seciliKitap.KitapAd;
            txtYazar.Text = seciliKitap.Yazar.ToString();
            nuStok.Value = seciliKitap.Stok;
        }
    }
}
