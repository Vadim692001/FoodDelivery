  
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

        public void OutputConsole()
        {
            TestDataCustomers();
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"Прізвище клієнта:{customers[i].Surname,10}," +
                    $"Ім'я клієнта:{customers[i].Name,10}," +
                    $"Місто:{customers[i].Address.City,8}," +
                    $"Вулиця:{customers[i].Address.Street,8}," +
                    $"Будинок:{customers[i].Address.House,5}," +
                    $"Кімната:{customers[i].Address.Rooms,5},");
            }

        }
    }
}
