using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente()
        {
            
        }
        public Gerente(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
            
        }
        public override double CalcularBonificacao()
        {
            return Salario * 15/100; // 15% de bonificação apenas ao gerente
        }
    }
}