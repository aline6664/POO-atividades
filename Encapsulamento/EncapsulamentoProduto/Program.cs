// Método Main

using EncapsulamentoProduto;

Produto p1 = new Produto();

    // os atributos
    System.Console.Write("Cadastre o código: ");
    p1.Codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Cadastre o nome: ");
    p1.Nome = Console.ReadLine();
    System.Console.Write("Cadastre o preço: ");
    p1.Preco = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Cadastre a quantidade: ");
    p1.Qtde = Convert.ToInt32(Console.ReadLine());

p1.MostrarAtributos();