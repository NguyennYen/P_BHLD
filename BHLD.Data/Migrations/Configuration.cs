namespace BHLD.Data.Migrations
{
    using BHLD.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BHLD.Data.BHLDDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BHLD.Data.BHLDDbContext context)
        {
            CreateHuTitle(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
        private void CreateHuTitle(BHLD.Data.BHLDDbContext context) {
            if (context.hu_Titles.Count() == 0)
            {
                List<hu_title> list= new List<hu_title>()
            {
                new hu_title() { code="1",title_name="title1",status=true },
                new hu_title() { code="2",title_name="title2",status=true },
                new hu_title() { code="3",title_name="title3",status=false },
                new hu_title() { code="4",title_name="title4",status=false },
                 
            };
                context.hu_Titles.AddRange(list);
                context.SaveChanges();
            }
        }
      
}
}
