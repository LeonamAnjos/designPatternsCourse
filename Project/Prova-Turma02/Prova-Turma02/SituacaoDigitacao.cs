using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_Turma02
{
    public class SituacaoDigitacao : ISituacao
    {
        private PEG Peg;

        public SituacaoDigitacao(PEG peg)
        {
            this.Peg = peg;
        }

        public void MudarFase()
        {
            Peg.Situacao = new SituacaoConferencia(Peg);
            Console.WriteLine("De Digitação para Conferência!");
        }
    }
}
