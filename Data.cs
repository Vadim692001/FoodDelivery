
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
                                     IEnumerable<string> currencies )
        {
           decimal fullPrice = default;

            // Your solution supposed to be here.
           
                     foreach (var etem in clients) { Console.WriteLine($"Звмовники:\t{etem}"); }
                     Console.WriteLine("");
                     foreach (var etem in destinations) { Console.WriteLine($"Адрес доставки:\t{etem}"); }
                     Console.WriteLine("");
                     foreach (var etem in prices) { Console.WriteLine($"Вартість достави без урахування знижки:\t{etem}");  }
                     Console.WriteLine("");
                     foreach (var etem in currencies) { Console.WriteLine($"Валюта якою розраховуватиметься замовник:\t{etem}"); }

            //int waynesreet = destinations.TakeWhile(destinations =>! destinations.Contains("North Heather Street")).Count();
            //var price = prices.ElementAt(waynesreet);
            //fullPrice = price + 10;
            var price = prices.ToArray();
            var destination = destinations.ToArray();
            var client = clients.ToArray();
            var currencie = currencies.ToArray();
            if ((price.Length == destination.Length) == (client.Length == currencie.Length))
            {
                var deliveryForJorgeHoffman = price[1] + 10;
                var deliveryForAmiahSimmons = ((price[2] - 5.48m) * 0.5m) * 1.19m;
                var deliveryForSariahBennett = ((price[3] - 5.48m) - 4.41m) - 1.98m;
                var deliveryForXavierBowers = (price[4] - 31.25m);
                fullPrice = (price[0] + deliveryForJorgeHoffman + deliveryForAmiahSimmons + deliveryForSariahBennett + deliveryForXavierBowers);
                Console.WriteLine("");
                Console.WriteLine("Сума яку заплатить перший замовник:\t" + price[0]);
                Console.WriteLine("Сума яку заплатить другий замовник:\t" + deliveryForJorgeHoffman);
                Console.WriteLine("Сума яку заплатить третій замовник:\t" + deliveryForAmiahSimmons);
                Console.WriteLine("Сума яку заплатить четвертий замовник:\t" + deliveryForSariahBennett);
                Console.WriteLine("Сума яку заплатить п'ятий замовник:\t" + deliveryForXavierBowers);
                Console.WriteLine("");
                Console.WriteLine($"Загальна сума доставки:{fullPrice}");
                Console.WriteLine("");
            }
            else { Console.WriteLine("Дані не коректні"); }
           

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

