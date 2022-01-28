namespace SweetShop.DataAcces.Migrations
{
    using SweetShop.DataAcces.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SweetShop.DataAcces.SweetShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
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
                Id = 2,
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
                Name = "Eclair",
                Price = 12
            });
            context.Cakes.AddOrUpdate(new Cake()
            {
                Id = 2,
                Name = "Medovik",
                Price = 7
            });
            context.Cakes.AddOrUpdate(new Cake()
            {
                Id = 3,
                Name = "Padurea neagra",
                Price = 8
            });
            context.Cakes.AddOrUpdate(new Cake()
            {
                Id = 4,
                Name = "Chec",
                Price = 4
            });
            context.Cakes.AddOrUpdate(new Cake()
            {
                Id = 4,
                Name = "Chec",
                Price = 4
            });
            context.Orders.AddOrUpdate(new Order()
            {
                Id = 1,
                Cakes = new List<Cake>
                {
                    new Cake
                    {
                        Name = "Amandina",
                        Price = 12
                    },
                    new Cake
                    {
                        Name = "Covrig",
                        Price = 2.5
                    },
                    new Cake
                    {
                        Name = "Tort de ciocolata",
                        Price = 50
                    },
                    new Cake
                    {
                        Name = "Placinta cu mere",
                        Price = 10
                    },
                }
            });

            context.Orders.AddOrUpdate(new Order()
            {
                Id = 2,
                Cakes = new List<Cake>
                {
                    new Cake
                    {
                        Name = "Tort de ciocolata",
                        Price = 50
                    }
                }
            });
            context.Orders.AddOrUpdate(new Order()
            {
                Id = 3,
                Cakes = new List<Cake>
                {
                    new Cake
                    {
                        Name = "Tort de ciocolata",
                        Price = 50
                    },
                    new Cake
                    {
                        Name = "Saratele",
                        Price = 15
                    },
                }
            });
        }
    }
}
