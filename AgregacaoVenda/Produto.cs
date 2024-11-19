using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        // atributos
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value;}
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        private static double valor_total;
        public static double Valor_total
        {
            get { return valor_total; }
            set { valor_total = value; }
        }
        
        public Produto()
        {
            Valor_total =+ valor_total + preco;
        }
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Valor_total = valor_total + preco;
        }
        // metodos
        public void MostrarAtributos()
        {
            codigo = codigo + 500;
            System.Console.WriteLine("Código: "+ codigo +"\tNome: "+ nome +"\tPreço: R$ "+ preco);
        }
    }
}