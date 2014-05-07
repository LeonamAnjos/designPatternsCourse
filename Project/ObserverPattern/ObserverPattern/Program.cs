using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            db.registerObserver(new Log());
            db.registerObserver(new Audit());

            db.editRecord("INSERT", "RECORD 1");
            Console.WriteLine();

            db.editRecord("UPDATE", "RECORD 1");
            Console.WriteLine();

            db.editRecord("DELETE", "RECORD 1");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
