using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Turma02
{
    public class PEG
    {
        public event Action<OcorrenciaFase> OnMudarFase;

        public ISituacao Situacao;

        public PEG() {
            this.Situacao = new SituacaoDigitacao(this);
        }

        public void MudarFase()
        {
            var ocorrencia = new OcorrenciaFase();
            ocorrencia.Peg = this;
            ocorrencia.SituacaoAnterior = Situacao;

            Situacao.MudarFase();

            ocorrencia.SituacaoAtual = Situacao;
            NotificarMudancaFase(ocorrencia);
        }

        public void NotificarMudancaFase(OcorrenciaFase ocorrencia)
        {
            if (OnMudarFase == null)
                return;

            OnMudarFase(ocorrencia);
        }

        public bool DeveLiberar = false;

    }
}


