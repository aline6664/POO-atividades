using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Dependente()
        {
            
        }
        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tIdade: "+ Idade +" anos");
        }
        public bool VerificarMaiorIdade() // verifica se o dependente tem +18 anos
        {
            if (Idade >= 18)
                return true;
            else
                return false;
        }
    }
}