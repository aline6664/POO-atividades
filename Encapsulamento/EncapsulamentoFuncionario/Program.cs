// Método Main

using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
System.Console.Write("Digite o salário: ");
f1.Salario = Convert.ToDecimal(Console.ReadLine()); // set (alteração)

f1.CalcularAumento(5);
System.Console.WriteLine($"Salário após aumento: {f1.Salario:c}"); // get (busca)