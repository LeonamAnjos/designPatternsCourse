using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IActualPrices proxy = new ActualPricesProxy();

            Console.WriteLine("Gold Price: ");
            Console.WriteLine(proxy.GoldPrice);

            Console.WriteLine("Silver Price: ");
            Console.WriteLine(proxy.SilverPrice);

            Console.WriteLine("Dollar to Ruppe Conversion: ");
            Console.WriteLine(proxy.DollarToRupee);

            Console.ReadLine();
        }
    }
}
