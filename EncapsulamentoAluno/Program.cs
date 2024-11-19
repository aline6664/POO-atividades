// Método Main
// Usar propriedades em vez de atributos !
// Propriedades são públicas enquanto atributos estão privadas

using EncapsulamentoAluno;

Aluno al1 = new Aluno();
al1.Matricula = 1;
al1.P1 = 10;
al1.P2 = 9;
// al1.Media = 19; Media foi feito com apenas "get", logo é apenas leitura e não é possível atribuir um valor a ele
al1.CalcularMedia();
System.Console.WriteLine(al1.Media);
al1.MostrarAtributos();