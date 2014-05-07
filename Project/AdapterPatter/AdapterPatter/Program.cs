using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaRH rh = new SistemaRH();

            GeradorRelatorio gr = new GeradorRelatorio();
            gr.ImprimirColaboradores(rh);


            GeradorRelatorioPower grp = new GeradorRelatorioPower();

            grp.Imprimir("Lista Power_A de Colaboradores", new SistemaRHAdaptado_A(rh));
            grp.Imprimir("Lista Power_B de Colaboradores", new SistemaRHAdaptado_B());

            Console.ReadKey();

        }
    }
}
