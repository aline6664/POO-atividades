// Método Main()

using AgregacaoArrayConta;

Cliente cli1 = new Cliente("Ana", 20, "(18)99654-6750");
Cliente cli2 = new Cliente("Bia", 21, "(18)97465-3762");

// Conta Empresarial
Conta c = new Conta();
c.Numero = 1;
c.Saldo = 10000;
c.VetTitulares = new List<Cliente>(); // classe List<generics>
c.VetTitulares.Add(cli1); // adicionar elementos
c.VetTitulares.Add(cli2); // só aceita elementos de VetTitulares

foreach (Cliente ci in c.VetTitulares) // usado em vetores/listas com elementos
//      (classe) (variável qualquer que representa os valores do vetor já existente) in (vetor)
    System.Console.WriteLine("Nome: "+ ci.Nome +"\tIdade: "+ ci.Idade +"\tTelefone: "+ ci.Telefone);
