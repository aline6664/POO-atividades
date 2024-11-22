using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSPPagamento
{
    public class Pagamento
    {
        public decimal Valor { get; set; }
        public Pagamento()
        {
            
        }
        public Pagamento(decimal valor)
        {
            Valor = valor;
        }
    }
}