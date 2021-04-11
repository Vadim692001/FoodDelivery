
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

            // Your solution supposed to be here.
            // IEnumerable<string> northheatherstreet = destinations.Where(destinations => destinations.Contains("North Heather Street"));
            //int waynesreet = destinations.TakeWhile(destinations =>! destinations.Contains("North Heather Street")).Count();
            //var price = prices.ElementAt(waynesreet);
            //fullPrice = price + 10;

            var price = prices.ToArray();
            var way= price[1]+10;
            var nor = ((price[2] - 5.48m)*0.5m)* 1.19m;
            var nor1 = ((price[3] - 5.48m)-4.41m)-1.98m;
            var ta = (price[4] - 31.25m);
            Console.WriteLine( fullPrice = price[0] + way + nor + nor1+ta ); 
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

