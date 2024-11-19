using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSPPagamento
{
    public class Paypal : Pagamento, IPagamento
    {
        public string IdContaPaypal { get; set; }
        public Paypal()
        {
            
        }
        public Paypal(decimal valor, string idcontapaypal) : base(valor)
        {
            IdContaPaypal = idcontapaypal;
        }
        public void ProcessarPagamento(decimal valor)
        {
            System.Console.WriteLine($"Processado pagamento de valor de {valor:c} da conta: {IdContaPaypal}");
        }
        public void ValidarDetalhesPagamento(string idConta, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(idConta))
                System.Console.WriteLine("ID da conta de Paypal é requerido.");
            if (valor <= 0)
                System.Console.WriteLine("Valor deve ser maior que zero.");
        }
    }
}