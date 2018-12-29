using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonCF.Entities;
using KutuphaneOtomasyonCF.MockData;

namespace KutuphaneOtomasyonCF.Mock
{
    public class MockData
    {
        public MockContext MockContext { get; set; }

        public MockData()
        {
            MockContext = new MockContext();

            for (int i = 0; i < 40; i++)
            {
                MockContext.Uyeler.Add(new Uye()
                {
                    UyeAd = FakeData.NameData.GetFirstName(),
                    UyeSoyad = FakeData.NameData.GetSurname(),
                    UyeTckn = FakeData.TextData.GetNumeric(11),
                    UyeTelefon = "0" + FakeData.TextData.GetNumeric(10)
                });
            }

            for (int i = 0; i < 20; i++)
            {
                MockContext.Yazarlar.Add(new Yazar()
                {
                    YazarAd = FakeData.NameData.GetFirstName(),
                    YazarSoyad = FakeData.NameData.GetSurname()
                });
            }

            for (int i = 0; i < 30; i++)
            {
                MockContext.Kitaplar.Add(new Kitap()
                {
                    KitapAd = FakeData.TextData.GetSentence()
                });
            }
        }
    }
}
