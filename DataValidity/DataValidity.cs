using System;
using static FoodDelivery.TestData.TestDataProduct;

namespace FoodDelivery.DataValidity
{
 public   class DataValidity
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
