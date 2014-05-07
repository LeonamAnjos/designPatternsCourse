using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            PEG peg = new PEG();
            peg.AoMudarFase += new Integrador().MudouDeFase;

            peg.MudarFase();
            peg.MudarFase();
            peg.MudarFase();


            Console.ReadKey();
        }
    }
}
