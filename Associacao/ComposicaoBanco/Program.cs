// Método Main()

using ComposicaoBanco;

// Poupança
Poupanca p1 = new Poupanca(500); // parametro -> saldo
ContaCorrente c1 = new ContaCorrente(1000); // parametro -> saldo

// realizando instância de Banco junto com Poupanca
Banco bnc = new Banco();
bnc.Poups.Add(p1);
bnc.Contas.Add(c1);

int op = 0;
while (op != 5)
    {
        if (op == 1)
        {
            System.Console.WriteLine("Poupança");
        }
    }


foreach (Poupanca p in bnc.Poups)
    System.Console.WriteLine("Poupança atual: "+ p.Saldo);

foreach (ContaCorrente c in bnc.Contas)
    System.Console.WriteLine("Conta Corrente atual: "+ c.Saldo);