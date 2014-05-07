using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Server
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
                Console.WriteLine("Waiting .....");
                Socket s = listener.AcceptSocket();

                byte[] b = new byte[100];

                int count = s.Receive(b);

                string input = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    input += Convert.ToChar(b[i]);
                }

                IActualPrices realSubject = new ActualPrices();
                string returnValue = string.Empty;
                string message = string.Empty;

                switch (input)
                {
                    case "g":
                        message = "Gold Prices";
                        returnValue = realSubject.GoldPrice;
                        break;
                    case "s":
                        message = "Silver Price";
                        returnValue = realSubject.SilverPrice;
                        break;
                    case "d":
                        message = "Dollar To Rupee Prices";
                        returnValue = realSubject.DollarToRupee;
                        break;
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes(returnValue));

                s.Close();
                listener.Stop();
                Console.WriteLine("Response for ({0}) Sent .....", message);
            }
        }
    }
}
