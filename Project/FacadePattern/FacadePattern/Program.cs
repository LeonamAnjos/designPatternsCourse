using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- SEM Facade --");
            
            SubSistema s = new SubSistema();

            s.Inicializar();
            s.SetCanalComunicacao("Canal 01");
            s.SetPrioridade("Alta!");
            s.EnviarMensagem("Hello World!");
            s.Finalizar();

            Console.WriteLine();
            Console.WriteLine("-- COM Facade --");

            Facade f = new Facade();

            f.EnviarMensagem("Alta!", "Hello World!");

            Console.WriteLine();

            f.EnviarMensagemPrioridadeAlta("Hello World!");


            Console.ReadKey();
        }
    }
}
