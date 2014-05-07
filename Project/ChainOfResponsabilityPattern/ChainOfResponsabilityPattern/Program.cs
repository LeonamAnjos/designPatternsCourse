using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsabilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //TratarRequisicoesUmaCamada();
            TratarRequisicoesTresCamadas();

            Console.ReadKey();
        }

        /// <summary>
        /// Toda requisição é tratada pela aplicação (útlima cadama)
        /// </summary>
        static void TratarRequisicoesUmaCamada()
        {
            IHelp app = new Application();

            int[] requests = { 12, 8, 6, 33, 26, 1, 9, 40 };

            foreach (int r in requests)
            {
                app.getHelp(r);
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Três camadas para tratar uma requisição
        /// </summary>
        static void TratarRequisicoesTresCamadas()
        {
            //Application app = new Application();
            //IntermediateLayer intermediateLayer = new IntermediateLayer(app);
            //FrontEnd frontEnd = new FrontEnd(intermediateLayer);

            IHelp app = new Application();
            app = new IntermediateLayer(app);
            app = new FrontEnd(app);

            int[] requests = { 12, 8, 6, 33, 26, 1, 9, 40 };

            foreach (int r in requests)
            {
                app.getHelp(r);
                Console.WriteLine();
            }
        }

        
    }
}
