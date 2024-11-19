using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        // atributos
        private Comprador comp;
        public Comprador Comp
        {
            get { return comp; }
            set { comp = value; }
        }
        private Vendedor vend;
        public Vendedor Vend
        {
            get { return vend; }
            set { vend = value; }
        }
        private List<Produto> vetProd;
        public List<Produto> VetProd
        {
            get { return vetProd; }
            set { vetProd = value; }
        }
        // metodos
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Comprador (verba): "+ Comp +"\tVendedor (comissão): "+ Vend);
            System.Console.WriteLine("Produtos: ");
            foreach (Produto p in vetProd)
                System.Console.Write("C"+",");
        }
    }
}