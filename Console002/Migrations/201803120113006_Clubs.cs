namespace Console002.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clubs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Clubs", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Clubs");
        }
    }
}
