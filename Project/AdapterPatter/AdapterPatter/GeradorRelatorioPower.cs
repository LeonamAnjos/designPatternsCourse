using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatter
{
    /// <summary>
    /// Target
    /// </summary>
    interface IListaParaImprimir
    {
        List<string> GetLista();
    }


    /// <summary>
    /// Novo Cliente (cliente que queremos atender)
    /// </summary>
    class GeradorRelatorioPower
    {
        public void Imprimir(String titulo, IListaParaImprimir lista)
        {
            
            Console.WriteLine("--------- {0} ---------", titulo);

            List<string> l = lista.GetLista();

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
