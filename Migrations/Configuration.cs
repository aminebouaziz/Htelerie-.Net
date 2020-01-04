namespace Hotellerie_Amine_.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hotellerie_Amine_.Models.HotellerieModel.HotellerieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Hotellerie_Amine_.Models.HotellerieModel.HotellerieDbContext";
        }

        protected override void Seed(Hotellerie_Amine_.Models.HotellerieModel.HotellerieDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
