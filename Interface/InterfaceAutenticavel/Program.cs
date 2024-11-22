// Metodo Main()
using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Senha = 123;

Cliente c = new Cliente();
c.Senha = 200;

// não é possível instanciar interface
// IAutenticavel ia = new IAutenticavel();

// mas pode declarar variável e receber objeto instanciado
IAutenticavel ia = g; // recebe o objeto gerente
System.Console.WriteLine("Acessou o sistema? "+ ia.Autentica(124));
// na interface, ele só consegue acessar o método que ambas compartilham, nesse caso o método Autentica()
// ele não verá outros métodos ou atributos

ia = c; // recebe o objeto cliente
System.Console.WriteLine("Acessou o sistema? "+ ia.Autentica(200));