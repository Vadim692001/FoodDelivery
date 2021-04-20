using FoodDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFootRestorant
{
    public class Delivery
    {
        private int Id { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public Product Product { get; set; }
        public decimal DeliveryTariff { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
