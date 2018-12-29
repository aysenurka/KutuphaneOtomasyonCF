namespace KutuphaneOtomasyonCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.KiraDetaylar", "KiraId", "dbo.Kiralar");
            DropForeignKey("dbo.Kiralar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.KiraDetaylar", new[] { "KiraId" });
            DropIndex("dbo.Kiralar", new[] { "UyeId" });
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            RenameColumn(table: "dbo.Kiralar", name: "UyeId", newName: "Uye_UyeId");
            DropPrimaryKey("dbo.KiraDetaylar");
            AddColumn("dbo.KiraDetaylar", "KitapId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kiralar", "Uye_UyeId", c => c.Int());
            AddPrimaryKey("dbo.KiraDetaylar", new[] { "KiraId", "KitapId" });
            CreateIndex("dbo.Kiralar", "Uye_UyeId");
            AddForeignKey("dbo.Kiralar", "Uye_UyeId", "dbo.Uyeler", "UyeId");
            DropColumn("dbo.KiraDetaylar", "KiraDetayId");
            DropColumn("dbo.Kiralar", "KitapId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralar", "KitapId", c => c.Int(nullable: false));
            AddColumn("dbo.KiraDetaylar", "KiraDetayId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Kiralar", "Uye_UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kiralar", new[] { "Uye_UyeId" });
            DropPrimaryKey("dbo.KiraDetaylar");
            AlterColumn("dbo.Kiralar", "Uye_UyeId", c => c.Int(nullable: false));
            DropColumn("dbo.KiraDetaylar", "KitapId");
            AddPrimaryKey("dbo.KiraDetaylar", "KiraDetayId");
            RenameColumn(table: "dbo.Kiralar", name: "Uye_UyeId", newName: "UyeId");
            CreateIndex("dbo.Kiralar", "KitapId");
            CreateIndex("dbo.Kiralar", "UyeId");
            CreateIndex("dbo.KiraDetaylar", "KiraId");
            AddForeignKey("dbo.Kiralar", "UyeId", "dbo.Uyeler", "UyeId", cascadeDelete: true);
            AddForeignKey("dbo.KiraDetaylar", "KiraId", "dbo.Kiralar", "KiraId", cascadeDelete: true);
            AddForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar", "KitapId", cascadeDelete: true);
        }
    }
}
