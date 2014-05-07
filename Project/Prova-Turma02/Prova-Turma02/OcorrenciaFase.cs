using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Turma02
{
    public class OcorrenciaFase
    {
        public PEG Peg { get; set; }
        public ISituacao SituacaoAnterior { get; set; }
        public ISituacao SituacaoAtual    { get; set; }
    }
}
