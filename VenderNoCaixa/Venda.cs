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
        private DateTime data = DateTime.Now; // mostrar data atual
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
        public Venda()
        {
            // instância do vetor de itens assim que a venda é instanciada
            VetItens = new List<ItemVenda>();
        }
        public double CalcularTotal() {
            foreach (ItemVenda it in vetItens)
                total += it.CalcularSubtotal();
                return total;
        }
        public int CalcularQuantidadeTotal() {
            int totalQuantidade = 0;
            foreach (ItemVenda it in vetItens)
                totalQuantidade += it.Quantidade;
            return totalQuantidade;
        }
        public void MostrarDados()
        {
            foreach (ItemVenda it in vetItens)
               it.MostrarDados();
            System.Console.WriteLine($"Valor Total: {total:c}");
        }
    }
}