using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPConta
{
    public class GeradorRelatorios
    {
        public string GerarRelatorio(Conta conta)
        {
            return $"Titular: {conta.Titular} \nSaldo atual: {conta.Saldo:c}";
        }
    }
}