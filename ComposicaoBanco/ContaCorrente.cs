using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        // atributos
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        private double chequeEspecial;
        public double ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }
        private static double contadorDeposito;
        public static double ContadorDeposito
        {
            get { return contadorDeposito; }
            set { contadorDeposito = value; }
        }
        private static double contadorSaque;
        public static double ContadorSaque
        {
            get { return contadorSaque; }
            set { contadorSaque = value; }
        }
        //public static double contadorDeposito { get; set; }
        //public static double ContadorSaque { get; set; }
        public ContaCorrente(int saldo) // construtor
        {
            Saldo = saldo;
        }
        //métodos
        public void Depositar(double valorDeposito)
        {
            saldo =+ valorDeposito;
            ContadorDeposito =+ valorDeposito;
        }
        public void Sacar(double valorSaque)
        {
            saldo =- valorSaque;
            ContadorSaque =+ valorSaque;
        }
        public void GerarExtrato(double valorDeposito, double valorSaque)
        {
            // mostrar os saques e depósitos da conta corrente?
            System.Console.WriteLine("Valor total de depósitos realizados este mês: "+ valorDeposito + "\tValor total de saques realizados este mês: "+ valorSaque);
        }
    }
}