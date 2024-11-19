// Método Main()

using AbstratoCliente;

// * Ocorre erro na instância do objeto de uma classe abstrata, pois não pode instanciar
// Cliente c = new Cliente(1, "Alberto", 23);
// c.MostrarAtributos();

// apenas suas classes filhas podem ser instanciados

ClienteFisico cf = new ClienteFisico(2, "Beatriz", 34, "13.234.565-4");
cf.MostrarAtributos();

ClienteJuridico cj = new ClienteJuridico(3, "Empresa SA", 45, "38-429-345-65");
cj.MostrarAtributos();

Teste teste = new Teste();
teste.AvaliarIdade(cf);
teste.AvaliarIdade(cj);