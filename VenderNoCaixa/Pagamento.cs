using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    // superclasse
    public class Pagamento : IMetodoMostrar
    {
        // atributos
        protected DateTime data = DateTime.Now; // mostrar data atual
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
        public Pagamento()
        {
            
        }
        public Pagamento(double total)
        {
            Total = total;
        }
        // métodos
        public virtual void MostrarDados() {
            System.Console.WriteLine($"\nData:  {data} \nTotal: {total:c}");
        }
    }
}