using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes // pasta
{
    public class Conta
    {
        // declaração de atributos
        public int numero; // public -> aberto, qualquer arquivo pode acessar e ver (aparece no menu suspenso)
        public string titular;
        public double saldo; // double -> float com alta precisão de números decimais

        // declaração dos métodos
        public void MostrarAtributos() // representativo de apresentação dos valores da classe
        {
            System.Console.WriteLine("Número: " + numero +
            "\tTitular: " + titular +
            "\tSaldo: R$ " + saldo);
        }
        public void Sacar(double valorSaque) // parâmetro que receberá da main (Program.cs)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo = saldo + valorDeposito;
        }
        // Desenvolva um método para calcular IOF % desconte
        // Retorne o valor que será descontado e apresente na main()
        public double CalcularIOF(double porcentagem)
        {
            double valorDescontado = saldo * porcentagem/100;
            saldo -= valorDescontado;
            return valorDescontado;
        }
        // Transferencia de valor de uma conta para outra
        // Comunicação entre objetos diferentes
        public void Transferencia(double valorTransferencia, Conta outraConta) // variável de objeto
        {
            saldo = saldo - valorTransferencia;
            outraConta.saldo = outraConta.saldo + valorTransferencia;
        }
    }
}