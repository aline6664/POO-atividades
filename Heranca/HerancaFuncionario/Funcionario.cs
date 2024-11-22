using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string nome = "";
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Funcionario()
        {
            
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void MostrarAtributos() //virtual -> polimorfismo na superclasse
        { 
            System.Console.WriteLine("Código: "+ Codigo +"\tNome: "+ Nome +"\tSalário: R$ "+Salario);
        }
        public virtual double CalcularBonificacao()
        {
            return Salario * 10/100; // 10% de bonificação, não soma ao salário
        }
    }
}