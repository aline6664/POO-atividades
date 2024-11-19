using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public Conta() // construtor padrão
        { 

        }
        public Conta(int numero)
        { 
            Numero = numero;
        }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void MostrarAtributos() // representativo de apresentação dos valores da classe
        {
            System.Console.WriteLine("Número: " + Numero +
            "\tTitular: " + Titular +
            "\tSaldo: R$ " + Saldo);
        }
    }
}