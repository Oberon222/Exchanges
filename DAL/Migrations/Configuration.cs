namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ExchangeModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ExchangeModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var ex1 = context.Exchanges.Add(new Exchange() { Name = "dollat", Rate = 28.85M });

            var ex2 = context.Exchanges.Add(new Exchange() { Name = "euro", Rate = 33.47M });
            var ex3 = context.Exchanges.Add(new Exchange() { Name = "zloty", Rate = 7.35M });
            context.SaveChanges();
        }
    }
}
