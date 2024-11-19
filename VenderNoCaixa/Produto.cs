using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Produto
    {
        private long codigo;
        public long Codigo
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
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        private int estoque;
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        // construtores
        public Produto()
        {
            
        }
        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        // métodos
        public void MostrarDadosProduto()
        {
            System.Console.WriteLine("Código: "+ codigo +"\tNome: "+ nome +$"\t\tPreço: {preco:c}\t\tEstoque: "+ estoque);
        }
    }
}