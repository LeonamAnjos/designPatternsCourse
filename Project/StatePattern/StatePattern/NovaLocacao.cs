using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{

    /// <summary>
    /// Context
    /// </summary>
    public class NovaLocacao
    {
        /// <summary>
        /// State
        /// </summary>
        private IStateLocacao _situacao;
        public IStateLocacao Situacao 
        {
            get
            {
                return _situacao;
            }
            set
            {
                _situacao = value;
            }
        }
        
        private int _numeroApartamentos = 0;
        public int NumeroApartamentos 
        {
            get
            {
                return _numeroApartamentos;
            }
            set
            {
                if (this._numeroApartamentos != value) 
                {
                    _numeroApartamentos = value;
                }
            }
        }

        public NovaLocacao(int apartamentos)
        {
            this.NumeroApartamentos = apartamentos;
            this.Situacao = new AguardandoStateLocacao();
        }

        public void receberProposta()
        {
            Situacao.receberProposta(this);
        }

        public void consultarProposta()
        {
            Situacao.consultarProposta(this);
        }

        public void alugarApartamento()
        {
            Situacao.alugarApartamento(this);
        }

        private void entregarChaves()
        {
            Situacao.entregarChaves(this);
        }


    }
}
