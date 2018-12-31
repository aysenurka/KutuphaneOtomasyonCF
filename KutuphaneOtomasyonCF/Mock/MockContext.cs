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
                var email = (FakeData.NameData.GetFirstName().Substring(0, 1) + "." + FakeData.NameData.GetSurname() + "@email.com").ToLower();
                var yeniUye = new Uye
                {
                    UyeAd = FakeData.NameData.GetFirstName(),
                    UyeSoyad = FakeData.NameData.GetSurname(),
                    UyeTckn = FakeData.TextData.GetNumeric(11),
                    UyeTelefon = "5" + FakeData.TextData.GetNumeric(9),
                };
                yeniUye.UyeEmail = email.Length > 30 ? email.Substring(0, 30) : email;
                Uyeler.Add(yeniUye);
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
