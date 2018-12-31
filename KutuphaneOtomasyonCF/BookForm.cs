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

            lstKitap.DataSource = db.Kitaplar
                .OrderBy(x => x.KitapAd)
                .Select(x=> new KitapViewModel() {
                    KitapId=x.KitapId,
                    KitapAd=x.KitapAd,
                    Yazar=x.Yazar
                })
                .ToList();
        }

    }
}
