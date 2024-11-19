using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoProduto
{
    public abstract class Produto
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public Produto()
        {
            
        }
        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }
        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine("Código: "+ codigo +$"\t Preço: {preco:c}");
        }
        public abstract void AtualizarPreco(double novoPreco);
    }
}