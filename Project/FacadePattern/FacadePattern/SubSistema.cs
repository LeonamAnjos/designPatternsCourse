using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// Subsystem classes
    /// </summary>
    class SubSistema
    {
        public void Inicializar()
        {
            Console.WriteLine("SubSistema - Inicializar");
        }

        public void SetCanalComunicacao(String canal)
        {
            Console.WriteLine("SubSistema - SetCanalComunicacao({0})", canal);
        }

        public void SetPrioridade(String prioridade)
        {
            Console.WriteLine("SubSistema - SetPrioridade({0})", prioridade);
        }

        public void EnviarMensagem(String mensagem)
        {
            Console.WriteLine("SubSistema - EnviarMensagem({0})", mensagem);
        }

        public void Finalizar()
        {
            Console.WriteLine("SubSistema - Finalizar");
        }
    }
}
