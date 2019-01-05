namespace KutuphaneOtomasyonCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaplar", "Kira_KiraId", "dbo.Kiralar");
            DropForeignKey("dbo.Kiralar", "Uye_UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kiralar", new[] { "Uye_UyeId" });
            DropIndex("dbo.Kitaplar", new[] { "Kira_KiraId" });
            RenameColumn(table: "dbo.Kiralar", name: "Uye_UyeId", newName: "UyeId");
            AddColumn("dbo.Kiralar", "KitapId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kiralar", "UyeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kiralar", "UyeId");
            CreateIndex("dbo.Kiralar", "KitapId");
            AddForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar", "KitapId", cascadeDelete: true);
            AddForeignKey("dbo.Kiralar", "UyeId", "dbo.Uyeler", "UyeId", cascadeDelete: true);
            DropColumn("dbo.Kitaplar", "Kira_KiraId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kitaplar", "Kira_KiraId", c => c.Int());
            DropForeignKey("dbo.Kiralar", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropIndex("dbo.Kiralar", new[] { "UyeId" });
            AlterColumn("dbo.Kiralar", "UyeId", c => c.Int());
            DropColumn("dbo.Kiralar", "KitapId");
            RenameColumn(table: "dbo.Kiralar", name: "UyeId", newName: "Uye_UyeId");
            CreateIndex("dbo.Kitaplar", "Kira_KiraId");
            CreateIndex("dbo.Kiralar", "Uye_UyeId");
            AddForeignKey("dbo.Kiralar", "Uye_UyeId", "dbo.Uyeler", "UyeId");
            AddForeignKey("dbo.Kitaplar", "Kira_KiraId", "dbo.Kiralar", "KiraId");
        }
    }
}
