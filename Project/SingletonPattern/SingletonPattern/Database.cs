using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Database
    {
        private int record;
        private String name;

        //public Database(String n)
        private Database(String n)
        {
            name = n;
            record = 0;
        }

        public String editRecord(String operation)
        {
            return "Executada a operação " + operation + " no registro " + record++ + " no banco " + name + ".";
        }

        /// <summary>
        /// instance : Singleton
        /// </summary>
        private static Database singleObject;

        // Lock synchronization object
        private static object syncLock = new object();


        /// <summary>
        /// Instance() : Singleton
        /// </summary>
        /// <param name="n">Nome do banco de dados</param>
        /// <returns>Instância do banco de dados</returns>
        public static Database getInstance(String n)
        {
            if (singleObject == null)
                lock (syncLock)
                {
                    if (singleObject == null)
                        singleObject = new Database(n);
                }
               

            return singleObject;
        }
    }
}
