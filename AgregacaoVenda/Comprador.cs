using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        // atributos
        private double verba;
        public double Verba
        {
            get { return verba; }
            set { verba = value; }
        }
        // construtores
        public Comprador() // construtor padrão
        {

        }
        public Comprador(double verba)
        {
            Verba = verba;
        }
        // métodos
        public void CalculoVerba(double valor_produtos)
        {
            double resto_verba = verba - valor_produtos;
            System.Console.WriteLine("Verba atual: " + resto_verba);
        }
        public void MostrarAtributo()
        {
            System.Console.WriteLine("Valor da verba: "+ Verba);
        }
    }
}