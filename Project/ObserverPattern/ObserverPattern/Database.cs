using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// primeira classe

namespace ObserverPattern
{
    /// <summary>
    /// ConcreteSubject
    /// </summary>
    public class Database : ISubject
    {
        private String _operation;
        private String _record;

        public void editRecord(String operation, String record)
        {
            this._operation = operation;
            this._record = record;
            Console.WriteLine(_operation + "(" + _record + ");");

            //(new Log()).update(_operation, _record);
            //(new Audit()).update(_operation, _record);

            notifyObservers();
        }

        private List<IObserver> _observers = new List<IObserver>();
        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserer(IObserver o)
        {
            _observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.update(_operation, _record);
            }
        }


    }
}