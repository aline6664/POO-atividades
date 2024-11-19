using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cheque : Pagamento
    {
        private long numero;
        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private DateTime dataDeposito;
        public DateTime DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }
        private int situacao;
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        // construtores
        public Cheque()
        {
            
        }
        public Cheque(long numero)
        {
            Numero = numero;
        }
        public bool VerificarSituacao(int situacao)
        {
            // 1 = cheque disponível, 2 = cheque bloqueado
            if (situacao == 1) {
                return true;
            }
            else {
                return false;
            }
        }
        public override void MostrarDadosPagamento()
        {
            base.MostrarDadosPagamento();
            System.Console.WriteLine("Data do Depósito: "+ dataDeposito +"\t\tSituação: "+ situacao +"\n");
        }
    }
}