using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsabilityPattern
{
    /// <summary>
    /// Handler
    /// </summary>
    public interface IHelp
    {
        /// <summary>
        /// HandleRquest()
        /// </summary>
        /// <param name="request">Requisição</param>
        void getHelp(int request);
    }
}
