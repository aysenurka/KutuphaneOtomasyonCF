using KutuphaneOtomasyonCF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MyCon")
        {
        }

        public virtual DbSet<Uye> Uyeler { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Kira> Kiralar { get; set; }
        public virtual DbSet<KiraDetay> KiraDetaylar { get; set; }
    }
}
