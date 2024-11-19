using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    // classe derivada : classe base, interface
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autentica(int senha) // este metodo liga com a interface
        {
            if (Senha == senha) { // se propriedade (atributo) for igual ao parametro (senha digitada)
                System.Console.WriteLine("Gerente autenticado.");
                return true;
            } // nesse caso não é necessário um else pois ele se não entrar no if, já sai para fora e cai no return false
            return false;
        }
    }
}