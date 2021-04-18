using System;


namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Data data = new Data();
            Console.WriteLine("Доставка їжі Блиц-блиц без границ");
            Console.WriteLine("");
            data.InvokePriceCalculatiion();
            Console.ReadLine();
        }
        
    }
}
