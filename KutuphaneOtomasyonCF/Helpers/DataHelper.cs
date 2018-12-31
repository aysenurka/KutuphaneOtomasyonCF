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
        MyContext db = new MyContext();
        public List<KitapViewModel> KitaplariGetir()
        {
            //var kitaplar = db.Kitaplar
            //    .OrderBy(x => x.KitapAd)
            //    .Select(x => new KitapViewModel()
            //    {
            //        KitapId = x.KitapId,
            //        KitapAd = x.KitapAd,
            //        Yazar = x.Yazar
            //    })
            //    .ToList();

            var kitaplar2 = new List<KitapViewModel>();
            foreach (var item in db.Kitaplar.OrderBy(x => x.KitapAd)
                .Select(x => new KitapViewModel()
                {
                    KitapId = x.KitapId,
                    KitapAd = x.KitapAd,
                    Yazar = x.Yazar
                }))
                kitaplar2.Add(item);
            

            return kitaplar2;


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
                    UyeSoyad = x.UyeSoyad,
                    //UyeTckn = x.UyeTckn,
                    //UyeTelefon = x.UyeTelefon,
                    //UyeEmail = x.UyeEmail
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
