using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFootRestorant
{
    class Delivery
    {
        public int IdDelivery { get; set; }
        public Employee SurnameEmployee { get; set; }
        public Customer SurnameCustomer { get; set; }
        public Customer AddressCustomerCity { get; set; }
        public Customer AddressCustomerStreet { get; set; }
        public Customer AddressCustomerHouse { get; set; }
        public Customer AddressCustomerRooms { get; set; }
        public Product NameProduct { get; set; }
        public Customer PhoneCuctomer { get; set; }
        public decimal DeliveryTariff { get; set; }
        public DateTime DataDelivery { get; set; }
    }
}
