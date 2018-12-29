using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonCF.Entities;
using KutuphaneOtomasyonCF.ViewModels;

namespace KutuphaneOtomasyonCF.Helpers
{
    public class DataHelper
    {
        static MyContext db = new MyContext();
        public static List<KitapViewModel> KitaplariGetir()
        {
            var kitaplar = db.Kitaplar
                .OrderBy(x => x.KitapAd)
                .Select(x => new KitapViewModel()
                {
                    KitapId = x.KitapId,
                    KitapAd = x.KitapAd
                })
                .ToList();
            return kitaplar;
        }

        public static List<UyeViewModel> UyeleriGetir()
        {
            var uyeler = db.Uyeler
                .OrderBy(x => x.UyeAd).ThenBy(x => x.UyeSoyad)
                .Select(x => new UyeViewModel()
                {
                    UyeId = x.UyeId,
                    UyeAd = x.UyeAd,
                    UyeSoyad = x.UyeSoyad
                })
                .ToList();
            return uyeler;
        }

        public static List<YazarViewModel> YazarlariGetir()
        {
            var yazarlar = db.Yazarlar
                .OrderBy(x => x.YazarAd).ThenBy(x => x.YazarSoyad)
                .Select(x => new YazarViewModel()
                {
                    YazarId = x.YazarId,
                    YazarAd = x.YazarAd,
                    YazarSoyad = x.YazarSoyad
                })
                .ToList();
            return yazarlar;
        }
    }
}
