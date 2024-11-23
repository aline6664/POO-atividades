using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class ItemVenda : IMetodoMostrar
    {
        // atributos
        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        private double subtotal;
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private Produto produto;
        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        // construtor
        public ItemVenda()
        {
            
        }
        public ItemVenda(int quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }
        // metodos
        public double CalcularSubtotal() {
            subtotal = quantidade * produto.Preco;
            return subtotal;
        }
        public void MostrarDados()
        {
            System.Console.WriteLine($"Quantidade: {quantidade} \t\tNome: {produto.Nome} \t\tPreço: {produto.Preco:c} \t\tSubtotal: {subtotal:c}");
        }
    }
}