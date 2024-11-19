using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;
        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        // A comissão do vendedor é gerada referente a 2% do preço do produto vendido
        public void CalculoComissao(double preco_produto)
        {
            comissao = 0.02 * preco_produto;
        }
        public void MostrarAtributo()
        {
            System.Console.WriteLine("Comissão gerada: "+ comissao);
        }
    }
}