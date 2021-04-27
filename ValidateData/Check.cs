using DeliveryFootRestorant;
using System;
using System.Collections.Generic;
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

        public static int NewPortion(int numberPortion, int numberProduct) 
        {
            var NewPortion = products[numberProduct - 1].Portion - numberPortion;
       
            return products[numberProduct - 1].Portion = NewPortion; 
        } 
    }
}
