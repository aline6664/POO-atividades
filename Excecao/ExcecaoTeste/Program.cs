// comando para especificação de exceção
// similar ao if, mas é executado mais lento
// geralmente usado em situações de acesso externo (ex: acessar um banco de dados)
/*
try
{
    File.OpenRead("\\teste\\ArquivoLeitura.txt"); // tentativa de abrir e ler um arquivo e diretório inexistente
}

// subcomando do "try" que pega o problema e trata)
// pode haver vários "catch"
catch (FileNotFoundException e) // cria o objeto e na classe FileNotFoundException

{
    System.Console.WriteLine("Erro pelo FileNotFoundException");
    System.Console.WriteLine(e.ToString()); // apresentando a mensagem de erro do FileNotFoundException)
}
catch (DirectoryNotFoundException e)
{
    System.Console.WriteLine("Erro pelo DirectoryNotFoundException");
    System.Console.WriteLine(e.ToString()); // apresentando a variável e
}
*/

// Exemplo de exceção de divisão por zero
int a = 9;
int b = 0;
try {
    System.Console.WriteLine("Resultado: " + (a / b));
}
// Nota: só entra no aqui se o código retornar um Exception, caso contrário, irá rodar normalmente
catch (Exception e) { // pode-se usar sua subclasse: DivideByZeroException
    System.Console.WriteLine("Erro: Não pode ocorrer divisão por zero\n" +
    "Tipo erro: "+ e.Message);
}

// subcomando que SEMPRE será executado, independentemente se dar exception ou não
// geralmente usado para realizar o fechamento do código
finally {
    System.Console.WriteLine("Fechamento obrigatório");
}
System.Console.WriteLine("Término do programa");

// Nota: TRY e CATCH só podem existir juntos, nunca separado


