namespace Time_Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.String(nullable: false, maxLength: 128),
                        CountryZone = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Country_CountryID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CountryID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Countries", "Country_CountryID", "dbo.Countries");
            DropIndex("dbo.Countries", new[] { "Country_CountryID" });
            DropTable("dbo.Countries");
        }
    }
}
