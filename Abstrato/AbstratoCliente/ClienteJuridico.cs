using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteJuridico : Cliente
    {
        public string Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome, int idade, string cnpj) : base(codigo, nome, idade)
        {
            Cnpj = cnpj;
        }        
        public override void MostrarAtributos()
        { 
            base.MostrarAtributos();
            System.Console.WriteLine("CNPJ: "+ Cnpj);
        }
        public override void VerificarIdade() // criação da lógica de programação AQUI em vez da superclasse (método abstrato)
        {
            if (Idade >= 41)
                System.Console.WriteLine("Cliente Jurídico");
        }
    }
}