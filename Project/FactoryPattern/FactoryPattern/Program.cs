using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection c;
            
            String type = "Oracle";

            #region FactoryMethodPattern
            c = new ConnectionFactory(type).createConnection();
            #endregion

            #region noPattern
            //if (type.Equals("Oracle"))
            //{
            //    c = new OracleConnection();
            //}
            //else if (type.Equals("SQL Server"))
            //{
            //    c = new SQLServerConnection();
            //}
            //else
            //{
            //    c = new MySQLConnection();
            //}
            #endregion

            Console.WriteLine(c.description());
            Console.ReadKey();
        }
    }
}
