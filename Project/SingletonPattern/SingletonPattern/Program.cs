using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Processo01();
            Processo02();
            Processo03();
            Console.ReadKey();
        }

        static void Processo01()
        {
            //Database db = new Database("SingletonDB");
            Database db = Database.getInstance("SingletonDB");
            Console.WriteLine(db.editRecord("OPERAÇÃO PROCESSO_01"));
            Console.WriteLine(db.editRecord("OPERAÇÃO PROCESSO_01"));
        }

        static void Processo02()
        {
            //Database db = new Database("SingletonDB");
            Database db = Database.getInstance("SingletonDB");
            Console.WriteLine(db.editRecord("OPERAÇÃO PROCESSO_02"));
            Console.WriteLine(db.editRecord("OPERAÇÃO PROCESSO_02"));

        }

        static void Processo03()
        {
            //Database db = new Database("SingletonDB");
            Database db = Database.getInstance("SingletonDB");
            Console.WriteLine(db.editRecord("OPERAÇÃO PROCESSO_03"));
            Console.WriteLine(db.editRecord("OPERAÇÃO PROCESSO_03"));

        }
    }
}
