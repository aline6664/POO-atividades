using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSPPagamento
{
    public class CartaoCredito : Pagamento, IPagamento
    {
        public string IdCartao { get; set; }
        public CartaoCredito()
        {
            
        }
        public CartaoCredito(decimal valor, string idcartao) : base(valor)
        {
            IdCartao = idcartao;
        }
        public void ProcessarPagamento(decimal valor)
        {
            ValidarDetalhesPagamento(IdCartao, valor);
            System.Console.WriteLine($"Processado pagamento de valor de {valor:c} do cartão: {IdCartao}");
        }
        public void ValidarDetalhesPagamento(string idcartao, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(idcartao))
                System.Console.WriteLine("ID do cartão de crédito é requerido.");
            if (valor <= 0)
                System.Console.WriteLine("Valor deve ser maior que zero.");
        }
    }
}