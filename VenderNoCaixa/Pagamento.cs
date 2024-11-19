using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    // superclasse
    public class Pagamento
    {
        // atributos
        protected DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        protected double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        // métodos
        public virtual void MostrarDadosPagamento() {
            System.Console.WriteLine("Data: "+ data +"\nTotal: "+ total);
        }
    }
}