using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    
    /// <summary>
    /// State
    /// </summary>
    public interface IStateLocacao
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="locacao">Contexto</param>
        void receberProposta(NovaLocacao locacao);
        void consultarProposta(NovaLocacao locacao);
        void alugarApartamento(NovaLocacao locacao);
        void entregarChaves(NovaLocacao locacao);
    }

    /// <summary>
    /// ConcreteState
    /// </summary>
    public class AguardandoStateLocacao : IStateLocacao
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="locacao">Contexto</param>
        public void receberProposta(NovaLocacao locacao)
        {
            Console.WriteLine("Recebemos sua proposta. Responderemos em breve. Obrigado! ");
            locacao.Situacao = new PropostaEmEstudoStateLocacao();
        }

        public void consultarProposta(NovaLocacao locacao)
        {
            Console.WriteLine("Estamos recebendo propostas.");
        }

        public void alugarApartamento(NovaLocacao locacao)
        {
            Console.WriteLine("Você precisa nos enviar uma proposta antes.");
        }

        public void entregarChaves(NovaLocacao locacao)
        {
            Console.WriteLine("Você precisa nos enviar uma proposta antes.");
        }

    }

    /// <summary>
    /// ConcreteState
    /// </summary>
    public class LocadoStateLocacao : IStateLocacao
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="locacao">Contexto</param>
        public void receberProposta(NovaLocacao locacao)
        {
            Console.WriteLine("Todos os apartamentos estão alugados.");
        }

        public void consultarProposta(NovaLocacao locacao)
        {
            Console.WriteLine("Todos os apartamentos estão alugados.");
        }

        public void alugarApartamento(NovaLocacao locacao)
        {
            Console.WriteLine("Infelizmente todos os apartamentos estão alugados.");
        }

        public void entregarChaves(NovaLocacao locacao)
        {
            Console.WriteLine("Infelizmente todos os apartamentos estão alugados.");
        }

    }

    /// <summary>
    /// ConcreteState
    /// </summary>
    public class PropostaEmEstudoStateLocacao : IStateLocacao
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="locacao">Contexto</param>
        public void receberProposta(NovaLocacao locacao)
        {
            Console.WriteLine("Nós já recebemos sua propsota. Ela está em estudo.");
        }

        public void consultarProposta(NovaLocacao locacao)
        {
            Random simNao = new Random();
            int resposta = simNao.Next(0, 2);

            if (locacao.NumeroApartamentos <= 0)
            {
                locacao.Situacao = new LocadoStateLocacao();
                Console.WriteLine("Infelizmente todos os apartamentos estão alugados!");
                return;
            }

            if (resposta == 0)
            {
                Console.WriteLine("Parabéns! Sua proposta foi aprovada!");
                locacao.Situacao = new PropostaAceitaStateLocacao();
                locacao.Situacao.alugarApartamento(locacao);
            }
            else
            {
                Console.WriteLine("Infelizmente sua proposta não foi aprovada.");
                locacao.Situacao = new AguardandoStateLocacao();
            }
            
        }

        public void alugarApartamento(NovaLocacao locacao)
        {
            Console.WriteLine("Precisamos antes finalizar a avaliação da sua proposta.");
        }

        public void entregarChaves(NovaLocacao locacao)
        {
            Console.WriteLine("Precisamos antes finalizar a avaliação da sua proposta.");
        }

    }

    /// <summary>
    /// ConcreteState
    /// </summary>
    public class PropostaAceitaStateLocacao : IStateLocacao
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="locacao">Contexto</param>
        public void receberProposta(NovaLocacao locacao)
        {
            Console.WriteLine("A proposta foi acieta e estamos preparando o contrato de locação.");
        }

        public void consultarProposta(NovaLocacao locacao)
        {
            Console.WriteLine("A proposta foi acieta e estamos preparando o contrato de locação.");
        }

        public void alugarApartamento(NovaLocacao locacao)
        {
            Console.WriteLine("Proposta aceita e estamos aluando o apartamento.");
            locacao.NumeroApartamentos--;
            entregarChaves(locacao);
        }

        public void entregarChaves(NovaLocacao locacao)
        {
            Console.WriteLine("Aqui estão as chaves!");
            locacao.Situacao = new AguardandoStateLocacao();
        }

    }

}
