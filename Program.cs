using System;


namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Run();
            Console.ReadLine();
        }

        public static void Run()
        {
            Data data = new Data();
            while (true)
            {
                Console.WriteLine("Доставка їжі Блиц-блиц без границ");
                Console.WriteLine("");
                data.InvokePriceCalculatiion(); break;
                Console.ReadKey();   

            }
            
        }
    }
}
