using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// Subject
    /// </summary>
    interface IPrecosAtualizados
    {
        /// <summary>
        /// Request()
        /// </summary>
        string PrecoLaranja
        {
            get;
        }

        /// <summary>
        /// Request()
        /// </summary>
        string PrecoUva
        {
            get;
        }

        /// <summary>
        /// Request()
        /// </summary>
        string PrecoLimao
        {
            get;
        }
    }


    /// <summary>
    /// RealSubject
    /// </summary>
    class PrecosAtualizados : IPrecosAtualizados
    {
        /// <summary>
        /// Request()
        /// </summary>
        public string PrecoLaranja
        {
            get
            {
                return "0.90";
            }
        }

        /// <summary>
        /// Request()
        /// </summary>
        public string PrecoUva
        {
            get
            {
                return "5.50";
            }
        }

        /// <summary>
        /// Request()
        /// </summary>
        public string PrecoLimao
        {
            get
            {
                return "2.35";
            }
        }
    }
}
