using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// ConcreteClass
    /// </summary>
    class RoboChapeiro : Robo
    {

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando...");
        }

        public override void PegarMaterial()
        {
            Console.WriteLine("Pegando ingredientes...");
        }

        public override void Montar()
        {
            Console.WriteLine("Montando o lanche...");
        }

        public override void Testar()
        {
            Console.WriteLine("Dando uma mordida...");
        }

        public override void Finalizar()
        {
            Console.WriteLine("Embalando o lanche...");
        }

        public override bool PodeTestar()
        {
            return false;
        }
    }
}
