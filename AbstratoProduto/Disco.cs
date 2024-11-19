using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoProduto
{
    public class Disco : Produto
    {
        private string artista = "";
        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }
        private string gravadora = "";
        public string Gravadora
        {
            get { return gravadora; }
            set { gravadora = value; }
        }
        public Disco()
        {
            
        }
        public Disco(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine("Artista: "+ artista +"\t Gravadora: "+ gravadora);
        }
        public override void AtualizarPreco(double novoPreco)
        {
            preco = novoPreco;
            System.Console.WriteLine("Novo preço do disco atualizado.");
        }
    }
}