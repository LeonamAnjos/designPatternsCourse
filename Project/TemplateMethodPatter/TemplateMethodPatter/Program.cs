using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var roboA = new RoboAutomotivo();
            roboA.Executar();
            Console.WriteLine();

            var roboM= new RoboMicreiro();
            roboM.Executar();
            Console.WriteLine();

            var roboC = new RoboChapeiro();
            roboC.Executar();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
