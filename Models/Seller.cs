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

        public Seller() { Product = new Product(); }
        public Seller(string companeName,string product,decimal price) 
        {
            Product = new Product();
            companeName = CompanyName;
            product = Product.Name;
            price = Price;
        }
    }
}
