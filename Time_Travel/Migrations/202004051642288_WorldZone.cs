namespace Time_Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorldZone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "CountryZone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "CountryZone", c => c.Int(nullable: false));
        }
    }
}
