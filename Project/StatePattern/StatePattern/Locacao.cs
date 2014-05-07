using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// primeira classe

namespace StatePattern
{
    /// <summary>
    /// Estatods de Locação
    /// </summary>
    public enum SituacaoLocacao
    {
        LOCADO = 0, AGUARDANDO = 1, PROPOSTA_EM_ESTUDO = 2, PROPOSTA_ACEITA = 3
    }

    /// <summary>
    /// Context
    /// </summary>
    public class Locacao
    {
        private SituacaoLocacao situacao = SituacaoLocacao.AGUARDANDO;

        private int _numeroApartamentos = 0;
        public int NumeroApartamentos
        {
            get
            {
                return _numeroApartamentos;
            }
            set
            {
                if (this._numeroApartamentos != value)
                {
                    _numeroApartamentos = value;
                }
            }
        }


        public Locacao(int apartamentos)
        {
            NumeroApartamentos = apartamentos;
        }

        /// <summary>
        /// Get an application
        /// </summary>
        public void receberProposta()
        {
            switch (situacao)
            {
                case SituacaoLocacao.LOCADO:
                    Console.WriteLine("Todos os apartamentos estão alugados.");
                    break;
                case SituacaoLocacao.AGUARDANDO:
                    situacao = SituacaoLocacao.PROPOSTA_EM_ESTUDO;
                    Console.WriteLine("Recebemos sua proposta. Responderemos em breve. Obrigado! ");
                    break;
                case SituacaoLocacao.PROPOSTA_EM_ESTUDO:
                    Console.WriteLine("Nós já recebemos sua propsota. Ela está em estudo.");
                    break;
                case SituacaoLocacao.PROPOSTA_ACEITA:
                    Console.WriteLine("A proposta foi acieta e estamos preparando o contrato de locação.");
                    break;

            }
        }

        /// <summary>
        /// Check de application
        /// </summary>
        public void consultarProposta()
        {
            Random simNao = new Random();
            int resposta = simNao.Next(0, 2);

            switch (situacao)
            {
                case SituacaoLocacao.LOCADO:
                    Console.WriteLine("Todos os apartamentos estão alugados.");
                    break;
                case SituacaoLocacao.AGUARDANDO:
                    Console.WriteLine("Estamos recebendo propostas.");
                    break;
                case SituacaoLocacao.PROPOSTA_EM_ESTUDO:
                    if (NumeroApartamentos <= 0)
                    {
                        situacao = SituacaoLocacao.LOCADO;
                        Console.WriteLine("Infelizmente todos os apartamentos estão alugados!");
                        break;
                    }

                    if (resposta == 0)
                    {
                        Console.WriteLine("Parabéns! Sua proposta foi aprovada!");
                        situacao = SituacaoLocacao.PROPOSTA_ACEITA;
                        alugarApartamento();
                    }
                    else
                    {
                        Console.WriteLine("Infelizmente sua proposta não foi aprovada.");
                        situacao = SituacaoLocacao.AGUARDANDO;
                    }
                    break;
                case SituacaoLocacao.PROPOSTA_ACEITA:
                    Console.WriteLine("A proposta foi acieta e estamos preparando o contrato de locação.");
                    break;
            }
        }

        /// <summary>
        /// Accepted - rent an apartment
        /// </summary>
        public void alugarApartamento()
        {
            switch (situacao)
            {
                case SituacaoLocacao.LOCADO:
                    Console.WriteLine("Infelizmente todos os apartamentos estão alugados.");
                    break;
                case SituacaoLocacao.AGUARDANDO:
                    Console.WriteLine("Você precisa nos enviar uma proposta antes.");
                    break;
                case SituacaoLocacao.PROPOSTA_EM_ESTUDO:
                    Console.WriteLine("Precisamos antes finalizar a avaliação da sua proposta.");
                    break;
                case SituacaoLocacao.PROPOSTA_ACEITA:
                    Console.WriteLine("Proposta aceita e estamos aluando o apartamento.");
                    NumeroApartamentos--;
                    entregarChaves();
                    break;

            }
        }

        /// <summary>
        /// Dispense keys
        /// </summary>
        private void entregarChaves()
        {
            switch (situacao)
            {
                case SituacaoLocacao.LOCADO:
                    Console.WriteLine("Infelizmente todos os apartamentos estão alugados.");
                    break;
                case SituacaoLocacao.AGUARDANDO:
                    Console.WriteLine("Você precisa nos enviar uma proposta antes.");
                    break;
                case SituacaoLocacao.PROPOSTA_EM_ESTUDO:
                    Console.WriteLine("Precisamos antes finalizar a avaliação da sua proposta.");
                    break;
                case SituacaoLocacao.PROPOSTA_ACEITA:
                    Console.WriteLine("Aqui estão as chaves!");
                    situacao = SituacaoLocacao.AGUARDANDO;
                    break;

            }
        }

    }
}
