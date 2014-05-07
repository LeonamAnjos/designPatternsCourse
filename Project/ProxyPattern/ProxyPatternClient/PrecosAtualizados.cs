using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ProxyPatternClient
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

        string PrecoUva
        {
            get;
        }

        string PrecoLimao
        {
            get;
        }
    }


    /// <summary>
    /// Proxy
    /// </summary>
    class PrecosAtualizadosProxy : IPrecosAtualizados
    {
        /// <summary>
        /// Request()
        /// </summary>
        public string PrecoLaranja
        {
            get
            {
                return ConsultarPreco("Laranja");
            }
        }

        /// <summary>
        /// Request()
        /// </summary>
        public string PrecoUva
        {
            get
            {
                return ConsultarPreco("Uva");
            }
        }

        /// <summary>
        /// Request()
        /// </summary>
        public string PrecoLimao
        {
            get
            {
                return ConsultarPreco("Limao");
            }
        }

        private string ConsultarPreco(string input)
        {
            string result = string.Empty;
            using (TcpClient client = new TcpClient())
            {
                client.Connect("127.0.0.1", 9999);

                Stream stream = client.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(input.ToCharArray());

                stream.Write(ba, 0, ba.Length);

                byte[] br = new byte[100];
                int k = stream.Read(br, 0, 100);



                for (int i = 0; i < k; i++)
                {
                    result += Convert.ToChar(br[i]);
                }

                client.Close();
            }

            return result;
        }

    }
}
