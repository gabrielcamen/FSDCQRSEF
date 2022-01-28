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
    }
}
