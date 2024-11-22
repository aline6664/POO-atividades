// Metodo Main()

using LSPPagamento;

// Instancia do pagamento
// Pagamento pg = new Pagamento(500);

// Cartão de Crédito
System.Console.WriteLine("\nCARTÃO DE CREDITO");
CartaoCredito cc = new CartaoCredito(600, "Cartão de Crédito 0001");
cc.ProcessarPagamento(cc.Valor);

// Paypal
System.Console.WriteLine("\nPAYPAL");
Paypal pp = new Paypal(700, "Conta Paypal 001");
pp.ProcessarPagamento(pp.Valor);

// Espécie
System.Console.WriteLine("\nEM ESPÉCIE");
Especie e = new Especie(800,1000);
e.ProcessarPagamento(e.Valor);
