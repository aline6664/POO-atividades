using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }
        public ItemNotaFiscal(int qtde) // realiza instância no construtor
        {
            Qtde = qtde;
        }
        ~ItemNotaFiscal() // destrutor, usa ~ na classe
        {
            System.Console.WriteLine("Destruindo o objeto ItemNotaFiscal...");
        }
    }
    // Destrutor - usado pra destruir instâncias de classes
    // ativado automaticamente quando deleta recursos (não pode ser chamado)
}