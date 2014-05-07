using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Turma02
{
    public class Ocorrencias
    {
        private String usuario;

        public Ocorrencias(String usuario)
        {
            this.usuario = usuario;
        }

        public void Atualizar(OcorrenciaFase ocorrencia) 
        {
            
            Console.WriteLine("----- OCORRENCIA ----- ");
            Console.WriteLine("Usuario: {0}", usuario);
            Console.WriteLine("Data/Hora: {0}", DateTime.Now);
            Console.WriteLine("Situação anterior: {0}", ocorrencia.SituacaoAnterior);
            Console.WriteLine("Situação atual: {0}", ocorrencia.SituacaoAtual);
            Console.WriteLine("");
        }



    }
}
