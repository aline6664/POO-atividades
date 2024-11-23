using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class DescontoAtacado : IMetodoMostrar
    {
        // atributos
        private double valorDesconto = 0;
        public double ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = value; }
        }
        
        private Venda venda;
        public Venda Venda
        {
            get { return venda; }
            set { venda = value; }
        }
        // construtor
        public DescontoAtacado()
        {
            
        }
        public DescontoAtacado(Venda venda)
        {
            Venda = venda;
        }
        // metodos
        public double CalcularDesconto() {
            valorDesconto = venda.Total * 0.20;
            venda.Total -= valorDesconto;
            return venda.Total;
        }
        public void MostrarDados() {
            System.Console.WriteLine($"Valor Desconto: {valorDesconto:c} \nTipo do Desconto: DESCONTO ATACADO\n");
        }
    }
}