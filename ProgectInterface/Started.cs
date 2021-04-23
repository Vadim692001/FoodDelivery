using System;
using static FoodDelivery.ProgectInterface.CreatedProduct;
using static FoodDelivery.ProgectInterface.CreatedOrderProduct;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.ProgectInterface
{
   public static class  Started
    {
        private static bool IsOpen = true;
        public static void Run() 
        {
            while (IsOpen) 
            {
                Console.WriteLine("Доставка їжі Блиц-блиц без границ");
                Console.WriteLine("----------------Команди---------------:");
                Console.WriteLine("Якщо ви покупець натисніть 1:");
                Console.WriteLine("Якщо ви продавець натисніть 2:");
                Console.WriteLine("Вихід 3:");
                Console.Write("Ведіть команду:");
                int.TryParse(Console.ReadLine(),out int input);

                switch (input) 
                {
                    case 1: Order(); break;
                    case 2: CreatedNewProduct(); break;
                    case 3: IsOpen = false; break;
                    default:Console.WriteLine("Ви вели не коректну команду ");break;
                        
                }
            }
        }
    }
}
