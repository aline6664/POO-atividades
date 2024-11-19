using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSPPagamento
{
    public class Especie : Pagamento, IPagamento
    {
        public decimal Quantia { get; set; }
        public decimal Troco { get; set; }
        public Especie()
        {
            
        }
        public Especie(decimal valor, decimal quantia) : base(valor)
        {
            Quantia = quantia;
        }
        public void ProcessarPagamento(decimal valor)
        {
            decimal resto = CalcularTroco(Quantia, valor);
            if (resto == 0)
            {
                System.Console.WriteLine("Quantia insuficiente.");
            }
            System.Console.WriteLine($"Processado pagamento de valor de {valor:c} em espécie.");
        }      
        public decimal CalcularTroco(decimal quantia, decimal valor)
        {
            if (quantia >= valor)
            {
                decimal troco = quantia - valor;
                Troco = troco;
                return troco;
            }
            else {
                return 0; // define troco negativo, quantia recebida é menor que valor a pagar
            }
        } 
    }
}