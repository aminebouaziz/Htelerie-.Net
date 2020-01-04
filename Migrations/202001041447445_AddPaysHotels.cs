namespace Hotellerie_Amine_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaysHotels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hotels", "Pays", c => c.String(defaultValue:"Tunisie"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hotels", "Pays");
        }
    }
}
