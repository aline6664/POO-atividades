using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao;
        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        private int resultadoTransacao;
        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }
        // construtores
        public Cartao()
        {
            
        }
        public Cartao(string dadosTransacao, int resultadoTransacao)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
        // métodos
        public override void MostrarDadosPagamento()
        {
            base.MostrarDadosPagamento();
            System.Console.WriteLine("Dados da Transação: \n"+ dadosTransacao +"\nResultado da Transação: "+ resultadoTransacao +"\n");
        }
    }
}