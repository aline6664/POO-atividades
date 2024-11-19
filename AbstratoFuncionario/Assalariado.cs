using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Assalariado : Funcionario // ver quanto o funcionário ganha por mês
    {
        // não possui atributos novos

        public Assalariado()
        {
            
        }
        public Assalariado(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
            // não possui atributos próprios da classe para atribuir
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis; // 30 representa os dias trabalhados em um mês
        }
    }
}