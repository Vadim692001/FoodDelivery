using System;
using static FoodDelivery.TestData.TestDataProduct;
namespace FoodDelivery.ValidateData
{
   public class Check
    {
        public static bool AvailabilityPortions(int numberPortion, int numberProduct)
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
