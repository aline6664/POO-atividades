// Método Main()
using ConstrutorConta;

Conta c1 = new Conta();
// class objeto(variável de instância = instância(alocação de memória) construtor)
c1.MostrarAtributos();
// nota-se que ao rodar sem atribuir nenhum valor, o construtor já apresenta valores padrões
// onde valores int/double são 0 e string é nulo

Conta c2 = new Conta(120);
c2.MostrarAtributos();

Conta c3 = new Conta(200, "Ana");
c3.MostrarAtributos();

Conta c4 = new Conta(350, "Pedro", 4200);
c4.MostrarAtributos();


