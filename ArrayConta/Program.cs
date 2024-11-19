// Método Main()
using ArrayConta;

// declara uma variável como vetor da classe Conta
Conta[] vetContas = new Conta[3]; // int[] vet = new int[3]

// manipular/digitar valores dos atributos dentro e cada índice (i) do vetor
for (int i = 0; i < vetContas.Length; i++) // indice inicia no 0, é menor que o tamanho do vetor vetContas, incremento (+1)
{
    // instancie cada índice do vetor
    vetContas[i] = new Conta();
    // manipular/cadastrar/digitar em cada índice do vetor

    // os atributos
    System.Console.Write("Cadastre o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Cadastre o titular: ");
    vetContas[i].titular = Console.ReadLine();
    System.Console.Write("Cadastre o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}

// apresentar os valores de atributos de cada objeto
foreach (Conta c in vetContas)
{
    c.MostrarAtributos();
}