using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        // Criar 3 construtores
        // Código, nome, preço
        // ctor + tab
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static int Cont { get; set; } // static -> deixa FORA da instância
        // controlado pela Classe em vez do Objeto instanciado, útil para contadores
        // pois assim o atributo não é restrito apenas dentro do objeto

        public Produto() // construtor padrão
        {
            Cont ++;
        }
        public Produto(int codigo)
        {
            Codigo = codigo;
            Cont ++;
        }
        public Produto(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Cont ++;
        }
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Cont ++;
        }  
        public void MostrarAtributos()
        {
            // int cont = 0; --- NÃO FUNCIONA, pois o contador é local para cada objeto, logo, não ocorre contagem
            System.Console.WriteLine("Código: " + Codigo +
            "\t\tNome: " + Nome +
            "\t\tPreço: R$ " + Preco);
            // cont ++;
        }
    }
}