namespace ConsoleApp10.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<College_DBEF.CollegeDBF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "College_DBEF.CollegeDBF";
        }

        protected override void Seed(College_DBEF.CollegeDBF context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
