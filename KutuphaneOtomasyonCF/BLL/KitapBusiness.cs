using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonCF.Entities;

namespace KutuphaneOtomasyonCF.BLL
{
    public class KitapBusiness
    {
        public void KitapEkle(Kitap kitap)
        {
            MyContext db=new MyContext();
            using (var tran=db.Database.BeginTransaction())
            {
                try
                {
                    var eklenecekKitap=new Kitap()
                    {
                        KitapId = kitap.KitapId,
                        KitapAd = kitap.KitapAd,
                        Yazar = kitap.Yazar,
                        Stok = kitap.Stok
                    };
                    db.Kitaplar.Add(eklenecekKitap);
                    db.SaveChanges();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }
    }
}
