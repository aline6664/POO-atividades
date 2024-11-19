using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        // propfull
        private int codigo;
        public int Codigo // propriedade - MAIÚSCULO
        {
            get { return codigo; } // busca
            set {                  // atribuição
                if (value > 0)
                    codigo = value;
                else
                    System.Console.WriteLine("Informe um código válido.");
            } 
        }
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { 
                if (value != "" || value != null)
                    nome = value;
                else
                    System.Console.WriteLine("Informe o nome do produto.");
            }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set { 
                if (value != 0)
                    preco = value;
                else
                    System.Console.WriteLine("Informe o preço do produto.");
            }
        }
        
        private int qtde;
        public int Qtde
        {
            get { return qtde; }
            set { 
                if (value != 0)
                    qtde = value;
                else
                    System.Console.WriteLine("Informe a quantidade.");
            }
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome +
            "\tPreço: R$ " + preco +
            "\tQuantidade: " + qtde);  
        }

        
    }
}