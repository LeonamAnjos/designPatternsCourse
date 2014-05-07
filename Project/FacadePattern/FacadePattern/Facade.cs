using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// Facade class
    /// </summary>
    class Facade
    {
        private SubSistema _subSistema = new SubSistema();

        public void EnviarMensagem(String prioridade, String mensagem)
        {
            _subSistema.Inicializar();
            _subSistema.SetCanalComunicacao("Canal 01");
            _subSistema.SetPrioridade(prioridade);
            _subSistema.EnviarMensagem(mensagem);
            _subSistema.Finalizar();
        }

        public void EnviarMensagemPrioridadeAlta(String mensagem)
        {
            EnviarMensagem("Alta!", mensagem);
        }

    }
}
