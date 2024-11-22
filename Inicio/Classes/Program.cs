// Função Main()
// Esse arquivo Program.cs chama as funções
using System.Collections.Concurrent;
using System.Security.Cryptography;
using Classes; // chama a pasta Classes e autoriza usar os arquivos dela

// tipo e nome do objeto - criação de um objeto, declaração da variável objetoConta
Conta objetoConta;
//            aloca a memória e chama o construtor da classe - instância de objeto
objetoConta = new Conta();
// Pode ser feito como -> Conta objetoConta = new.Conta()
// Prepara a variável para a utilização (atribuir, digitar, alterar atributos etc)

objetoConta.numero = 1; // variável.atributo
objetoConta.titular = "John";
objetoConta.saldo = 100;
objetoConta.MostrarAtributos();
objetoConta.Depositar(50);
objetoConta.MostrarAtributos();
Console.WriteLine($"Valor descontado do IOF: {objetoConta.CalcularIOF(4.38):c}");
objetoConta.MostrarAtributos();
// formatação de currency do que for retornado da função CalcularIOF (em R$ para nós)

/*
objetoConta.MostrarAtributos(); ---> enviado para o Conta.cs
/*System.Console.WriteLine("Número: " + objetoConta.numero +
 "\tTitular: " + objetoConta.titular +
  "\tSaldo: R$ " + objetoConta.saldo);
*/

/*
// com input do usuário
Conta c1 = new Conta(); // no debug -> prepara a variável e zera todos os atributos prévios
System.Console.Write("Digite o número da conta: ");
  c1.numero = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite o titular: ");
  c1.titular = Console.ReadLine();
System.Console.Write("Digite o valor do saldo: ");
  c1.saldo = Convert.ToDouble(Console.ReadLine());

c1.MostrarAtributos();
/*System.Console.WriteLine("Número: " + c1.numero + 
"\tTitular: " + c1.titular + 
"\tSaldo: R$ " + c1.saldo);
*/

Conta c3 = new Conta();
  c3.numero = 3; 
  c3.titular = "Joe";
  c3.saldo = 300;
  c3.MostrarAtributos();
  c3.Sacar(10);
  c3.MostrarAtributos();

Conta c4 = new Conta();
  c4.numero = 4; 
  c4.titular = "Jasper";
  c4.saldo = 400;
  c4.MostrarAtributos();
  System.Console.WriteLine("Valor descontado: "+ c4.CalcularIOF(4.37));// -> valor do IOF atual
  c4.MostrarAtributos();

// realizando a transferencia das contas c3 e c4
c3.Transferencia(50,c4); // Joe faz a transferencia de 50 reais para Jasper
c3.MostrarAtributos();
c4.MostrarAtributos();