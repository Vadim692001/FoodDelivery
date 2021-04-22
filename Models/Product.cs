
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

        public Product() { }
        public Product(string name, double mass, decimal price, int amount)
        {
            name = Name;
            mass = Mass;
            price = Price;
            amount = Amount;
        }

      
    }
}
