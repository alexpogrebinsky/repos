namespace CollegeDBF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Number = c.Int(nullable: false),
                        Department = c.String(),
                        Score_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Scores", t => t.Score_ID)
                .Index(t => t.Score_ID);
            
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
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        Date_Assigned = c.DateTime(nullable: false),
                        Date_Due = c.DateTime(nullable: false),
                        Date_Submitted = c.DateTime(nullable: false),
                        Points_Earned = c.Int(nullable: false),
                        Points_Possible = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentClasses",
                c => new
                    {
                        Student_ID = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_ID, t.Class_ID })
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_ID, cascadeDelete: true)
                .Index(t => t.Student_ID)
                .Index(t => t.Class_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Score_ID", "dbo.Scores");
            DropForeignKey("dbo.StudentClasses", "Class_ID", "dbo.Classes");
            DropForeignKey("dbo.StudentClasses", "Student_ID", "dbo.Students");
            DropIndex("dbo.StudentClasses", new[] { "Class_ID" });
            DropIndex("dbo.StudentClasses", new[] { "Student_ID" });
            DropIndex("dbo.Classes", new[] { "Score_ID" });
            DropTable("dbo.StudentClasses");
            DropTable("dbo.Scores");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
