using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstratoCliente
{
    public class ClienteFisico : Cliente // classe concreta (NÃO é abstrato)
    {
        public string Rg { get; set; }
        public ClienteFisico(int codigo, string nome, int idade, string rg) : base(codigo, nome, idade)
        {
            Rg = rg;
        }        
        public override void MostrarAtributos() // método concreto (NÃO é abstrato)
        { 
            base.MostrarAtributos();
            System.Console.WriteLine("RG: "+ Rg);
        }
        public override void VerificarIdade() // criação da lógica de programação AQUI em vez da superclasse (método abstrato)
        {
            if (Idade >= 18 && Idade <= 40)
                System.Console.WriteLine("Cliente Físico");
        }
    }
}