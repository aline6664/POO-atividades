using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Venda
    {
        // atributos
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        // relacionamento de composição
        private List<ItemVenda> vetItens;
        public List<ItemVenda> VetItens
        {
            get { return vetItens; }
            set { vetItens = value; }
        }
        // métodos
        public void MostrarDadosVenda()
        {
            foreach (ItemVenda it in vetItens)
                System.Console.WriteLine(it);
        }
    }
}