namespace KutuphaneOtomasyonCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KiraDetaylar", "GunSayisi", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KiraDetaylar", "GunSayisi", c => c.Time(nullable: false, precision: 7));
        }
    }
}
