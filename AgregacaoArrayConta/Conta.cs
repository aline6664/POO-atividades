using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public List<Cliente> VetTitulares { get; set; } // List<generics> serve para declarar um vetor em aberto, sem uma qtde definida a ser inserida
        public double Saldo { get; set; }
    }
}