using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    // classe que realiza apenas a verificação da idade pra QUALQUER classe herdada do Cliente
    // não possui atributos, pois pega tudo do objeto via parâmetro
    public class Teste
    {
        public void AvaliarIdade(Cliente cliente) // chama o objeto cliente da classe Cliente, que é generalizado
        // logo, esse método se aplica a TODAS classes filhas da classe Cliente
        // o objeto "cliente" pode ser qualquer nome pois ela simplesmente representa qualquer objeto das classes filhas
        {
            cliente.VerificarIdade();
        }
    }
}