using DeliveryFootRestorant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.ProgectInterface
{
  public  class CreatedProduct
    {
<<<<<<< HEAD:ProgectInterface/CreatedProduct.cs
        public static void CreatedNewProduct() 
=======
        public static void CreateNewProduct() 
>>>>>>> 97737ab31849cb0b626113767c128bf7520667be:ProgectInterface/CreatedProtuct.cs
        {
            Seller seller = new Seller();
            Console.WriteLine("Скільки продуктів ви хочете додати");
            int.TryParse(Console.ReadLine(), out int number);
            for (int i = 0; i < number; i++)
            {
            Console.WriteLine("Ведіть назву свого ресторану(фірми) ");
            seller.CompanyName = Console.ReadLine(); 
            Console.WriteLine("Ведіть товар який хочете продавати ");
            seller.Product.Name=Console.ReadLine();
            Console.WriteLine("Ведіть ціну за якою продаватимете свій товар ");
            decimal.TryParse(Console.ReadLine(), out decimal res);
            seller.Price = res;
            Console.WriteLine("-------------------Товар додано--------------------");
            DataOutputConsole(seller.CompanyName, seller.Product.Name, seller.Price);
                Console.ReadKey();
                Console.Clear();
            }  
        }

        private static void DataOutputConsole(string companyName, string productname, decimal price)
        {
            
            Console.WriteLine($"Назва фірми:{companyName},\tНазва продукту:{productname},\t Ціна від продавця:{price}\t");
        }

       
    }
}
