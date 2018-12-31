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
        public MockContext()
        {
            for (int i = 0; i < 40; i++)
            {
                var ad = FakeData.NameData.GetFirstName();
                var soyad = FakeData.NameData.GetSurname();
                var email = (FakeData.NameData.GetFirstName().Substring(0, 1) + "." + FakeData.NameData.GetSurname() + "@email.com").ToLower();
                Uyeler.Add(new Uye()
                {
                    UyeAd = ad.Length > 20 ? ad.Substring(0, 20) : ad,
                    UyeSoyad = soyad.Length > 20 ? soyad.Substring(0, 20) : ad,
                    UyeTckn = FakeData.TextData.GetNumeric(11),
                    UyeTelefon = "0" + FakeData.TextData.GetNumeric(10),
                    UyeEmail = email.Length > 30 ? email.Substring(0, 30) : email
                });
            }

            for (int i = 0; i < 20; i++)
            {
                Yazarlar.Add(new Yazar()
                {
                    YazarAd = FakeData.NameData.GetFirstName(),
                    YazarSoyad = FakeData.NameData.GetSurname()
                });
            }


            for (int i = 0; i < 30; i++)
            {
                var ad = FakeData.TextData.GetSentence();
                Kitaplar.Add(new Kitap()
                {
                    KitapAd = ad.Length > 50 ? ad.Substring(0, 50) : ad,
                    Stok = (short)FakeData.NumberData.GetNumber(1, 5)
                });
            }
        }
    }
}
