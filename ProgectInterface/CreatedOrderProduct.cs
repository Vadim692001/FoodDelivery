using System;
using static FoodDelivery.TestData.TestDataProduct;



namespace FoodDelivery.ProgectInterface
{
    public class CreatedOrderProduct
    {

        public static void Order()
        {
            Console.Clear();
            Console.WriteLine("------------Раді вас вітати в нашому сервісі------------------");
            Console.WriteLine("Наявні товари ");
            OutputConsole();
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
            }
            Console.WriteLine("Загальна сума:" + fullPrice);
            return fullPrice;
        }
        private static decimal OutputDataConsole(int numberProduct, int numberPortion)
        {
            Console.WriteLine($"Назва продукту:{products[numberProduct - 1].Name,10}," +
                        $"Ціна за порцію:{products[numberProduct - 1].Price}," +
                        $"Кількість замовлених порцій:{numberPortion}" +
                        $"Сума до сплати:{(products[numberProduct - 1].Price) * numberPortion}");
            return (products[numberProduct - 1].Price) * numberPortion;
        }
        private static bool AvailabilityPortions(int numberPortion, int numberProduct)
        {
            if (products[numberProduct - 1].Portion <= numberPortion)
            {
                Console.WriteLine("Не достатнь поцій,можливо замовите щось інше");
                return false;

            }
            return true;
        }
    }
}
