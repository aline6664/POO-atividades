// Método Main()

using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(4);
ItemNotaFiscal it2 = new ItemNotaFiscal(10);

// realizando instância de NotaFiscal junto com ItemNotaFiscal
NotaFiscal nf = new NotaFiscal(1,"20/09/2024");
nf.VetItens.Add(it1);
nf.VetItens.Add(it2);

foreach (ItemNotaFiscal it in nf.VetItens)
    System.Console.WriteLine("Qtde: "+ it.Qtde);

nf = null;
GC.Collect(); // método que coleta objetos com null (GC - garbage collector)
// ps: VSC não mostra o GC funcionando, apenas no Visual Studio