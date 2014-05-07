using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer c = new Computer();
            Console.WriteLine(c.descricao());
            
            c = new Disk(c);
            Console.WriteLine(c.descricao());
            
            c = new Monitor(c);
            Console.WriteLine(c.descricao());

            Console.ReadKey();
        }
    }
}
