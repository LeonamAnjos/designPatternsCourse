using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject();

            s.OnChange += (sender, e) => Console.WriteLine("Evento lançado: {0}", e.Value);
            s.OnChange += (sender, e) => Console.WriteLine("Evento passado: {0}", e.Value);
            s.OnChange += (sender, e) => Console.WriteLine("Evento testado: {0}", e.Value);

            s.OnChange += (sender, e) => Console.WriteLine("Evento ultimo: {0}", e.Value);

            s.MudarFase();

            Console.ReadKey();
        }

        static void Metodo(Object sender, MyArgs e)
        {
            Console.WriteLine("Evento lançado: {0}", e.Value); ;
        }
    }
}
