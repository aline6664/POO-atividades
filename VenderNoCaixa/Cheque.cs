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
        private int situacao; // 1 = cheque disponível, 2 = cheque bloqueado
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        // construtores
        public Cheque()
        {
            
        }
        public Cheque(double total, long numero, int situacao) : base(total)
        {
            Numero = numero;
            Situacao = situacao;
        }
        public void ProcessarDadosCheque() {
            if (situacao == 1) {
                CalcularDataDeposito();
            }
            else
             System.Console.WriteLine("Cheque bloqueado. Processo cancelado.");
        }
        public void CalcularDataDeposito() {
            if (total <= 299.99) { // se cheque for valor de ate R$ 299,99, compensado em 1 a 2 dias uteis
                dataDeposito = data.AddDays(2);
            }
            else if (total > 299.99 && total <= 999.99) { // ate R$ 999,99, compensado em 2 a 3 dias uteis
                dataDeposito = data.AddDays(3);
            }
            else { // valores maiores que R$ 999,99 chegam ate 5 dias uteis
                dataDeposito = data.AddDays(5);
            }
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine("Número: "+ numero);
            if (situacao == 1) {
                string dataDepos = dataDeposito.ToString("dd/MM/yyyy"); // formatar para apenas data
                System.Console.WriteLine("Data do Depósito: "+ dataDepos +"\tSituação: disponível");
            }
            else {
                System.Console.WriteLine("Situação: bloqueado");
            }
            
        }
    }
}