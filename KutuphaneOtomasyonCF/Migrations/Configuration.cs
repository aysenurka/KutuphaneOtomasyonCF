namespace KutuphaneOtomasyonCF.Migrations
{
    using KutuphaneOtomasyonCF.Entities;
    using KutuphaneOtomasyonCF.MockData;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KutuphaneOtomasyonCF.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KutuphaneOtomasyonCF.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var db = context;
            MockContext mock = new MockContext();
            if (!db.Yazarlar.Any())
            {
                foreach (var item in mock.Yazarlar)
                {
                    db.Yazarlar.Add(item);
                }
                db.SaveChanges();
            }
            if (!db.Kitaplar.Any())
            {
                var yazarlar = db.Yazarlar.ToList();
                Random rnd = new Random();

                foreach (var item in mock.Kitaplar)
                {
                    item.YazarId = yazarlar[rnd.Next(0, yazarlar.Count)].YazarId;
                    db.Kitaplar.Add(item);
                }
                db.SaveChanges();
            }
            if (!db.Uyeler.Any()) {
                foreach (var item in mock.Uyeler)
                {
                    db.Uyeler.Add(item);
                }
                db.SaveChanges();
            }
        }
    }
}
