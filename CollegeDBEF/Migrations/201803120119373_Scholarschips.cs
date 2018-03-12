namespace CollegeDBEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Scholarschips : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Scholarships", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Scholarships");
        }
    }
}
