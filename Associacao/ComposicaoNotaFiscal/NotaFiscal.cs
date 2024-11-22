using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }
        public NotaFiscal(int numeroNF, string data) // a composição é estabelecida, fazendo a ligação
        // vetor não é colocado ainda nos parametros
        {
            NumeroNF = numeroNF;
            Data = data;
            VetItens = new List<ItemNotaFiscal>(); // execução da composição
            // ambos NotaFiscal e ItemNotaFiscal são instanciados ao MESMO TEMPO JUNTOS
        }
        ~NotaFiscal() // destrutor
        {
            VetItens = null; // liberação do objeto, limpa a variável e libera espaço
            System.Console.WriteLine("Destruindo o objeto Nota Fiscal...");
        }
    }
}