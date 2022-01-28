using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShop.DataAcces.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Cake Cake { get; set; }
    }
}
