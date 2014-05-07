using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// AbstractClass
    /// </summary>
    abstract class Robo
    {
        /// <summary>
        /// Template Method
        /// </summary>
        public void Executar()
        {
            Iniciar();
            PegarMaterial();
            Montar();
            
            if (PodeTestar())
            {
                Testar();
            }
            
            Finalizar();
        }

        public abstract void Iniciar();
        public abstract void PegarMaterial();
        public abstract void Montar();
        public abstract void Testar();
        public abstract void Finalizar();

        /// <summary>
        /// Hook
        /// </summary>
        /// <returns>Retorna true</returns>
        public virtual bool PodeTestar()
        {
            return true;
        }

    }


}
