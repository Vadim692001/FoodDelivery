  
using DeliveryFootRestorant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.TestData
{
    class TestDataCustomer
    {
       public List<Customer> customers = new List<Customer>();

        private List<Customer> TestDataCustomers()
        {
            customers.Add(new Customer("Іванов"," Віктор", "Вінниця", "Юності", "12Б", "43"));
            customers.Add(new Customer("Шевченко", " Андрій", "Вінниця", "Космонавтів", "125", "21"));
            customers.Add(new Customer("Бегеба", " Володимер", "Вінниця", "Келецька", "98", "419"));

            return customers;
        }
       }
    }

