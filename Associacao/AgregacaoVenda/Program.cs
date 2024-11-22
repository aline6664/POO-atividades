// Método Main()

using AgregacaoVenda;

// Valor de verba do comprador
Comprador comp1 = new Comprador(500);

Produto prod1 = new Produto(1,"Vassoura", 15); // teste

//  Produtos
Produto prod2 = new Produto();
System.Console.Write("Cadastre o código: ");
prod1.Codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Cadastre o nome do produto: ");
prod1.Nome = Console.ReadLine();
System.Console.Write("Cadastre o preço do produto: ");
prod1.Preco = Convert.ToDouble(Console.ReadLine());

Produto prod3 = new Produto();
System.Console.Write("Cadastre o código: ");
prod2.Codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Cadastre o nome do produto: ");
prod2.Nome = Console.ReadLine();
System.Console.Write("Cadastre o preço do produto: ");
prod2.Preco = Convert.ToDouble(Console.ReadLine());

// Comissao do vendedor
Vendedor vend1 = new Vendedor();

// --------------------------------------------------

// NOVA VENDA
Venda vnd = new Venda();
// Adicionar comprador
vnd.Comp = comp1;
// Adicionar vendedor
vnd.Vend = vend1;
// Adicionar produtos
vnd.VetProd = new List<Produto>();
vnd.VetProd.Add(prod1);
vnd.VetProd.Add(prod2);
vnd.VetProd.Add(prod3);

System.Console.WriteLine("--- DADOS DA VENDA ---");
// vnd.MostrarAtributos();

// comprador
System.Console.WriteLine("--- COMPRADOR ---");
comp1.MostrarAtributo();
comp1.CalculoVerba(Produto.Valor_total);

// produtos e comissão do vendedor
System.Console.WriteLine("--- PRODUTOS E COMISSÃO ---");
prod1.MostrarAtributos();
vend1.CalculoComissao(prod1.Preco);
vend1.MostrarAtributo();

prod2.MostrarAtributos();
vend1.CalculoComissao(prod2.Preco);
vend1.MostrarAtributo();

prod3.MostrarAtributos();
vend1.CalculoComissao(prod3.Preco);
vend1.MostrarAtributo();

// valor total da venda
System.Console.WriteLine("--- TOTAL ---");
System.Console.WriteLine("Valor total: " + Produto.Valor_total);