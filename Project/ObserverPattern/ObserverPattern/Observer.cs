using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Subject
    /// </summary>
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserer(IObserver o);
        void notifyObservers();
    }
    
    /// <summary>
    /// Observer
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Update()
        /// </summary>
        /// <param name="operation">Operação executada</param>
        /// <param name="record">Registro afetado</param>
        void update(String operation, String record);

    }

}
