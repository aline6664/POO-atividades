using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        // prop + tab
        public int Matricula { get; set; }  // propriedade
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public void CalcularAumento(decimal porcentagem)
        {
            Salario += Salario * porcentagem / 100; // é usado a propriedade do salário em vez do atributo
        }
    }
}