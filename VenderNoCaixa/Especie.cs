using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Especie : Pagamento
    {
        private double quantia;
        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        private double troco;
        public double Troco
        {
            get { return troco; }
            set { troco = value; }
        }
        // métodos
        public double CalcularTroco(double quantia)
        {
            troco = quantia - base.total;
            return troco;
        }
        public override void MostrarDadosPagamento()
        {
            base.MostrarDadosPagamento();
            System.Console.WriteLine("Quantia fornecida: "+ quantia +"\t\tTroco: "+ troco +"\n");
        }
    }
}