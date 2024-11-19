using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetFunc { get; set; } // vetor de funcionários
        public Departamento()
        {
            
        }
        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void AdmitirFuncionarios(Funcionario func) // adicionar funcionários ao List
        {
            VetFunc.Add(func);
        }
        public void ListarFuncionarios()
        {
            System.Console.WriteLine("\nNome do Departamento: "+ Nome);
            foreach (Funcionario f in VetFunc) // para cada objeto de classe Funcionario dentro do vetor...
                f.MostrarAtributos(); // chama o método da classe Funcionario
        }
        public void DemitirFuncionarios(int codigo) // remover funcionários da List usando o código
        {
            for (int i = 0; i < VetFunc.Count; i++) // percorre o vetor de funcionários
            {
                Funcionario f = VetFunc.ElementAt<Funcionario>(i); // pega o funcionário (generalizado) no índice atual
                if (f.Codigo == codigo) { // se o código for igual ao código que deseja remover
                    VetFunc.Remove(f);
                    System.Console.WriteLine("Funcionário excluído com sucesso.");
                }
            }
        }
        public double CalcularFolhaPagamento(int diasUteis)
        {
            double folha = 0; // declaração da variável
            for (int i = 0; i < VetFunc.Count; i++)
            {
                Funcionario f = VetFunc.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis); // método da classe Funcionário
            }
            return folha;
        }
        public void MostrarQtdeDependentesFuncionario(Funcionario f)
        {
            f.ListarDependentes();
        }
    }
}