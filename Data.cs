
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDelivery
{
    class Data
    {
        private decimal GetFullPrice(
                                     IEnumerable<string> destinations,
                                     IEnumerable<string> clients,
                                     IEnumerable<int> infantsIds,
                                     IEnumerable<int> childrenIds,
                                     IEnumerable<decimal> prices,
                                     IEnumerable<string> currencies)
        {
            decimal fullPrice = default;
            decimal sumPrice = default;

            foreach (var etem in clients) { Console.WriteLine($"Завмовники:\t{etem}"); }
            Console.WriteLine("");
            foreach (var etem in destinations) { Console.WriteLine($"Адрес доставки:\t{etem}"); }
            Console.WriteLine("");
           
           
            var price = prices.ToArray();
            var destination = destinations.ToArray();
            var client = clients.ToArray();
            var currencie = currencies.ToArray();
           
            if (!(price.Length == destination.Length) == (client.Length == currencie.Length))
            {
                Console.WriteLine("Дані не коректні");
                return -1;
            }
            Console.WriteLine("");
            for (int i = 0; i < destination.Length; i++)
            {
                sumPrice = price[i];
                if (currencie[i] == "EUR")
                {
                    sumPrice = price[i] * 1.19m;
                }
                switch (client[i])
                {
                    case "Autumn Baldwin": sumPrice = price[i]; break;
                    case "Jorge Hoffman": sumPrice = price[i] + 10; break;
                    case "Amiah Simmons": sumPrice = (price[i] - 5.36m) * 0.5m; break;
                    case "Sariah Bennett": sumPrice = (price[i] - 5.36m) * 0.75m; break;
                    case "Xavier Bowers": sumPrice = price[i] * 0.75m; break;
                }
                if ((client[i] == "Sariah Bennett" && client[i -1] == "Amiah Simmons" || client[i] == "Amiah Simmons" && client[i-1] == "Sariah Bennett")) 
                {
                    sumPrice *=  0.85m;
   
                }
                fullPrice += sumPrice;
                Console.WriteLine($"{client[i]} :вартість доставки:\t {sumPrice}");  
            }
            Console.WriteLine("Загальна сума доставки:\t"+ fullPrice);
            return fullPrice;
        }


public decimal InvokePriceCalculatiion()
        {
            
            
            var destinations = new[]
            {  
                "949 Fairfield Court, Madison Heights, MI 48071",
                "367 Wayne Street, Hendersonville, NC 28792",
                "910 North Heather Street, Cocoa, FL 32927",
                "911 North Heather Street, Cocoa, FL 32927",
                "706 Tarkiln Hill Ave, Middleburg, FL 32068",
            };

            var clients = new[]
            { 
                "Autumn Baldwin",
                "Jorge Hoffman",
                "Amiah Simmons",
                "Sariah Bennett",
                "Xavier Bowers",

            };

            var infantsIds = new[] { 2 };
            var childrenIds = new[] { 3, 4 };

            var prices = new[] { 100, 25.23m, 58, 23.12m, 125 };
            var currencies = new[] { "USD", "USD", "EUR", "USD", "USD" };
            
           
            return GetFullPrice(destinations, clients, infantsIds, childrenIds, prices, currencies);
           
        }

        
        
    }
}

