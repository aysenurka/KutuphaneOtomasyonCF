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

        DataHelper dataHelper=new DataHelper();
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

            MyContext db=new MyContext();
            seciliKitap = lstKitaplar.SelectedItem as KitapViewModel;
            //seciliYazar = seciliKitap.
            //seciliYazar = db.Yazarlar
            //    .SingleOrDefault(x => x.YazarId == seciliKitap.YazarId);
            var gosterilecekYazar = db.Yazarlar
                .SingleOrDefault(x => x.YazarId == seciliKitap.YazarId);
            //seciliYazar.YazarId = seciliKitap.YazarId;

            txtId.Text = seciliKitap.KitapId.ToString();
            txtAd.Text = seciliKitap.KitapAd;
            //txtYazar.Text = seciliYazar.ToString();
            seciliKitap.YazarId = gosterilecekYazar.YazarId;

            nuStok.Value = seciliKitap.Stok;
        }
    }
}
