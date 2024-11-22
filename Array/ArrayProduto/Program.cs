// Método Main()
using ArrayProduto;

// Criar a classe Produto(codigo,nome,preco,qtde) - ok

// Declarar uma variável vetorProdutos[3]; - ok
Produto[] vetProdutos = new Produto[3];
double total = 0;

// Cadastrar estes produtos - ok
for (int i = 0; i < vetProdutos.Length; i++)
{
    vetProdutos[i] = new Produto();

    System.Console.Write("Cadastre o código: ");
    vetProdutos[i].codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Cadastre o nome do produto: ");
    vetProdutos[i].nome = Console.ReadLine();
    System.Console.Write("Cadastre o preço do produto: ");
    vetProdutos[i].preco = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Cadastre a quantidade: ");
    vetProdutos[i].qtde = Convert.ToInt32(Console.ReadLine());

    // Calcular o valor total (soma) dos preços, lembrando de multiplicar
    // a quantidade pelo preço antes e apresentar - ok

    total += vetProdutos[i].preco * vetProdutos[i].qtde;
}
System.Console.WriteLine($"Valor total {total:c}");

// Criar o método MostrarAtributos() dentro da classe Produto, resto na Main - ok
foreach (Produto p in vetProdutos) // classe variável in vetor
{
    p.MostrarAtributos();
}

