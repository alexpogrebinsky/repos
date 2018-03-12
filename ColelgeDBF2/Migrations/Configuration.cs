namespace ColelgeDBF2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<College_DBF.CollegeDBF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BegVCSharp_21_2_DatabaseRelations.CollegeDBF";
        }

        protected override void Seed(College_DBF.CollegeDBF context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
