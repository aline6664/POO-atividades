// Método Main()

using AbstratoFuncionario;

// Instância de funcionários
Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bel", 1000);

Comissionado c1 = new Comissionado(3, "Bia", 1000, 0.20); // 20% de comissão
Comissionado c2 = new Comissionado(4, "Leo", 1000, 0.30);

// InstâNcia de departamentos
Departamento d1 = new Departamento(10, "DEV");
d1.VetFunc = new List<Funcionario>(); // instância do vetor, para inserir os funcionários ao departamento
d1.AdmitirFuncionarios(a1); // método que insere ao vetor, individualmente
d1.AdmitirFuncionarios(c1);
d1.ListarFuncionarios();
System.Console.WriteLine($"Total da Folha de Pagamento: {d1.CalcularFolhaPagamento(30):c}"); // geração de folha dentro de 30 dias úteis

Departamento d2 = new Departamento(11, "REDES");
d2.VetFunc = new List<Funcionario>();
d2.AdmitirFuncionarios(a2);
d2.AdmitirFuncionarios(c2);
d2.ListarFuncionarios();
System.Console.WriteLine($"Total da Folha de Pagamento: {d2.CalcularFolhaPagamento(30):c}");
// d2.DemitirFuncionarios(2); // remover o funcionário de código 2 (Bel)
// d2.ListarFuncionarios(); // checar a remoção

// Instância de dependentes
Dependente dep1 = new Dependente(101, "Mario", 12);
Dependente dep2 = new Dependente(102, "Pedro", 19);
Dependente dep3 = new Dependente(103, "Joana", 5);
Dependente dep4 = new Dependente(104, "Maria", 8);

// Inserir os dependentes aos funcionários
a1.VetDep = new List<Dependente>();
a1.AdicionarDependente(dep1); // Funcionário a1 (Ana) recebe o filho dep1 (Mario)
a1.AdicionarDependente(dep2);
// a2.AdicionarDependente(dep3);
// c1.AdicionarDependente(dep4);

d1.MostrarQtdeDependentesFuncionario(a1);