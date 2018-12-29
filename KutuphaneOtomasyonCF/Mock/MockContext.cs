using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonCF.Entities;

namespace KutuphaneOtomasyonCF.MockData
{
    public class MockContext
    {
        public List<Uye> Uyeler { get; set; } = new List<Uye>();
        public List<Yazar> Yazarlar { get; set; } = new List<Yazar>();
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();
    }
}
