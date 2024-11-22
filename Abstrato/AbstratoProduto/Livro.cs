using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoProduto
{
    public class Livro : Produto
    {
        private string autor = "";
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private long isbn;
        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public Livro()
        {
            
        }
        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Autor = autor;
            Isbn = isbn;
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine("Autor: "+ autor +"\t ISBN: "+ isbn);
        }
        public override void AtualizarPreco(double novoPreco)
        {
            preco = novoPreco;
            System.Console.WriteLine("Novo preço do livro atualizado.");
        }
    }
}