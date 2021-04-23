using System;
using static FoodDelivery.TestData.TestDataProduct;
using static FoodDelivery.DataValidity.DataValidity;
using static FoodDelivery.ProgectInterface.CreatedOrderProduct;
;
namespace FoodDelivery.ProgectInterface
{
 //public  class OutputCreatedOrderProduct
 //   {

 //       public static decimal OrderFormation()
 //       {
 //           decimal fullPrice = default;
 //           decimal orderPrice = default;
 //           Console.Write("Скільки замовлень ви хочете замовити:\t");
 //           int.TryParse(Console.ReadLine(), out int number);
 //           for (int i = 0; i < number; i++)
 //           {
 //               Console.Write("Ведіть номер товару:");
 //               int.TryParse(Console.ReadLine(), out int numberProduct);
 //               Console.Write("Ведіть кількість порцій:");
 //               int.TryParse(Console.ReadLine(), out int numberPortion);
 //               if (AvailabilityPortions(numberPortion, numberProduct) != true) { products.Clear(); break; }
 //               orderPrice = OutputDataConsole(numberProduct, numberPortion);
 //               fullPrice += orderPrice;
 //           }
 //           Console.WriteLine("Загальна сума:" + fullPrice);
 //           products.Clear();
 //           return fullPrice;
 //       }
 //   }
}
