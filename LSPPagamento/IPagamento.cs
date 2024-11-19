using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSPPagamento
{
    public interface IPagamento
    {
        void ProcessarPagamento(decimal valor);
    }
}