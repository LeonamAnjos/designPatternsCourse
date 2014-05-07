using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_Questao01
{
    public class PEG
    {
        public event Action<PEG> AoMudarFase = delegate { };
        public ISituacao Situacao { get; set; }

        public PEG()
        {
            Situacao = new SituacaoDigitacao();
        }

        public void MudarFase() 
        {
            Situacao.MudarFase(this);
            Notificar();
        }

        private void Notificar()
        {
            AoMudarFase(this);
        }
    }
}
