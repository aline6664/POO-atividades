using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente // transforma a classe em abstract, não permitindo ser instanciado
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome = "";
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        

        public Cliente()
        {
            
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public virtual void MostrarAtributos() //virtual -> polimorfismo na superclasse
        { 
            System.Console.WriteLine("Código: "+ Codigo +"\tNome: "+ Nome +"\tIdade: "+ Idade +" anos");
        }
        // ASSINATURA DE MÉTODO (método abstrato)
        // possibilita saber o que ele faz pelo nome, se precisa de parâmetro e será ter retorno
        // Mas não sabe como fazer, ou seja, NÃO TEM LÓGICA DE PROGRAMAÇÃO DENTRO DELA, e sim na classe filha
        // superclasse declara o método (seu nome, se tem retorno e parâmetros) mas não faz nada e deixa pras subclasses fazerem
        // Método abstrato não é obrigatório numa classe abstrata
        public abstract void VerificarIdade();
        // usa ponto e vírgula no final, usado apenas na classe abstract
    }
}