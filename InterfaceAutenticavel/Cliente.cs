using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    // interface é implementada simiilar a herança
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autentica(int senha)
        {
            if (Senha == senha) { // se propriedade (atributo) for igual ao parametro (senha digitada)
                System.Console.WriteLine("Cliente autenticado.");
                return true;
            }
            return false;
        }
    }
}