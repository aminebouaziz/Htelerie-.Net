namespace Hotellerie_Amine_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutNoteApprec : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appreciations", "Note", c => c.Int(nullable: false, defaultValue: 3)  );
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appreciations", "Note");
        }
    }
}
