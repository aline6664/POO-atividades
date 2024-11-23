using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
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
        // construtor
        public Especie()
        {
            
        }
        public Especie(double total) : base(total)
        {
            
        }
        // métodos
        public double CalcularTroco(double quantia)
        {
            if (quantia >= total) {
                troco = quantia - Total;
                return troco;
            }
            else {
                return -1; // caso troco seja negativo (quantia menor que valor total)
            }
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine($"Quantia fornecida: {quantia:c} \t\tTroco: {troco:c} \n");
        }
    }
}