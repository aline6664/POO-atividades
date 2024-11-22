using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassFuncionario
{
    public class Funcionario
    {
        // declaração de atributos
        public int codigo;
        public string nome;
        public double salario;
        // declaração de métodos
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome +
            "\tSalário: R$ " + salario);
        }
        /* criar um método para calcular o aumento salarial
        a partir de uma porcentagem passada via parâmetro */
        public void CalcularAumentoSalarial(double porcentagem)
        {
            salario += salario * porcentagem/100;
        }
    }
}