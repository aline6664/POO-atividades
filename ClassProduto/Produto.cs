using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
    
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome +
            "\tPreço: R$ " + preco);        
        }
        public void ValorTotalProdutos(double preco)
        {
            double SomaPreco =+ preco;
        }
    }
}