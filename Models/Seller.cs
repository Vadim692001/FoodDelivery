using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFootRestorant
{
    public class Seller
    {
        private int Id { get; set; }
        public string CompanyName { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
    }
}
