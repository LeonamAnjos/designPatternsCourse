using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_Turma02
{
    public class SituacaoFaturado : ISituacao
    {
        private PEG Peg;

        public SituacaoFaturado(PEG peg)
        {
            this.Peg = peg;
        }

        public void MudarFase()
        {
            Console.WriteLine("PEG está faturado!");
        }
    }
}
