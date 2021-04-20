using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFootRestorant
{
    public class Product
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public int Amount { get; set; }
    }
}
