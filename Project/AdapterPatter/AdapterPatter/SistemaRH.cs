using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatter
{
    /// <summary>
    /// Adaptee (precisa ser adaptado)
    /// </summary>
    class SistemaRH 
    {
        /// <summary>
        /// SpecificRequest()
        /// </summary>
        public string[][] GetColaboradores()
        {
            string[][] colaboradores = new string[4][];

            colaboradores[0] = new string[] { "100", "Deepak" };
            colaboradores[1] = new string[] { "101", "Rohit" };
            colaboradores[2] = new string[] { "102", "Gautam" };
            colaboradores[3] = new string[] { "103", "Dev"};

            return colaboradores;
        }
    }

    /// <summary>
    /// Adapter - herança e implementação da interface
    /// </summary>
    class SistemaRHAdaptado_B : SistemaRH, IListaParaImprimir
    {
        public List<string> GetLista()
        {
            List<string> lista = new List<string>();

            foreach (var item in GetColaboradores())
            {
                lista.Add(item[0] + " - " + item[1]);
            }

            return lista;
        }
    }

    /// <summary>
    /// Adapter - apenas implementação da interface
    /// </summary>
    class SistemaRHAdaptado_A : IListaParaImprimir
    {
        private SistemaRH _sistemaRH; // adaptee

        public SistemaRHAdaptado_A(SistemaRH rh)
        {
            _sistemaRH = rh;
        }

        public List<string> GetLista()
        {
            List<string> lista = new List<string>();

            foreach (var item in _sistemaRH.GetColaboradores())
            {
                lista.Add(item[0] + " - " + item[1]);
            }

            return lista;
        }



    }


}
