using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    class ActualPricesProxy : IActualPrices
    {
        public string GoldPrice
        {
            get
            {
                return GetResponseFromServer("g");
            }
        }

        public string SilverPrice
        {
            get
            {
                return GetResponseFromServer("s");
            }
        }

        public string DollarToRupee
        {
            get
            {
                return GetResponseFromServer("d");
            }
        }

        private string GetResponseFromServer(string input)
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
