// Método Main

using AgregacaoConta;

Cliente cli = new Cliente("Ana", 20, "(18)99656-7049"); // possui construtor

// Maneira mais comum de agregação
Conta c1 = new Conta();
c1.Numero = 1; // sinal de atribuição (=) - set
c1.Saldo = 100;
c1.Titular = cli; // execução da agregação, ligação estabelecida onde Titular puxa os atributos e métodos do Cliente
// Atributo "titular" passa a ser um objeto após realizar instância

// Outra maneira de fazer
Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 200;
c2.Titular = new Cliente(); // realizando nova instância, necessita de um construtor padrão na classe Cliente!
c2.Titular.Nome = "Bia"; // entra na classe Conta e depois na classe Cliente
c2.Titular.Idade = 21;
c2.Titular.Telefone = "(18)99839-4584";
