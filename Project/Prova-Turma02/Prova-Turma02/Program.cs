using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Turma02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PEG peg = new PEG();
            peg.OnMudarFase += new Ocorrencias("Usuário").Atualizar;
            peg.OnMudarFase += new IntegraDepartamentos().Atualizar;

            peg.MudarFase();
            peg.MudarFase();
            peg.MudarFase();
            peg.MudarFase();
            peg.MudarFase();

            Console.ReadKey();

        }
    }
}
