using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShop.DataAcces.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public ICollection<Cake> Cakes { get; set; }
    }
}
