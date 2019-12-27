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
   }
}