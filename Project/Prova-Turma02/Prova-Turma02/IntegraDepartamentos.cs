using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Turma02
{
    public class IntegraDepartamentos
    {

        public void Atualizar(OcorrenciaFase ocorrencia)
        {
            if (ocorrencia.SituacaoAtual is SituacaoConferencia)
            {
                ChamarDepContasMedicas(ocorrencia.Peg);
            }
            else if (ocorrencia.SituacaoAtual is SituacaoPronto)
            {
                ChamarDepCorporativo(ocorrencia.Peg);
            }
            else if (ocorrencia.SituacaoAtual is SituacaoFaturado)
            {
                ChamarDepFinanceiro(ocorrencia.Peg);
            }

        }


        public void ChamarDepFinanceiro(PEG peg)
        {
            Console.WriteLine("Dep Financeiro");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ChamarDepContasMedicas(PEG peg)
        {
            Console.WriteLine("Dep Contas Médicas");
            Console.WriteLine(); Console.WriteLine();
        }

        public void ChamarDepCorporativo(PEG peg)
        {
            Console.WriteLine("Dep Corporativo");
            Console.WriteLine();
            Console.WriteLine();
        }



    }
}
