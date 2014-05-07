using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// primeiro robô!

namespace TemplateMethodPattern
{

    /// <summary>
    /// ConcreteClass
    /// </summary>
    class RoboAutomotivo : Robo
    {

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando...");
        }

        public override void PegarMaterial()
        {
            Console.WriteLine("Pegando o motor...");
        }

        public override void Montar()
        {
            Console.WriteLine("Instalando o motor...");
        }

        public override void Testar()
        {
            Console.WriteLine("Revisando o motor...");
        }

        public override void Finalizar()
        {
            Console.WriteLine("Finalizando a montagem...");
        }

        
    }
}
