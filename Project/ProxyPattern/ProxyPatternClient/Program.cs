using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ProxyPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultarSemProxy();
            Console.ReadKey();
        }

        static void ConsultarSemProxy()
        {
            Console.WriteLine("Limão:");
            Console.WriteLine(ConsultarPreco("Limao"));

            Console.WriteLine("Laranja:");
            Console.WriteLine(ConsultarPreco("Laranja"));

            Console.WriteLine("Uva:");
            Console.WriteLine(ConsultarPreco("Uva"));

        }

        static string ConsultarPreco(string input) 
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

        static void ConsultarComProxy()
        {
            IPrecosAtualizados proxy = new PrecosAtualizadosProxy();

            Console.WriteLine("Limão:");
            Console.WriteLine(proxy.PrecoLimao);

            Console.WriteLine("Laranja:");
            Console.WriteLine(proxy.PrecoLaranja);

            Console.WriteLine("Uva:");
            Console.WriteLine(proxy.PrecoUva);
        }





    }
}
