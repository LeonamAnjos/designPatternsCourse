using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_Questao01
{
    public class Integrador
    {
        string descricao = "Integrador";

        public void MudouDeFase(PEG peg)
        {
            if (peg.Situacao is SituacaoConferencia)
            {
                Console.WriteLine("Notificar departamento A");
            }
            else if (peg.Situacao is SituacaoPronto)
            {
                Console.WriteLine("Notificar departamento B");
            }
            else if (peg.Situacao is SituacaoFaturado)
            {
                Console.WriteLine("Notificar departamento C");
            }
        }
    }
}
