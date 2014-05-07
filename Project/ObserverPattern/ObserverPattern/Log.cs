using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// ConcreteObserver
    /// </summary>
    public class Log : IObserver
    {
        /// <summary>
        /// Update()
        /// </summary>
        /// <param name="operation">Operação executada</param>
        /// <param name="record">Registro afetado</param>
        public void update(String operation, String record)
        {
            Console.WriteLine("Registrando no log: Operação " + operation + " no registro " + record + " foi executada!");
        }
    }
}
