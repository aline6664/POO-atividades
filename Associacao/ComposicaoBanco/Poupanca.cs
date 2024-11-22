using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        // atributos
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Poupanca(int saldo) // construtor
        {
            Saldo = saldo;
        }
        //métodos
        public void Depositar(double valorDeposito)
        {
            saldo =+ valorDeposito;
        }
        public void Sacar(double valorSaque)
        {
            saldo =- valorSaque;
        }
    }
}