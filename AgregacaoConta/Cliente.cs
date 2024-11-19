using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public Cliente(string nome, int idade, string telefone) // construtor
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
        }
        public Cliente() // construtor padrão
        {
            
        }
    }
    
}