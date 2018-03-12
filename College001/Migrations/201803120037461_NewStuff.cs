namespace College001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewStuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Number = c.Int(nullable: false),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.ClassID);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        Date_Assigned = c.DateTime(nullable: false),
                        Date_Due = c.DateTime(nullable: false),
                        Date_Submitted = c.DateTime(nullable: false),
                        Points_Earned = c.Int(nullable: false),
                        Points_Possible = c.Int(nullable: false),
                        Score_ID_ID = c.Int(),
                        Class_ClassID = c.Int(),
                    })
                .PrimaryKey(t => t.ScoreID)
                .ForeignKey("dbo.Students", t => t.Score_ID_ID)
                .ForeignKey("dbo.Classes", t => t.Class_ClassID)
                .Index(t => t.Score_ID_ID)
                .Index(t => t.Class_ClassID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.Int(nullable: false),
                        Phone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "Class_ClassID", "dbo.Classes");
            DropForeignKey("dbo.Scores", "Score_ID_ID", "dbo.Students");
            DropIndex("dbo.Scores", new[] { "Class_ClassID" });
            DropIndex("dbo.Scores", new[] { "Score_ID_ID" });
            DropTable("dbo.Students");
            DropTable("dbo.Scores");
            DropTable("dbo.Classes");
        }
    }
}
