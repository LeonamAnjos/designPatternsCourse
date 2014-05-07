using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new StreetRacer().go());
            Console.WriteLine(new FormulaOne().go());
            Console.WriteLine(new Helicopter().go());
            Console.WriteLine(new Jet().go());
            
            
            Console.ReadKey();
        }
    }
}
