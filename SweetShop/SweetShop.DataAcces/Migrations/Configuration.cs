namespace SweetShop.DataAcces.Migrations
{
    using SweetShop.DataAcces.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SweetShop.DataAcces.SweetShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SweetShop.DataAcces.SweetShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 1,
                FirstName = "Ion",
                LastName = "Ion"
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id= 2,
                FirstName = "Maria",
                LastName = "Maria"
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 3,
                FirstName = "Vasile",
                LastName = "Vasile"
            });

            context.Cakes.AddOrUpdate(new Cake()
            {
                Id = 1,
                Name = "Ecler",
                Price = 12
            });


        }
    }
}
