using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova01_Questao01
{
    public interface ISituacao
    {
        void MudarFase(PEG peg);
    }

    public class SituacaoDigitacao : ISituacao
    {
        public void MudarFase(PEG peg)
        {
            Console.WriteLine("De Digitação para Conferência.");
            peg.Situacao = new SituacaoConferencia();
        }
    }

    public class SituacaoConferencia : ISituacao
    {
        public void MudarFase(PEG peg)
        {
            Console.WriteLine("De Conferência para Pronto.");
            peg.Situacao = new SituacaoPronto();
        }
    }


    public class SituacaoPronto : ISituacao
    {
        public void MudarFase(PEG peg)
        {
            Console.WriteLine("De Pronto para Faturado.");
            peg.Situacao = new SituacaoFaturado();
        }
    }


    public class SituacaoFaturado : ISituacao
    {
        public void MudarFase(PEG peg)
        {
            Console.WriteLine("PEG faturado. Não é possível mudar de fase.");
        }
    }

    


}
