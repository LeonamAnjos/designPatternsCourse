using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_Turma02
{
    public class SituacaoLiberado : ISituacao
    {
        private PEG Peg;

        public SituacaoLiberado(PEG peg)
        {
            this.Peg = peg;
        }

        public void MudarFase()
        {
            Peg.Situacao = new SituacaoFaturado(Peg);
            Console.WriteLine("De Liberado para Faturado!");
        }

    }
}
