using System;
using static FoodDelivery.TestData.TestDataProduct;

namespace FoodDelivery.ProgectInterface
{
  public   class OutputDataProductConsole
    {
        public static void OutputStartDataConsole()
        {
            TestDataProducts();
            for (int i = 0; i < products.Count; i++)
            {
                Console.Write(i + 1 + "\t");
                Console.WriteLine($"Назва страви:{products[i].Name,10},\tМаса в одній порції:{products[i].Mass},\t" +
                    $"Ціна за порцію:{products[i].Price},\tПорцій в найовності:{products[i].Portion}\t");
            }

        }
        public static void OutputNewPortionDataConsole()
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                Console.Write(i + 1 + "\t");
                Console.WriteLine($"Назва страви:{products[i].Name,10},\tМаса в одній порції:{products[i].Mass},\t" +
                    $"Ціна за порцію:{products[i].Price},\tПорцій в найовності:{products[i].Portion}\t");
            }

        }
        public static decimal OutputDataConsole(int numberProduct, int numberPortion)
        {
            Console.WriteLine($"Назва продукту:{products[numberProduct - 1].Name,10}," +
                        $"Ціна за порцію:{products[numberProduct - 1].Price}," +
                        $"Кількість замовлених порцій:{numberPortion}" +
                        $"Сума до сплати:{(products[numberProduct - 1].Price) * numberPortion}");
            return (products[numberProduct - 1].Price) * numberPortion;
        }

        public static void DataCreatingOutputConsole(string companyName, string productname, decimal price)
        {

            Console.WriteLine($"Назва фірми:{companyName},\tНазва продукту:{productname},\t Ціна від продавця:{price}\t");
        }
    }
}
