using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// segundo robô!

namespace TemplateMethodPattern
{
    /// <summary>
    /// ConcreteClass
    /// </summary>
    class RoboMicreiro : Robo
    {
        public override void Iniciar()
        {
            Console.WriteLine("Iniciando...");
        }

        public override void PegarMaterial()
        {
            Console.WriteLine("Pegando a placa mãe...");
        }

        public override void Montar()
        {
            Console.WriteLine("Instalando a placa mãe...");
        }

        public override void Testar()
        {
            Console.WriteLine("Revisando os circuitos...");
        }

        public override void Finalizar()
        {
            Console.WriteLine("Finalizando a montagem...");
        }

    }
}
