using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta // pasta
{
    public class Conta
    {
        // declaração de atributos
        private int numero; // o atributo está encapsulado
        private string titular;
        private double saldo;

        // declaração dos métodos
        /* Exemplo de método de encapsulamento - Modelo Java ou PHP
        public void setNumero(int numero) // função para alterar o valor encapsulado
        {
            this.numero = numero; // this.(objeto atual instanciado) = parâmetro / nesse caso ambos possuem mesmo nome,
            // mas são coisas diferentes
        }
        public int getNumero()
        {
            return this.numero; // busca o valor
        }
        */

        // Convenção C#
        public int Numero // Numero (maiusculo) = propriedade
        // dentro da propriedade tem set e get
        {
            set // valores que podem ser cadastrados, nem todas funções precisam de um set
            {
                if (value > 0) // validação do valor
                    this.numero = value; // numero (minusculo) = atributo
                    // value - recebe qualquer valor externo
            }
            get
            {
                return numero;
            }
        }

        //propfull + tab
        public string Titular
        {
            get { return titular.ToUpper(); } // função que apresenta a string em maiúsculo
            set { 
                if (value != "") // validação
                    titular = value;
                else
                    System.Console.WriteLine("Nome inválido.");
            }
        }

        public double Saldo
        {
            get { return saldo; }
            // set { saldo = value; } - não é necessário, pois o valor Saldo já tem outras funções que realizam alteração
        }
        
        
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Número: " + numero +
            "\tTitular: " + titular +
            "\tSaldo: R$ " + saldo);
        }
        public void Sacar(double valorSaque)
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
        public void Transferencia(double valorTransferencia, Conta outraConta)
        {
            saldo = saldo - valorTransferencia;
            outraConta.saldo = outraConta.saldo + valorTransferencia;
        }
    }
}