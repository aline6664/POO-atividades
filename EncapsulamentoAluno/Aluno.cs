using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {
        // Criar os atributos e encapsulamentos necessários dos atributos: matrícula, nome, p1, p2, média;
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set { 
                if (value > 0)
                matricula = value;
                }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private double p1;
        public double P1
        {
            get { return p1; }
            set {
                if (value > 0)
                p1 = value;
                }
        }
        private double p2;
        public double P2
        {
            get { return p2; }
            set {
                if (value > 0)
                p2 = value;
                }
        }
        private double media;
        public double Media
        {
            get { return media; } // não precisa de set pois vai retornar de cálculo
            //set { media = value; } // <- nesse caso é opcional, está sendo usado aqui nesse caso
            // para poder chamar a propriedade no public void CalcularMedia()
        }
        public void CalcularMedia()
        {
            media = (P1 + P2) / 2; // opcional, mas utiliza-se a propriedade (maiúsculo) apenas se tiver o "set"
            // senão, apenas pode usar o atributo (minúsculo)
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Matrícula: " + matricula +
            "\tP1: " + P1 + "\tP2: " + P2 + "\tMédia: " + media);
        }
        
        // Criar um método para CalcularMedia()
        // O atributo média NÃO terá set por conta deste método

        // No atributo nome, retorne em letras maiúsculas (toUpper())

        // Trate os atributos matricula, p1, p2 para não cadastrar valor zero ou negativo (usando if/else)

        // Criar o método MostrarAtributos()
    }
}