// Método Main()
using ClassFuncionario;

//Realizar instâncias
Funcionario objetoFuncionario = new Funcionario();

objetoFuncionario.codigo = 1;
objetoFuncionario.nome = "João";
objetoFuncionario.salario = 1500;
objetoFuncionario.MostrarAtributos();
objetoFuncionario.CalcularAumentoSalarial(10); // 10%
objetoFuncionario.MostrarAtributos();
