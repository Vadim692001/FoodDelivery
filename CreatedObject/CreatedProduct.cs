using DeliveryFootRestorant;
using System;
using static FoodDelivery.ProgectInterface.OutputDataProductConsole;

namespace FoodDelivery.ProgectInterface
{
  public  class CreatedProduct
    {
        public static void CreateNewProduct() 
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
            DataCreatingOutputConsole(seller.CompanyName, seller.Product.Name, seller.Price);
                Console.ReadKey();
                Console.Clear();
            }  
        }
    }
}
