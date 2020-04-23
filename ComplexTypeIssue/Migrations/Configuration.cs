using ComplexTypeIssue.Models;

namespace ComplexTypeIssue.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ComplexTypeIssue.Models.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ComplexTypeIssue.Models.TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.TestModels.Add(new TestModel()
                {Description = new LocalizedString() {De = "Hallo", En = "Hello", Fr = "Bonjour", Nl = "Goedendag"}});

            context.TestModels.Add(new TestModel()
                { Description = new LocalizedString() { De = "Auf wiedersehen", En = "Goodbye", Fr = "Au revoir", Nl = "Tot later" } });
        }
    }
}
