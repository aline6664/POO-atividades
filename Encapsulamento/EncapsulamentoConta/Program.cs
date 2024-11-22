// Método Main

using EncapsulamentoConta;

Conta c1 = new Conta();
// Modelo Java ou PHP
// c1.setNumero(1); // c1.numero = 1
// (ERRADO) System.Console.WriteLine("Número: "+c1.numero); --- ainda daria erro
// System.Console.WriteLine("Número:"+ c1.getNumero());

c1.Numero = 1; // set (atribuição) --- o sinal de atribuição (=) ativa o set
System.Console.WriteLine("Número: "+ c1.Numero); // get (busca) --- não há sinal de atribuição mas c1.Numero está sendo chamado