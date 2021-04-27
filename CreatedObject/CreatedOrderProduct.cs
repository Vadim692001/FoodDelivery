using System;
using static FoodDelivery.TestData.TestDataProduct;
using static FoodDelivery.ValidateData.Check;
using static FoodDelivery.ProgectInterface.OutputDataProductConsole;

namespace FoodDelivery.ProgectInterface
{
    public class CreatedOrderProduct
    {

        public static void Order()
        {
            Console.Clear();
            Console.WriteLine("------------Раді вас вітати в нашому сервісі------------------");
            Console.WriteLine("Наявні товари ");
            OutputStartDataConsole();
            OrderFormation();
        }

        private static decimal OrderFormation()
        {
            decimal fullPrice = default;
            decimal orderPrice = default;
            Console.Write("Скільки замовлень ви хочете замовити:\t");
            int.TryParse(Console.ReadLine(), out int number);
            for (int i = 0; i < number; i++)
            {
                Console.Write("Ведіть номер товару:");
                int.TryParse(Console.ReadLine(), out int numberProduct);
                Console.Write("Ведіть кількість порцій:");
                int.TryParse(Console.ReadLine(), out int numberPortion);
                if (AvailabilityPortions(numberPortion, numberProduct) != true) { products.Clear(); break; }
                orderPrice = OutputDataConsole(numberProduct, numberPortion);
                fullPrice += orderPrice;
                NewPortion(numberPortion, numberProduct);
                OutputNewPortionDataConsole();
            }
            Console.WriteLine("Загальна сума:" + fullPrice);
            products.Clear();
            return fullPrice;
        }

      
    }
}
