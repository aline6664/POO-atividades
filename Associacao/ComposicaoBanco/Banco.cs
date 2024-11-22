using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        // atributos
        private List<Poupanca> poups;
        public List<Poupanca> Poups
        {
            get { return poups; }
            set { poups = value; }
        }
        private List<ContaCorrente> contas;
        public List<ContaCorrente> Contas
        {
            get { return contas; }
            set { contas = value; }
        }
        public Banco() // construtor
        {
            Poups = new List<Poupanca>();
            Contas = new List<ContaCorrente>();
        }

        // métodos
        public void IniciarBanco()
        {
            System.Console.WriteLine("Iniciando Banco...");
            System.Console.WriteLine("Escolha uma opção");
            System.Console.WriteLine("1 - Abrir conta \n2- Abrir poupança");
        }
    }
}