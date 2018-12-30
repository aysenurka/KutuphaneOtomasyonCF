using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonCF.Entities;

namespace KutuphaneOtomasyonCF.BLL
{
    public class UyeBusiness
    {
        public void UyeEkle(Uye uye)
        {
            MyContext db=new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var eklenecekUye=new Uye()
                    {
                        UyeId=uye.UyeId,
                        UyeAd = uye.UyeAd,
                        UyeSoyad = uye.UyeSoyad,
                        UyeTckn = uye.UyeTckn,
                        UyeTelefon = uye.UyeTelefon,
                        UyeEmail = uye.UyeEmail
                    };
                    db.Uyeler.Add(eklenecekUye);
                    tran.Commit();
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
        }
    }
}
