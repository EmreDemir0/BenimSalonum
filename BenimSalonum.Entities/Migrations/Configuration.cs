namespace BenimSalonum.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BenimSalonum.Entities.Context.BenimSalonumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BenimSalonum.Entities.Context.BenimSalonumContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BenimSalonum.Entities.Context.BenimSalonumContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
