namespace KutuphaneOtomasyonCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiraDetaylar",
                c => new
                    {
                        KiraDetayId = c.Int(nullable: false, identity: true),
                        KiraId = c.Int(nullable: false),
                        GunSayisi = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.KiraDetayId)
                .ForeignKey("dbo.Kiralar", t => t.KiraId, cascadeDelete: true)
                .Index(t => t.KiraId);
            
            CreateTable(
                "dbo.Kiralar",
                c => new
                    {
                        KiraId = c.Int(nullable: false, identity: true),
                        UyeId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KiraId)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId)
                .Index(t => t.KitapId);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAd = c.String(nullable: false, maxLength: 50),
                        Stok = c.Short(nullable: false),
                        YazarId = c.Int(nullable: false),
                        Kira_KiraId = c.Int(),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .ForeignKey("dbo.Kiralar", t => t.Kira_KiraId)
                .Index(t => t.YazarId)
                .Index(t => t.Kira_KiraId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAd = c.String(nullable: false, maxLength: 20),
                        YazarSoyad = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAd = c.String(nullable: false, maxLength: 20),
                        UyeSoyad = c.String(nullable: false, maxLength: 20),
                        UyeTckn = c.String(nullable: false, maxLength: 11),
                        UyeTelefon = c.String(maxLength: 10),
                        UyeEmail = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.UyeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KiraDetaylar", "KiraId", "dbo.Kiralar");
            DropForeignKey("dbo.Kiralar", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kitaplar", "Kira_KiraId", "dbo.Kiralar");
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "Kira_KiraId" });
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropIndex("dbo.Kiralar", new[] { "UyeId" });
            DropIndex("dbo.KiraDetaylar", new[] { "KiraId" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kiralar");
            DropTable("dbo.KiraDetaylar");
        }
    }
}
