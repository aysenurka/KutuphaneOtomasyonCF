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
        public List<KitapViewModel> KitaplariGetir()
        {
            MyContext db = new MyContext();

            var kitaplar = db.Kitaplar
                .OrderBy(x => x.KitapAd)
                .ThenByDescending(x => x.Stok)
                .Select(x => new KitapViewModel()
                {
                    KitapId = x.KitapId,
                    KitapAd = x.KitapAd,
                    Stok = x.Stok,
                    YazarId = x.YazarId,
                    YazarAd = x.Yazar.YazarAd,
                    YazarSoyad = x.Yazar.YazarSoyad
                })
                .ToList();
            

            return kitaplar;
        }

        public List<UyeViewModel> UyeleriGetir()
        {
            MyContext db = new MyContext();
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

        public List<YazarViewModel> YazarlariGetir()
        {
            MyContext db = new MyContext();
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
