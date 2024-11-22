using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public static int Contador { get; set; }
        
        // Criar a classe Aluno com atributos matrícula, nome
        // Matrícula código Fatec - 1570482313000
        // 157 (Código Fatec Pres Prudente) 048 (Código do curso) 23 (ano) 1 (semestre) 3000 (turma da noite)
        // Usar o static para gerar o RA de cada aluno (seu código é gerado por ordem de matrícula)
        public Aluno() // construtor padrão
        {

        }
        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            Contador++;
        }
        public void MostrarAtributos()
        {
            Matricula = Contador + 3000;
            System.Console.WriteLine("Matrícula: 157048231" + Matricula +
            "\tNome: " + Nome);
        }
    }
}