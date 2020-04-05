namespace Time_Travel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Time_Travel.CountryData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Time_Travel.CountryData";
        }

        protected override void Seed(Time_Travel.CountryData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
