using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Sockets;
using System.Net;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 9999);

            while (true)
            {
                listener.Start();
                Console.WriteLine("Aguardando .....");
                Socket s = listener.AcceptSocket();

                byte[] b = new byte[100];

                int count = s.Receive(b);

                string input = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    input += Convert.ToChar(b[i]);
                }

                IPrecosAtualizados realSubject = new PrecosAtualizados();
                string returnValue = string.Empty;
                //string message = string.Empty;

                switch (input)
                {
                    case "Laranja":
                        //message = "Preço da laranja";
                        returnValue = realSubject.PrecoLaranja;
                        break;
                    case "Uva":
                        //message = "Preço da uva";
                        returnValue = realSubject.PrecoUva;
                        break;
                    case "Limao":
                        //message = "Preço do limão";
                        returnValue = realSubject.PrecoLimao;
                        break;
                    default:
                        returnValue = "Preco nao encontrado.";
                        break;
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes(returnValue));

                s.Close();
                listener.Stop();
                Console.WriteLine();
                Console.WriteLine("{0}:", input);
                Console.WriteLine("Resposta enviada: {0}", returnValue);
            }
        }
    }
}
