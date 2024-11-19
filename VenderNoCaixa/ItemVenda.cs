using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class ItemVenda
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
        public ItemVenda(int quantidade)
        {
            Quantidade = quantidade;
        }
    }
}