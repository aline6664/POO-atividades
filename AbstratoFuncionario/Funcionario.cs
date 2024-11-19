using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VetDep { get; set; }
        public Funcionario()
        {
            
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void MostrarAtributos() // método com polimorfismo
        {
            System.Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + $"\tSalário: {Salario:c}");
        }
        public abstract double CalcularSalario(int diasUteis);

        // Métodos dos Dependentes
        public int CalcularTotalDependente()
        {
            // int totalDependente = 0; // zera o valor da variável
            int totalDependente = VetDep.Count; // conta a quantidade de elementos no vetor de dependentes
            return totalDependente;
        }
        public void AdicionarDependente(Dependente novoDep)
        {
            VetDep.Add(novoDep);
        }
        public void RemoverDependentesMaiorIdade(int codigo) // método que é realizado automaticamente?
        // chama o método VerificarMaiorIdade() da classe Dependente para ter certeza se tem +18?
        {
            for (int i = 0; i < VetDep.Count; i++)
            {
                Dependente dep = VetDep.ElementAt<Dependente>(i);
                if (dep.Codigo == codigo) {
                    if (dep.VerificarMaiorIdade() == true) {
                        VetDep.Remove(dep);
                        System.Console.WriteLine("Dependente removido com sucesso.");
                    }
                    else
                        System.Console.WriteLine("Dependente não é maior de idade. Não foi possível excluir.");
                }
            }
        }
        public void ListarDependentes()
        {
            System.Console.WriteLine("\nFuncionário: "+ this.Nome);
            foreach (Dependente dep in VetDep)
                dep.MostrarAtributos();
        }
    }
}