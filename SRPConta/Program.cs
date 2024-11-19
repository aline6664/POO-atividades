// Método Main()
using SRPConta;

// Instância da Conta
Conta c = new Conta("João da Silva");
// c.MostrarAtributos();

// Responsabilidades do validador de usuarios
System.Console.WriteLine("----- VALIDAÇÃO DO USUÁRIO -----");
ValidadorUsuarios vu = new ValidadorUsuarios();
bool validador = vu.ValidarUsuario("João da Silva",c); // recebe o retorno para verificar no if
if (validador) 
{
    System.Console.WriteLine("Usuário validado com sucesso. Bem-vindo(a).");
}
else
    System.Console.WriteLine("Usuário não validado. Por favor, tente novamente.");

// Responsabilidades da conta
System.Console.WriteLine("----- DEPÓSITO -----");
c.Depositar(1000);
System.Console.WriteLine("----- SAQUE -----");
c.Sacar(100);

// Testes
// c.Depositar(-200);
// c.Sacar(2000);

// Responsabilidades do gerador de relatorios
System.Console.WriteLine("----- RELATÓRIO -----");
GeradorRelatorios g = new GeradorRelatorios();
System.Console.WriteLine(g.GerarRelatorio(c));

