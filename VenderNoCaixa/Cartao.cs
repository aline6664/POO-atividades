using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao; // dados do cartão, autorização
        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        private int resultadoTransacao; // aprovado ou não (?)
        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }
        // construtores
        public Cartao()
        {
            
        }
        public Cartao(double total, string dadosTransacao) : base(total)
        {
            DadosTransacao = dadosTransacao;
        }
        // métodos
        public void ProcessarDadosTransacao(double valor)
        {
            resultadoTransacao = ValidarTransacao(dadosTransacao, valor);
            if (resultadoTransacao == 1) 
                System.Console.WriteLine($"Processado pagamento de valor de {total:c}.");
            else
                System.Console.WriteLine("Transação cancelada.");
        }
        public int ValidarTransacao(string dadosTransacao, double valor)
        {
            if (string.IsNullOrWhiteSpace(dadosTransacao)) {
                System.Console.WriteLine("Dados da transação são requeridos.");
                return 0;
                }
            if (valor <= 0) {
                System.Console.WriteLine("Valor deve ser maior que zero.");
                return 0;
                }
            if (valor < total) {
                System.Console.WriteLine("Valor insuficiente.");
                return 0;
            }
            return 1;
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine("Dados da Transação: \n"+ dadosTransacao);
            if (resultadoTransacao == 1)
                System.Console.WriteLine("Resultado da Transação: aprovado\n");
            else {
                System.Console.WriteLine("Resultado da Transação: cancelado\n");
            }
        }
    }
}