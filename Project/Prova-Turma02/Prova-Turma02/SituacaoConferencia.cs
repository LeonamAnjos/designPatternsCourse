using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_Turma02
{
    public class SituacaoConferencia : ISituacao
    {
        private PEG Peg;

        public SituacaoConferencia(PEG peg)
        {
            this.Peg = peg;
        }

        public void MudarFase()
        {
            Peg.Situacao = new SituacaoPronto(Peg);
            Console.WriteLine("De Conferência para Pronto!");
        }
    }
}
