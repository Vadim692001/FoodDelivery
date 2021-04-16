
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDelivery
{
  internal  class Data
    {
       private const string WayneStreet = "Wayne Street";
        private const string NorthHeatherStreet = "North Heather Street";
        private const char AddressSeparator = ' ';

        private const decimal DiscountChildrens = 0.75m;
        private const decimal DiscountInfants = 0.5m;
        private const decimal NeighborDiscountPercentage= 0.85m;

        private  const decimal DiscountWayneStreet = 10;
        private const decimal DiscountNorthHeatherStreet = 5.36m;

        private const decimal EuroExchange = 1.19m;
        private decimal GetFullPrice(
                                     IEnumerable<string> destinations,
                                     IEnumerable<string> clients,
                                     IEnumerable<int> infantsIds,
                                     IEnumerable<int> childrenIds,
                                     IEnumerable<decimal> prices,
                                     IEnumerable<string> currencies)
        {
            decimal fullPrice = default;
            decimal orderPrice = default;
          
            foreach (var item in clients) { Console.WriteLine($"Завмовники:\t{item}"); }
            Console.WriteLine("");
            foreach (var item in destinations) { Console.WriteLine($"Адрес доставки:\t{item}"); }
            Console.WriteLine("");

            if (!(prices.Count() == destinations.Count()) == (clients.Count() == currencies.Count()))
            {
                Console.WriteLine("Дані не коректні");
                return -1;
            }
            Console.WriteLine("");

            string pastAddress = default;
            foreach (var destination in destinations.Select((Value, Index) => (Value, Index)))
            {
                orderPrice = InitializeSumPrice(prices.ElementAt(destination.Index), orderPrice);
                orderPrice = DeliveryWayneStreet(destination.Value, orderPrice);
                orderPrice = DeliveryNorthHeatherStreet(destination.Value, orderPrice);
                orderPrice = DiscountInfant(infantsIds, destination.Index, orderPrice);
                orderPrice = DiscountСhildren(childrenIds, destination.Index, orderPrice);
                orderPrice = NeighborDiscount(pastAddress, destination.Value, orderPrice);
 
                if (currencies.ElementAt(destination.Index).Contains("EUR"))
                {
                    orderPrice *= EuroExchange;
                }
                pastAddress = destination.Value;
                
                Console.WriteLine(clients.ElementAt(destination.Index) + ":" + orderPrice);
                fullPrice += orderPrice;


            }
       
            Console.WriteLine("Загальна сума доставки:\t"+ fullPrice);
            return fullPrice;
        }
        private static decimal InitializeSumPrice(decimal price, decimal fullPrice)
        {
            fullPrice = price;

            return fullPrice;
        }
        private static decimal DiscountInfant(IEnumerable<int> infants, int destination, decimal sumPrice)
        {
            if (infants.Contains(destination))
            {
                sumPrice *= DiscountInfants;
            }

            return sumPrice;
        }
        private static decimal DiscountСhildren(IEnumerable<int> сhildrens, int destination, decimal sumPrice)
        {
            if (сhildrens.Contains(destination))
            {
                sumPrice = sumPrice * DiscountChildrens;
            }

            return sumPrice;
        }
        private static decimal DeliveryWayneStreet(string destination, decimal sumPrice) 
        {
            if (destination.Contains(WayneStreet))
            {
                sumPrice = sumPrice + DiscountWayneStreet;
            }
            return sumPrice;
        }
        private static decimal DeliveryNorthHeatherStreet(string destination, decimal sumPrice)
        {
            if (destination.Contains(NorthHeatherStreet))
            {
                sumPrice = sumPrice - DiscountNorthHeatherStreet;
            }
            return sumPrice;
        }
        private static decimal NeighborDiscount(string previousAddress, string nextAddress, decimal sumPrice)
        {
            
            if (NeighborDelivery(previousAddress, nextAddress))
            {
                return sumPrice *= NeighborDiscountPercentage;
            }

            return sumPrice;
        }

        private static bool NeighborDelivery(string previousAddress, string nextAddress)
        {
            return GetStreetNormal(previousAddress) == GetStreetNormal(nextAddress);

            static string GetStreetNormal(string fromAddress)
            {
                if (fromAddress is null || fromAddress is "")
                {
                    return default;
                }

                var parts = fromAddress.Split(AddressSeparator).Select(_ => _.Trim()).ToArray();
                return string.Join(AddressSeparator, parts.Skip(1));
            }
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

            var prices = new[] { 100, 25.23m,  58, 23.12m, 125 };
            var currencies = new[] { "USD", "USD", "EUR", "USD", "USD" };
            
            return GetFullPrice(destinations, clients, infantsIds, childrenIds, prices, currencies);
           
        }
    }
}

