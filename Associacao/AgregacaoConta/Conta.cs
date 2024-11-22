using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; } // estabelecendo a agregação (ligação) entre as classes Cliente e Conta
        public double Saldo { get; set; }
    }
}