﻿using System;
using static FoodDelivery.ProgectInterface.CreatedProtuct;
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
                var input = int.Parse(Console.ReadLine());

                switch (input) 
                {
                    case 1: break;
                    case 2: AddingNewProduct(); break;
                    case 3: IsOpen = false; break;
                    default:Console.WriteLine("Ви вели не коректну команду ");break;
                }
            }
        }

        
    }
}
