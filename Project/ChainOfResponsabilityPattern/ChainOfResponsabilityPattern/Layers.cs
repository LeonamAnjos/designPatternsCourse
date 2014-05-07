using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// começar aqui!

namespace ChainOfResponsabilityPattern
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class Application : IHelp
    {
        /// <summary>
        /// HandleRquest()
        /// </summary>
        /// <param name="request">Requisição</param>
        public void getHelp(int request)
        {
            Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
        }
    }

    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class IntermediateLayer : IHelp
    {
        IHelp successor;

        public IntermediateLayer(IHelp s)
        {
            successor = s;
        }

        /// <summary>
        /// HandleRquest()
        /// </summary>
        /// <param name="request">Requisição</param>
        public void getHelp(int request)
        {
            if((request >= 10) && (request < 20)) 
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.getHelp(request);
            }
        }
    }

    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class FrontEnd : IHelp
    {
        IHelp successor;

        public FrontEnd(IHelp s)
        {
            successor = s;
        }

        /// <summary>
        /// HandleRquest()
        /// </summary>
        /// <param name="request">Requisição</param>
        public void getHelp(int request)
        {
            if ((request >= 0) && (request < 10))
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.getHelp(request);
            }
        }
    }
}
