using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatter
{
    /// <summary>
    /// Cliente Original
    /// </summary>

    class GeradorRelatorio
    {
        public void ImprimirColaboradores(SistemaRH rh) 
        {
            Console.WriteLine("######### Lista de Colaboradores ##########");

            string[][] lista = rh.GetColaboradores();
            
            foreach (var item in lista)
            {
                Console.WriteLine(item[0] + " - " + item[1]);
            }
        }
    }
}
