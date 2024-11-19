using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    // atributos
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int qtde;
    
        // métodos
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome +
            "\tPreço: R$ " + preco +
            "\tQuantidade: " + qtde);
        }
    }
}
// Produto(codigo,nome,preco,qtde)