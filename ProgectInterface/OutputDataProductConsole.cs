using System;
using static FoodDelivery.TestData.TestDataProduct;

namespace FoodDelivery.ProgectInterface
{
  public   class OutputDataProductConsole
    {
        public static decimal OutputDataConsole(int numberProduct, int numberPortion)
        {
            Console.WriteLine($"Назва продукту:{products[numberProduct - 1].Name,10}," +
                        $"Ціна за порцію:{products[numberProduct - 1].Price}," +
                        $"Кількість замовлених порцій:{numberPortion}" +
                        $"Сума до сплати:{(products[numberProduct - 1].Price) * numberPortion}");
            return (products[numberProduct - 1].Price) * numberPortion;
        }
    }
}
