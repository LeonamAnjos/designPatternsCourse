using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_Turma02
{
    public class SituacaoPronto : ISituacao
    {
        private PEG Peg;

        public SituacaoPronto(PEG peg)
        {
            this.Peg = peg;
        }

        public void MudarFase()
        {
            if (Peg.DeveLiberar)
            {
                Peg.Situacao = new SituacaoLiberado(Peg);
                Console.WriteLine("De Pronto para Liberado!");
            }
            else
            {
                Peg.Situacao = new SituacaoFaturado(Peg);
                Console.WriteLine("De Pronto para Faturado!");
            }

            
            
        }
    }
}
