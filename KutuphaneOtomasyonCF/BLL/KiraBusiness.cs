using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonCF.Entities;

namespace KutuphaneOtomasyonCF.BLL
{
    public class KiraBusiness
    {
        public void Kirala(Kira kira)
        {
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var eklenecekKira = new Kira()
                    {
                        KiraId = kira.KiraId,
                        Uye = kira.Uye,
                        Kitaplar = kira.Kitaplar
                    };
                    db.Kiralar.Add(eklenecekKira);
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
