using FoodDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFootRestorant
{
   public class Customer
    {
        private int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public Customer() { Address = new Address(); }
        public Customer(string surname,string name,string adresscity,string adressstreat,string adresshouse,string adressroom) 
        {
            Address = new Address();
            Surname = surname;
            Name = name;
            Address.City = adresscity;
            Address.Street = adressstreat;
            Address.House = adresshouse;
            Address.Rooms = adressroom;
        }
    }
        

}
