using SweetShop.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShop.DataAcces
{
    public class SweetShopDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Order> Orders { get; set; }

        public SweetShopDbContext()
        {
            Database.SetInitializer<SweetShopDbContext>(new DropCreateDatabaseAlways<SweetShopDbContext>());
        }
    }
}
