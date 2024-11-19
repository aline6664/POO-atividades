// Método Main()
using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Funcionário", 1000);
f.MostrarAtributos();
System.Console.WriteLine($"Valor bonificação: {f.CalcularBonificacao():c}"); // formatação para ficar 0,00

Secretario s = new Secretario(1, "Secretário", 1000);
s.MostrarAtributos();
System.Console.WriteLine($"Valor bonificação: {s.CalcularBonificacao():c}");

Gerente g = new Gerente(1, "Gerente", 1000);
f.MostrarAtributos();
System.Console.WriteLine($"Valor bonificação: {g.CalcularBonificacao():c}");

Diretor d = new Diretor(1, "Diretor", 1000);
d.MostrarAtributos();
System.Console.WriteLine($"Valor bonificação: {d.CalcularBonificacao():c}");
