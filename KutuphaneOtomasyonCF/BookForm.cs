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
            //kitaplar = HomePage.MockContext.Kitaplar;
            //kitaplar.Add(DataHelper.KitaplariGetir());

            lstKitap.DataSource = MockContext.Kitaplar;
        }

    }
}
