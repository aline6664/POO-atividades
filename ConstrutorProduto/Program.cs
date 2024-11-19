// Método Main

using ConstrutorProduto;

Produto p1 = new Produto();
p1.MostrarAtributos();

Produto p2 = new Produto(001);
p2.MostrarAtributos();

Produto p3 = new Produto(012, "Vassoura");
p3.MostrarAtributos();

Produto p4 = new Produto(037, "Cadeira", 120.00);
p4.MostrarAtributos();

System.Console.WriteLine("Quantidade de instâncias: " + Produto.Cont);