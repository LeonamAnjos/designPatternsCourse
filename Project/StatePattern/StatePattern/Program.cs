using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Executar(new Locacao(2));
            ExecutarState(new NovaLocacao(2));

            Console.ReadKey();

        }

        static void ExecutarState(NovaLocacao locacao)
        {
            locacao.receberProposta();
            locacao.consultarProposta();
            Console.WriteLine();


            locacao.receberProposta();
            locacao.consultarProposta();
            Console.WriteLine();


            locacao.receberProposta();
            locacao.consultarProposta();
            Console.WriteLine();

         
        }

        static void Executar(Locacao locacao)
        {

            locacao.receberProposta();
            locacao.consultarProposta();
            Console.WriteLine();


            locacao.receberProposta();
            locacao.consultarProposta();
            Console.WriteLine();


            locacao.receberProposta();
            locacao.consultarProposta();
            Console.WriteLine();
        }

    }
}
