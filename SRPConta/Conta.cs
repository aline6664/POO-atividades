using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPConta
{
    public class Conta
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public Conta()
        {
            
        }
        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                System.Console.WriteLine("Valor não pode ser negativo.");
            }
            else
            {
                Saldo += valor;
                System.Console.WriteLine($"Depósito de {valor:c} realizado com sucesso.");
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                System.Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                System.Console.WriteLine($"Saque de {valor:c} realizado com sucesso.");
            }
        }
        public void MostrarAtributos()
        {
           System.Console.WriteLine("Titular: "+ Titular +$"\nSaldo atual: {Saldo:c}");
        }
    }
}