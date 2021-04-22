
using DeliveryFootRestorant;
using FoodDelivery.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.TestData
{
   public static class TestDataProduct
    {
     public static List<Product> products = new List<Product>();

        private   static List<Product> TestDataProducts()
        {
            products.Add(new Product("Хінкалі",150,60,9));
            products.Add(new Product("Борщ", 250, 70, 8));
            products.Add(new Product("Крем суп", 250, 80, 7));
            products.Add(new Product("Салат Цезарь", 320, 290, 9));
            products.Add(new Product("Торт Наполіон", 1000, 260, 7));
            products.Add(new Product("Торт Спартак", 1000, 250, 6));
            products.Add(new Product("Шашлик", 230, 90, 12));
            products.Add(new Product("Вареники", 130, 160, 11));
            products.Add(new Product("Салат Сезоний", 300, 100, 13));
            
            return products;
        }

        public static void OutputConsole()
        {
            TestDataProducts();
            for (int i = 0; i < products.Count; i++)
            {
                Console.Write(i+1+"\t");
                Console.WriteLine($"Назва страви:{products[i].Name ,10},\tМаса в одній порції:{products[i].Mass},\t" +
                    $"Ціна за порцію:{products[i].Price},\tПорцій в найовності:{products[i].Portion}\t") ;
            }

        }

     
    }

}
