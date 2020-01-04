using Hotellerie_Amine_.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotellerie_Amine_.Models.HotellerieModel
{
    public class HotellerieDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HotellerieDbContext, Configuration>());
        }
        public System.Data.Entity.DbSet<Hotellerie_Amine_.Models.HotellerieModel.Appreciation> Appreciations { get; set; }
    }
}